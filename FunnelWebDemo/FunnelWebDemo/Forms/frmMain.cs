using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;
using System.Net;

namespace FunnelWebDemo
{
    public partial class frmMain2 : Form
    {
        public frmMain2()
        {
            InitializeComponent();
            treSelection.KeyFieldName = "catID";
            treSelection.ParentFieldName = "catIDParent";
        }

        private void frmMain2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funnelWeb_DemoDataSet3.vwCategoriesSecond' table. You can move, or remove it, as needed.
            this.vwCategoriesSecondTableAdapter.Fill(this.funnelWeb_DemoDataSet3.vwCategoriesSecond);
            treSelection.Columns.ColumnByName("colcrlID").Visible = false;
            treSelection.Columns.ColumnByName("colurlURL").Visible = false;
            treSelection.ExpandAll();
        }

        private void treSelection_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            string thisURL = Convert.ToString(treSelection.FocusedNode.GetValue(2));
            if (thisURL.StartsWith("http"))
            {
                var response = new WebClient().DownloadString(thisURL);
                webBrowser.Navigate(thisURL);
            }
        }
        }
}
