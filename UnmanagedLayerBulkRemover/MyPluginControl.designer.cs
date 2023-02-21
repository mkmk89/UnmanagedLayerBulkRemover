namespace UnmanagedLayerBulkRemover
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGetSolutions = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveUnamangedLayers = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.clbFilters = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unmanagedLayersDataGrid = new System.Windows.Forms.DataGridView();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.toolStripMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unmanagedLayersDataGrid)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGetSolutions,
            this.tssSeparator1,
            this.tsbRemoveUnamangedLayers});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(960, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbGetSolutions
            // 
            this.tsbGetSolutions.Image = ((System.Drawing.Image)(resources.GetObject("tsbGetSolutions.Image")));
            this.tsbGetSolutions.Name = "tsbGetSolutions";
            this.tsbGetSolutions.Size = new System.Drawing.Size(113, 28);
            this.tsbGetSolutions.Text = "Load Solutions";
            this.tsbGetSolutions.Click += new System.EventHandler(this.tsbGetSolutions_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbRemoveUnamangedLayers
            // 
            this.tsbRemoveUnamangedLayers.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveUnamangedLayers.Image")));
            this.tsbRemoveUnamangedLayers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveUnamangedLayers.Name = "tsbRemoveUnamangedLayers";
            this.tsbRemoveUnamangedLayers.Size = new System.Drawing.Size(182, 28);
            this.tsbRemoveUnamangedLayers.Text = "Remove Unamanged Layers";
            this.tsbRemoveUnamangedLayers.Click += new System.EventHandler(this.tsbRemoveUnamangedLayers_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.clbFilters, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.unmanagedLayersDataGrid, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rtbLogs, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panelSearch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOutput, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFilter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbAll, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(953, 525);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(574, 21);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output";
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(384, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(127, 13);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Filter by component types";
            // 
            // clbFilters
            // 
            this.clbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFilters.FormattingEnabled = true;
            this.clbFilters.Items.AddRange(new object[] {
            "Entity",
            "Attribute",
            "Relationship",
            "AttributePicklistValue",
            "AttributeLookupValue",
            "ViewAttribute",
            "LocalizedLabel",
            "RelationshipExtraCondition",
            "OptionSet",
            "EntityRelationship",
            "EntityRelationshipRole",
            "EntityRelationshipRelationships",
            "ManagedProperty",
            "EntityKey",
            "Privilege",
            "PrivilegeObjectTypeCode",
            "Role",
            "RolePrivilege",
            "DisplayString",
            "DisplayStringMap",
            "Form",
            "Organization",
            "SavedQuery",
            "Workflow",
            "Report",
            "ReportEntity",
            "ReportCategory",
            "ReportVisibility",
            "Attachment",
            "EmailTemplate",
            "ContractTemplate",
            "KBArticleTemplate",
            "MailMergeTemplate",
            "DuplicateRule",
            "DuplicateRuleCondition",
            "EntityMap",
            "AttributeMap",
            "RibbonCommand",
            "RibbonContextGroup",
            "RibbonCustomization",
            "RibbonRule",
            "RibbonTabToCommandMap",
            "RibbonDiff",
            "SavedQueryVisualization",
            "SystemForm",
            "WebResource",
            "SiteMap",
            "ConnectionRole",
            "ComplexControl",
            "FieldSecurityProfile",
            "FieldPermission",
            "PluginType",
            "PluginAssembly",
            "SdkMessageProcessingStep",
            "SDKMessageProcessingStepImage",
            "ServiceEndpoint",
            "RoutingRule",
            "RoutingRuleItem",
            "SLA",
            "SLAItem",
            "ConvertRule",
            "ConvertRuleItem",
            "HierarchyRule",
            "MobileOfflineProfile",
            "MobileOfflineProfileItem",
            "SimilarityRule",
            "CustomControl",
            "CustomControlDefaultConfig",
            "DataSourceMapping",
            "SDKMessage",
            "SDKMessageFilter",
            "SdkMessagePair",
            "SdkMessageRequest",
            "SdkMessageRequestField",
            "SdkMessageResponse",
            "SdkMessageResponseField",
            "WebWizard",
            "Index",
            "ImportMap",
            "CanvasApp",
            "Connector",
            "EnvironmentVariableDefinition",
            "EnvironmentVariableValue",
            "AIProjectType",
            "AIProject",
            "AIConfiguration",
            "EntityAnalyticsConfiguration",
            "AttributeImageConfiguration",
            "EntityImageConfiguration"});
            this.clbFilters.Location = new System.Drawing.Point(384, 46);
            this.clbFilters.Name = "clbFilters";
            this.clbFilters.Size = new System.Drawing.Size(184, 514);
            this.clbFilters.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select solution";
            // 
            // unmanagedLayersDataGrid
            // 
            this.unmanagedLayersDataGrid.AccessibleName = "";
            this.unmanagedLayersDataGrid.AllowUserToAddRows = false;
            this.unmanagedLayersDataGrid.AllowUserToDeleteRows = false;
            this.unmanagedLayersDataGrid.AllowUserToResizeRows = false;
            this.unmanagedLayersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unmanagedLayersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unmanagedLayersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unmanagedLayersDataGrid.Location = new System.Drawing.Point(3, 46);
            this.unmanagedLayersDataGrid.MultiSelect = false;
            this.unmanagedLayersDataGrid.Name = "unmanagedLayersDataGrid";
            this.unmanagedLayersDataGrid.ReadOnly = true;
            this.unmanagedLayersDataGrid.RowHeadersVisible = false;
            this.unmanagedLayersDataGrid.RowHeadersWidth = 82;
            this.unmanagedLayersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unmanagedLayersDataGrid.ShowEditingIcon = false;
            this.unmanagedLayersDataGrid.Size = new System.Drawing.Size(375, 514);
            this.unmanagedLayersDataGrid.TabIndex = 1;
            // 
            // rtbLogs
            // 
            this.rtbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogs.Location = new System.Drawing.Point(574, 46);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(376, 514);
            this.rtbLogs.TabIndex = 2;
            this.rtbLogs.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(375, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(3, 16);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(375, 24);
            this.panelSearch.TabIndex = 13;
            // 
            // cbAll
            // 
            this.cbAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(384, 19);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(45, 17);
            this.cbAll.TabIndex = 14;
            this.cbAll.Text = "ALL";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(960, 562);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unmanagedLayersDataGrid)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbGetSolutions;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView unmanagedLayersDataGrid;
        private System.Windows.Forms.ToolStripButton tsbRemoveUnamangedLayers;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.CheckedListBox clbFilters;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.CheckBox cbAll;
    }
}
