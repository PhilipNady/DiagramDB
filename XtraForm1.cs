using DevExpress.XtraEditors;
using DiagramMainDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramDB
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
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
                            var fileStream = File.Create(DBAccess.GetRelativeFilePath("Data\\Diagram\\" + "Project.sdf")); 
                            myStream.CopyTo(fileStream);
                            
                            fileStream.Close();

                        }
                        ctlSchemaDiagram1.FillData();
                        
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