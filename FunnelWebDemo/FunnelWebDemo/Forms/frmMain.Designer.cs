namespace FunnelWebDemo
{
    partial class frmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain2));
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.treSelection = new DevExpress.XtraTreeList.TreeList();
            this.colcrlID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcatIDParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcatID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcatDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colurlURL = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vwCategoriesSecondBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funnelWeb_DemoDataSet3 = new FunnelWebDemo.FunnelWeb_DemoDataSet3();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.vwCategoriesSecondTableAdapter = new FunnelWebDemo.FunnelWeb_DemoDataSet3TableAdapters.vwCategoriesSecondTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesSecondBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funnelWeb_DemoDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControlMain
            // 
            this.splitContainerControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlMain.Name = "splitContainerControlMain";
            this.splitContainerControlMain.Panel1.Controls.Add(this.treSelection);
            this.splitContainerControlMain.Panel1.Text = "Panel1";
            this.splitContainerControlMain.Panel2.Controls.Add(this.webBrowser);
            this.splitContainerControlMain.Panel2.Text = "Panel2";
            this.splitContainerControlMain.Size = new System.Drawing.Size(1681, 1072);
            this.splitContainerControlMain.SplitterPosition = 493;
            this.splitContainerControlMain.TabIndex = 0;
            // 
            // treSelection
            // 
            this.treSelection.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colcrlID,
            this.colcatIDParent,
            this.colcatID,
            this.colcatDescription,
            this.colurlURL});
            this.treSelection.Cursor = System.Windows.Forms.Cursors.Default;
            this.treSelection.DataSource = this.vwCategoriesSecondBindingSource;
            this.treSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treSelection.Location = new System.Drawing.Point(0, 0);
            this.treSelection.Name = "treSelection";
            this.treSelection.Size = new System.Drawing.Size(493, 1072);
            this.treSelection.TabIndex = 0;
            this.treSelection.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treSelection_FocusedNodeChanged);
            // 
            // colcrlID
            // 
            this.colcrlID.FieldName = "crlID";
            this.colcrlID.Name = "colcrlID";
            this.colcrlID.Visible = true;
            this.colcrlID.VisibleIndex = 0;
            // 
            // colcatIDParent
            // 
            this.colcatIDParent.FieldName = "catIDParent";
            this.colcatIDParent.Name = "colcatIDParent";
            this.colcatIDParent.Visible = true;
            this.colcatIDParent.VisibleIndex = 1;
            // 
            // colcatID
            // 
            this.colcatID.FieldName = "catID";
            this.colcatID.Name = "colcatID";
            this.colcatID.Visible = true;
            this.colcatID.VisibleIndex = 2;
            // 
            // colcatDescription
            // 
            this.colcatDescription.FieldName = "catDescription";
            this.colcatDescription.Name = "colcatDescription";
            this.colcatDescription.Visible = true;
            this.colcatDescription.VisibleIndex = 3;
            // 
            // colurlURL
            // 
            this.colurlURL.FieldName = "urlURL";
            this.colurlURL.Name = "colurlURL";
            this.colurlURL.Visible = true;
            this.colurlURL.VisibleIndex = 4;
            // 
            // vwCategoriesSecondBindingSource
            // 
            this.vwCategoriesSecondBindingSource.DataMember = "vwCategoriesSecond";
            this.vwCategoriesSecondBindingSource.DataSource = this.funnelWeb_DemoDataSet3;
            // 
            // funnelWeb_DemoDataSet3
            // 
            this.funnelWeb_DemoDataSet3.DataSetName = "FunnelWeb_DemoDataSet3";
            this.funnelWeb_DemoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1178, 1072);
            this.webBrowser.TabIndex = 0;
            // 
            // vwCategoriesSecondTableAdapter
            // 
            this.vwCategoriesSecondTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 1072);
            this.Controls.Add(this.splitContainerControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain2";
            this.Text = "FunnelWeb Demo 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesSecondBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funnelWeb_DemoDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlMain;
        private DevExpress.XtraTreeList.TreeList treSelection;
        private FunnelWeb_DemoDataSet3 funnelWeb_DemoDataSet3;
        private System.Windows.Forms.BindingSource vwCategoriesSecondBindingSource;
        private FunnelWeb_DemoDataSet3TableAdapters.vwCategoriesSecondTableAdapter vwCategoriesSecondTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcrlID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcatIDParent;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcatID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcatDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colurlURL;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}