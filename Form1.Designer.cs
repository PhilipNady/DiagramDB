namespace DiagramDB
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            this.panAndZoomDockPanel1 = new DevExpress.XtraDiagram.Docking.PanAndZoomDockPanel();
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl
            // 
            this.diagramControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramControl.Location = new System.Drawing.Point(0, 0);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.OptionsBehavior.ConnectorsSeparationMode = DevExpress.Diagram.Core.DiagramConnectorsSeparationMode.AllLines;
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsProtection.AllowCollapseContainers = true;
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl.OptionsView.ShowGrid = false;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ShowPanAndZoomPanel = true;
            this.diagramControl.OptionsView.ShowRulers = false;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.PanAndZoom = this.panAndZoomDockPanel1;
            this.diagramControl.Size = new System.Drawing.Size(1201, 518);
            this.diagramControl.TabIndex = 0;
            this.diagramControl.Text = "diagramControl1";
            this.diagramControl.CustomDrawItem += new System.EventHandler<DevExpress.XtraDiagram.CustomDrawItemEventArgs>(this.diagramControl_CustomDrawItem);
            this.diagramControl.DoubleClick += new System.EventHandler(this.diagramControl_DoubleClick);
            // 
            // panAndZoomDockPanel1
            // 
            this.panAndZoomDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.panAndZoomDockPanel1.FloatLocation = new System.Drawing.Point(736, 466);
            this.panAndZoomDockPanel1.FloatSize = new System.Drawing.Size(300, 200);
            this.panAndZoomDockPanel1.FloatVertical = true;
            this.panAndZoomDockPanel1.ID = new System.Guid("8959ee7c-e6f7-4e0b-9bc6-06eee28c1926");
            this.panAndZoomDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.panAndZoomDockPanel1.Name = "panAndZoomDockPanel1";
            this.panAndZoomDockPanel1.Options.AllowDockBottom = true;
            this.panAndZoomDockPanel1.Options.ShowAutoHideButton = false;
            this.panAndZoomDockPanel1.Options.ShowMaximizeButton = false;
            this.panAndZoomDockPanel1.OriginalSize = new System.Drawing.Size(300, 30);
            this.panAndZoomDockPanel1.Size = new System.Drawing.Size(300, 200);
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
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(550F, 150F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(640F, 240F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(640F, 150F)});
            this.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Curved;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(294, 524);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 559);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.diagramControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl;
        private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
        private DevExpress.XtraDiagram.Docking.PanAndZoomDockPanel panAndZoomDockPanel1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

