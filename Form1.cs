using DevExpress.Diagram.Core;
using DevExpress.Diagram.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraDiagram;
using DiagramMainDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramDB
{
    public partial class Form1 : Form
    {
        DatabaseDefinition Database { get; set; }
        TableRelationEvaluationOperator evaluationOperator;
        readonly SvgBitmap PropertyImage;
        readonly SvgBitmap IdImage;
        public Form1()
        {
            InitializeComponent();
            IdImage = LoadSvgImage("Images/DatabaseDiagram/id.svg");
            PropertyImage = LoadSvgImage("Images/DatabaseDiagram/property.svg");
            FillData();
        }
        private void FillData()
        {
            Database = DatabaseData.GetDatabaseDefinition();
          
            diagramDataBindingController1.ConnectorToMember = "To";
            diagramDataBindingController1.ConnectorFromMember = "From";
            diagramDataBindingController1.KeySelector = new DatabaseDefinitionKeySelector();
            diagramDataBindingController1.ItemsPath = "Columns";
            diagramDataBindingController1.DataSource = Database.Tables;
            diagramDataBindingController1.ConnectorsSource = Database.Connections;
        }
        //public DatabaseDiagram()
        //{
        //    evaluationOperator = new TableRelationEvaluationOperator();
        //    CriteriaOperator.RegisterCustomFunction(evaluationOperator);
        //    Database = DatabaseData.GetDatabaseDefinition();
        //    IdImage = LoadSvgImage("Images/DatabaseDiagram/id.svg");
        //    PropertyImage = LoadSvgImage("Images/DatabaseDiagram/property.svg");
        //    InitializeComponent();
        //    diagramControl.OptionsView.FitToDrawingMargin = new System.Windows.Forms.Padding(50);
        //    diagramControl.CustomDrawItem += this.diagramControl_CustomDrawItem;

        //    InitializeDataBindingController();
        //}

        private void diagramControl_DoubleClick(object sender, EventArgs e)
        {
            var item = diagramControl.CalcHitItem(((System.Windows.Forms.MouseEventArgs)e).Location) as DiagramList;
            if (item != null)
            {
                PointFloat controlPoint = diagramControl.PointToControl(item.Position);
                //DiagramMainDemo.FormTableRename formTableRename = new DiagramMainDemo.FormTableRename();
                // sNewTableName = item.Header;
                // formTableRename.Show();

            }
        }

        void diagramControl_CustomDrawItem(object sender, CustomDrawItemEventArgs e)
        {
            var column = e.Item.DataContext as ColumnDefinition;
            if (column == null || e.Item.Tag == null)
                return;
            var image = column.IsPrimaryKey ? IdImage : PropertyImage;
            var state = e.GraphicsCache.Paint.SaveCacheState(e.GraphicsCache);
            try
            {
                e.GraphicsCache.SmoothingMode = SmoothingMode.AntiAlias;
                var imageSize = image.GetBounds().Size;
                e.GraphicsCache.ScaleTransform((float)e.Item.Width / imageSize.Width, (float)e.Item.Height / imageSize.Height);
                using (var svgCache = new GraphicsCacheSvgWrapper(e.GraphicsCache))
                {
                    image.RenderToSvgGraphics(svgCache);
                }
            }
            finally
            {
                e.GraphicsCache.Paint.RestoreCacheState(e.GraphicsCache, state);
            }
        }

        void diagramDataBindingController1_GenerateItem(object sender, DiagramGenerateItemEventArgs e)
        {
            if (e.DataObject is TableDefinition)
                e.Item = CreateTableItem();
            else
                e.Item = CreateColumnItem();
        }
        void diagramDataBindingController1_GenerateConnector(object sender, DiagramGenerateConnectorEventArgs e)
        {
            e.Connector = CreateConnectionItem();
        }
        void diagramDataBindingController1_ItemsGenerated(object sender, DiagramItemsGeneratedEventArgs e)
        {
            diagramControl.FitToDrawing();
            diagramControl.OptionsView.ZoomFactor = 1.0f;
            diagramControl.OptionsProtection.IsReadOnly = true;
            //diagramControl.OptionsBehavior.SelectionMode = SelectionMode.None;
            diagramControl.OptionsBehavior.SelectionMode = DevExpress.Diagram.Core.SelectionMode.Single;
        }
        static DiagramList CreateTableItem()
        {
            var stack = new DiagramList
            {
                ShowHeader = true,
                Width = 200,
                DragMode = ContainerDragMode.ByAnyPoint,
                Shape = StandardContainers.Classic,

                // AffectedByLayoutAlgorithms = false,
                //Philip
                AffectedByLayoutAlgorithms = false,
                CanCollapse = true,
            };

            stack.Bindings.Add(new DiagramBinding("Header", "Name"));
            stack.Bindings.Add(new DiagramBinding("X", "PositionX"));
            stack.Bindings.Add(new DiagramBinding("Y", "PositionY"));

            stack.Appearance.BorderSize = 2;
            stack.Appearance.Font = new Font(stack.Appearance.Font.FontFamily, 16);
            return stack;
        }
        static DiagramItem CreateColumnItem()
        {
            var imageItem = new DiagramShape { X = 4, Y = 2, Width = 21, Height = 21, Tag = true, CanSnapToThisItem = false };
            imageItem.Appearance.BorderSize = 0;
            imageItem.Appearance.BackColor = Color.Transparent;

            var contentItem = new DiagramShape
            {
                X = 27,
                Width = 173,
                Height = 25,
                CanSnapToThisItem = false,
            };
            contentItem.Appearance.BorderSize = 0;
            contentItem.Appearance.BackColor = Color.Transparent;
            contentItem.Appearance.ForeColor = Color.Black;
            contentItem.Appearance.Font = new Font(contentItem.Appearance.Font.FontFamily, 14);
            contentItem.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            contentItem.Bindings.Add(new DiagramBinding("Content", "Name"));

            var connectionPoints = new List<PointFloat> {
                new PointFloat(0, 0.5f),
                new PointFloat(1, 0.5f)
            };
            var columnItem = new DiagramContainer
            {
                Height = 30,
                ConnectionPoints = new PointCollection(connectionPoints),
                CanSnapToThisItem = false,
            };
            columnItem.Items.Add(imageItem);
            columnItem.Items.Add(contentItem);
            columnItem.Appearance.BorderSize = 0;
            return columnItem;
        }
        static DiagramConnector CreateConnectionItem()
        {
            var connector = new DiagramConnector
            {
                CanEdit = false,
                CanDragBeginPoint = false,
                CanChangeRoute = false,
                CanDragEndPoint = false,
                Type = ConnectorType.RightAngle,
                BeginLabelArrowOffset = 4,
            };

            connector.Bindings.Add(new DiagramBinding("BeginLeftLabel", "TableRelation([FromRelation])"));
            connector.Bindings.Add(new DiagramBinding("EndLeftLabel", "TableRelation([ToRelation])"));
            connector.Appearance.BorderSize = 2;
            connector.Appearance.Font = new Font(connector.Appearance.Font.FontFamily, 13);
            return connector;
        }
        SvgBitmap LoadSvgImage(string svgPath)
        {
            return new SvgBitmap(DiagramDemoFileHelper.GetSvgImageResource(svgPath));
        }
        public static string sNewTableName = "";

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open sdf File";
            openFileDialog1.Filter = "SDF files|*.sdf";
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = null;
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var fileStream = File.Create(DBAccess. GetDataFileName("Data\\Diagram\\" + "Project.sdf")); //File.Create("C:\\Path\\To\\File");
                            myStream.CopyTo(fileStream);//.InputStream.Seek(0, SeekOrigin.Begin);
                            //myStream.InputStream.CopyTo(fileStream);
                            fileStream.Close();
                            
                        }
                        Database = DatabaseData.GetDatabaseDefinition();
                        FillData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
