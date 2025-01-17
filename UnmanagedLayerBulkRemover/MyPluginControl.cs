using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Activities.Expressions;
using XrmToolBox.Extensibility.Args;
using XrmToolBox.Extensibility.Interfaces;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UnmanagedLayerBulkRemover
{
    public partial class MyPluginControl : PluginControlBase, IStatusBarMessenger, IGitHubPlugin
    {
        private Settings mySettings;
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        #region IGitHubPlugin implementation

        public string RepositoryName => "UnmanagedLayerBulkRemover";

        public string UserName => "mkmk89";

        #endregion IGitHubPlugin implementation

        public MyPluginControl()
        {
            InitializeComponent();
            LoadAdBannerAsync();
            SelectDefaultFilters(new List<string>() {
            "Attribute",
            "Relationship",
            "OptionSet",
            "Form",
            "Workflow",
            "SystemForm",
            "WebResource",
            "SiteMap",
            "PluginAssembly",
            "SdkMessageProcessingStep",
            "CanvasApp"
            });
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            //ShowInfoNotification("This tool has been created to make bulk unmanaged layers removal possible without coding. ", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbGetSolutions_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetSoltuionsMethod);
        }



        private void GetSoltuionsMethod()
        {
            Logic logic = new Logic(Service);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting solutions",
                Work = (worker, args) =>
                {
                    args.Result = logic.GetSolutions();
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    unmanagedLayersDataGrid.DataSource = result.Entities.Select(
                        x => new SolutionItem()
                        {
                            UniqueName = x.Contains("uniquename") ? (string)x.Attributes["uniquename"] : string.Empty,
                            FriendlyName = x.Contains("friendlyname") ? (string)x.Attributes["friendlyname"] : string.Empty,
                            Version = (string)x.Attributes["version"],
                            IsManaged = (bool)x.Attributes["ismanaged"] ? "Managed" : "Unmanaged"
                        }).OrderBy(x => x.UniqueName).ToList();
                }
            });
        }

        private void RemoveLayers()
        {
            Logic logic = new Logic(Service);

            if (unmanagedLayersDataGrid.SelectedRows.Count != 1)
                MessageBox.Show("Please select one solution");
            var selectedRow = unmanagedLayersDataGrid.SelectedRows[0];
            var dialogResult = MessageBox.Show($"Are you sure you want to remove unmanaged layers from components in solution '{((SolutionItem)selectedRow.DataBoundItem).FriendlyName}'? This will remove all changes that were made directly in the environment leaving only those imported with managed solutions.", "Warining", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel)
                return;
            List<string> filteredComponents = new List<string>();
            foreach (var item in clbFilters.CheckedItems)
                filteredComponents.Add((string)item);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Removing layers...",
                Work = (worker, args) =>
                {
                    args.Result = logic.RemoveUnmanagedLayers(worker, ((SolutionItem)selectedRow.DataBoundItem).UniqueName, filteredComponents);
                },
                ProgressChanged = e =>
                {
                    // If progress has to be notified to user, use the following method:
                    //SetWorkingMessage("Message to display");

                    // If progress has to be notified to user, through the
                    // status bar, use the following method
                    SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(e.ProgressPercentage, e.UserState.ToString()));
                },
                PostWorkCallBack = (args) =>
                {
                    SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(string.Empty));

                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach (var line in (List<LogLine>)args.Result)
                            AppendText(rtbLogs, line.Text, line.Color);
                    }
                },
                AsyncArgument = null,
                IsCancelable = true,
                MessageWidth = 340,
                MessageHeight = 150
            });
        }


        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            unmanagedLayersDataGrid.DataSource = new List<SolutionItem>();
            unmanagedLayersDataGrid.Columns[0].FillWeight = 200;
            unmanagedLayersDataGrid.Columns[1].FillWeight = 300;
            unmanagedLayersDataGrid.Columns[2].FillWeight = 100;
            unmanagedLayersDataGrid.Columns[3].FillWeight = 100;

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void tsbRemoveUnamangedLayers_Click(object sender, EventArgs e)
        {
            ExecuteMethod(RemoveLayers);
        }

        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        void SelectDefaultFilters(List<string> supportedFilters)
        {
            foreach (string value in supportedFilters)
                clbFilters.SetItemChecked(clbFilters.Items.IndexOf(value), true);
        }

        private async Task LoadAdBannerAsync()
        {
            try
            {
                // Fetch ad details from Google Ad Manager API or your endpoint
                var adDetails = await FetchAdDetailsAsync("http://ads.owware.com/unmanagedlayerremover");
                if (adDetails != null && !string.IsNullOrEmpty(adDetails.ImageUrl))
                {
                    AddAdBanner(adDetails);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during ad fetching (e.g., log or show a message)
            }
        }

        private async Task<AdDetails> FetchAdDetailsAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response to get ad details (e.g., JSON to AdDetails object)
                    var json = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<AdDetails>(json);
                }
            }
            return null;
        }

        private void AddAdBanner(AdDetails adDetails)
        {
            bannerBox.ImageLocation = adDetails.ImageUrl;
            bannerBox.Visible = true;
            closeBanner.Visible = true;
            closeBanner.Click += (sender, e) => { bannerBox.Visible = false; closeBanner.Visible = false;  };
            // Handle click event for ad actions
            bannerBox.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(adDetails.ClickUrl))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = adDetails.ClickUrl,
                        UseShellExecute = true
                    });
                }
            };
        }
    }

    // AdDetails class to deserialize API response
    public class AdDetails
    {
        public string ImageUrl { get; set; }
        public string ClickUrl { get; set; }
    }
}