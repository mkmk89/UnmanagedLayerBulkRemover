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
            this.bannerBox = new System.Windows.Forms.PictureBox();
            this.closeBanner = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unmanagedLayersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).BeginInit();
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
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1440, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbGetSolutions
            // 
            this.tsbGetSolutions.Image = ((System.Drawing.Image)(resources.GetObject("tsbGetSolutions.Image")));
            this.tsbGetSolutions.Name = "tsbGetSolutions";
            this.tsbGetSolutions.Size = new System.Drawing.Size(158, 29);
            this.tsbGetSolutions.Text = "Load Solutions";
            this.tsbGetSolutions.Click += new System.EventHandler(this.tsbGetSolutions_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbRemoveUnamangedLayers
            // 
            this.tsbRemoveUnamangedLayers.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveUnamangedLayers.Image")));
            this.tsbRemoveUnamangedLayers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveUnamangedLayers.Name = "tsbRemoveUnamangedLayers";
            this.tsbRemoveUnamangedLayers.Size = new System.Drawing.Size(260, 33);
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
            this.tableLayoutPanel2.Controls.Add(this.lblOutput, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFilter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clbFilters, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.unmanagedLayersDataGrid, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rtbLogs, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 52);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1430, 808);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(862, 0);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 20);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Output";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(576, 0);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(190, 20);
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
            this.clbFilters.Location = new System.Drawing.Point(576, 25);
            this.clbFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbFilters.Name = "clbFilters";
            this.clbFilters.Size = new System.Drawing.Size(278, 786);
            this.clbFilters.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
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
            this.unmanagedLayersDataGrid.Location = new System.Drawing.Point(4, 25);
            this.unmanagedLayersDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unmanagedLayersDataGrid.MultiSelect = false;
            this.unmanagedLayersDataGrid.Name = "unmanagedLayersDataGrid";
            this.unmanagedLayersDataGrid.ReadOnly = true;
            this.unmanagedLayersDataGrid.RowHeadersVisible = false;
            this.unmanagedLayersDataGrid.RowHeadersWidth = 82;
            this.unmanagedLayersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unmanagedLayersDataGrid.ShowEditingIcon = false;
            this.unmanagedLayersDataGrid.Size = new System.Drawing.Size(564, 791);
            this.unmanagedLayersDataGrid.TabIndex = 1;
            // 
            // rtbLogs
            // 
            this.rtbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogs.Location = new System.Drawing.Point(862, 25);
            this.rtbLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(564, 791);
            this.rtbLogs.TabIndex = 2;
            this.rtbLogs.Text = "";
            // 
            // bannerBox
            // 
            this.bannerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bannerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bannerBox.Location = new System.Drawing.Point(804, 17);
            this.bannerBox.Name = "bannerBox";
            this.bannerBox.Size = new System.Drawing.Size(600, 250);
            this.bannerBox.TabIndex = 8;
            this.bannerBox.TabStop = false;
            this.bannerBox.Visible = false;
            // 
            // closeBanner
            // 
            this.closeBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBanner.Location = new System.Drawing.Point(1410, 17);
            this.closeBanner.Name = "closeBanner";
            this.closeBanner.Size = new System.Drawing.Size(20, 20);
            this.closeBanner.TabIndex = 9;
            this.closeBanner.Text = "X";
            this.closeBanner.Visible = false;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeBanner);
            this.Controls.Add(this.bannerBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1440, 865);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unmanagedLayersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).EndInit();
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
        private System.Windows.Forms.PictureBox bannerBox;
        private System.Windows.Forms.Label closeBanner;
    }
}
