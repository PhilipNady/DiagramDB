namespace DiagramDB
{
    partial class ctlSchemaDiagram
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExportToClipboard = new System.Windows.Forms.Button();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            this.panAndZoomDockPanel1 = new DevExpress.XtraDiagram.Docking.PanAndZoomDockPanel();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            this.popupMenuTable = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemAddTable = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUpdateTable = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteTable = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuColumn = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExportToFile = new System.Windows.Forms.Button();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExportToFile);
            this.layoutControl1.Controls.Add(this.btnExportToClipboard);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(790, 198, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(873, 490);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExportToClipboard
            // 
            this.btnExportToClipboard.Location = new System.Drawing.Point(12, 434);
            this.btnExportToClipboard.Name = "btnExportToClipboard";
            this.btnExportToClipboard.Size = new System.Drawing.Size(849, 20);
            this.btnExportToClipboard.TabIndex = 4;
            this.btnExportToClipboard.Text = "Export to Clipboard";
            this.btnExportToClipboard.UseVisualStyleBackColor = true;
            this.btnExportToClipboard.Click += new System.EventHandler(this.btnExportToClipboard_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(873, 490);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.diagramControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(853, 422);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // diagramControl
            // 
            this.diagramControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramControl.Location = new System.Drawing.Point(117, 12);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.OptionsBehavior.ConnectorsSeparationMode = DevExpress.Diagram.Core.DiagramConnectorsSeparationMode.AllLines;
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsProtection.AllowCollapseContainers = true;
            this.diagramControl.OptionsProtection.AllowMoveItems = true;
            this.diagramControl.OptionsProtection.AllowResizeItems = true;
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl.OptionsView.ShowGrid = false;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ShowPanAndZoomPanel = true;
            this.diagramControl.OptionsView.ShowRulers = false;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.PanAndZoom = this.panAndZoomDockPanel1;
            this.diagramControl.Size = new System.Drawing.Size(744, 418);
            this.diagramControl.TabIndex = 4;
            this.diagramControl.Text = "diagramControl1";
            this.diagramControl.CustomDrawItem += new System.EventHandler<DevExpress.XtraDiagram.CustomDrawItemEventArgs>(this.diagramControl_CustomDrawItem);
            this.diagramControl.DoubleClick += new System.EventHandler(this.diagramControl_DoubleClick);
            this.diagramControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.diagramControl_MouseUp);
            // 
            // panAndZoomDockPanel1
            // 
            this.panAndZoomDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.panAndZoomDockPanel1.FloatLocation = new System.Drawing.Point(588, 342);
            this.panAndZoomDockPanel1.FloatSize = new System.Drawing.Size(300, 200);
            this.panAndZoomDockPanel1.FloatVertical = true;
            this.panAndZoomDockPanel1.ID = new System.Guid("6d7371ea-d905-4d3d-9c11-4db88fc25dfd");
            this.panAndZoomDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.panAndZoomDockPanel1.Name = "panAndZoomDockPanel1";
            this.panAndZoomDockPanel1.Options.AllowDockBottom = true;
            this.panAndZoomDockPanel1.Options.ShowAutoHideButton = false;
            this.panAndZoomDockPanel1.Options.ShowMaximizeButton = false;
            this.panAndZoomDockPanel1.OriginalSize = new System.Drawing.Size(300, 30);
            this.panAndZoomDockPanel1.Size = new System.Drawing.Size(300, 200);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnExportToClipboard;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 422);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(853, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panAndZoomDockPanel1});
            this.dockManager1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // diagramDataBindingController1
            // 
            this.diagramDataBindingController1.ConnectorsSource = null;
            this.diagramDataBindingController1.Diagram = this.diagramControl;
            // 
            // 
            // 
            this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramDataBindingController1.TemplateDiagram.Name = "";
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner",
            "BasicShapes"});
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
            this.diagramDataBindingController1.GenerateItem += new System.EventHandler<DevExpress.XtraDiagram.DiagramGenerateItemEventArgs>(this.diagramDataBindingController1_GenerateItem);
            this.diagramDataBindingController1.GenerateConnector += new System.EventHandler<DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs>(this.diagramDataBindingController1_GenerateConnector);
            this.diagramDataBindingController1.ItemsGenerated += new System.EventHandler<DevExpress.XtraDiagram.DiagramItemsGeneratedEventArgs>(this.diagramDataBindingController1_ItemsGenerated);
            // 
            // popupMenuTable
            // 
            this.popupMenuTable.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.popupMenuTable.Manager = this.barManager1;
            this.popupMenuTable.Name = "popupMenuTable";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add table";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTable_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Update table";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTable_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Delete table";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTable_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItemAddTable,
            this.barButtonItemUpdateTable,
            this.barButtonItemDeleteTable,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(873, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 490);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(873, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(873, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Add";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItemAddTable
            // 
            this.barButtonItemAddTable.Caption = "Add column";
            this.barButtonItemAddTable.Id = 1;
            this.barButtonItemAddTable.Name = "barButtonItemAddTable";
            this.barButtonItemAddTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemColumn_ItemClick);
            // 
            // barButtonItemUpdateTable
            // 
            this.barButtonItemUpdateTable.Caption = "Update column";
            this.barButtonItemUpdateTable.Id = 2;
            this.barButtonItemUpdateTable.Name = "barButtonItemUpdateTable";
            this.barButtonItemUpdateTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemColumn_ItemClick);
            // 
            // barButtonItemDeleteTable
            // 
            this.barButtonItemDeleteTable.Caption = "Delete column";
            this.barButtonItemDeleteTable.Id = 3;
            this.barButtonItemDeleteTable.Name = "barButtonItemDeleteTable";
            this.barButtonItemDeleteTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemColumn_ItemClick);
            // 
            // popupMenuColumn
            // 
            this.popupMenuColumn.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAddTable),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUpdateTable),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDeleteTable)});
            this.popupMenuColumn.Manager = this.barManager1;
            this.popupMenuColumn.Name = "popupMenuColumn";
            // 
            // btnExportToFile
            // 
            this.btnExportToFile.Location = new System.Drawing.Point(12, 458);
            this.btnExportToFile.Name = "btnExportToFile";
            this.btnExportToFile.Size = new System.Drawing.Size(849, 20);
            this.btnExportToFile.TabIndex = 5;
            this.btnExportToFile.Text = "Export to File";
            this.btnExportToFile.UseVisualStyleBackColor = true;
            this.btnExportToFile.Click += new System.EventHandler(this.btnExportToFile_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnExportToFile;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 446);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(853, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ctlSchemaDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.diagramControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctlSchemaDiagram";
            this.Size = new System.Drawing.Size(873, 490);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraDiagram.DiagramControl diagramControl;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
        private DevExpress.XtraDiagram.Docking.PanAndZoomDockPanel panAndZoomDockPanel1;
       
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddTable;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdateTable;
        private DevExpress.XtraBars.PopupMenu popupMenuTable;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteTable;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.PopupMenu popupMenuColumn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.Button btnExportToClipboard;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Button btnExportToFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
