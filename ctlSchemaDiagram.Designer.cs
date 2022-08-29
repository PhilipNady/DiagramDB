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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            this.panAndZoomDockPanel1 = new DevExpress.XtraDiagram.Docking.PanAndZoomDockPanel();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(873, 490);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.diagramControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(853, 470);
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
            this.diagramControl.Size = new System.Drawing.Size(744, 466);
            this.diagramControl.TabIndex = 4;
            this.diagramControl.Text = "diagramControl1";
            this.diagramControl.CustomDrawItem += new System.EventHandler<DevExpress.XtraDiagram.CustomDrawItemEventArgs>(this.diagramControl_CustomDrawItem);
            this.diagramControl.DoubleClick += new System.EventHandler(this.diagramControl_DoubleClick);
            // 
            // panAndZoomDockPanel1
            // 
            this.panAndZoomDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.panAndZoomDockPanel1.FloatLocation = new System.Drawing.Point(588, 366);
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
            // ctlSchemaDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.diagramControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ctlSchemaDiagram";
            this.Size = new System.Drawing.Size(873, 490);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraDiagram.DiagramControl diagramControl;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
        private DevExpress.XtraDiagram.Docking.PanAndZoomDockPanel panAndZoomDockPanel1;
       
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
