
using DiagramDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramMainDemo
{
    public partial class FormTableRename : Form
    {
        public FormTableRename()
        {
            InitializeComponent();
            
        }

        private void FormTableRename_Shown(object sender, EventArgs e)
        {
            txtTableName.Text = ctlSchemaDiagram.sNewTableName;
            lblOperation.Text = ctlSchemaDiagram.sNewTableOperation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
