namespace EPocalipse.Json.Viewer
{
    partial class JsonViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonViewer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spcViewer = new System.Windows.Forms.SplitContainer();
            this.tvJson = new System.Windows.Forms.TreeView();
            this.mnuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyValue = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCloseFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.pnlVisualizer = new System.Windows.Forms.Panel();
            this.mnuVisualizerPnl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowOnRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowOnBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.cbVisualizers = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageTreeView = new System.Windows.Forms.TabPage();
            this.pageTextView = new System.Windows.Forms.TabPage();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFormat = new System.Windows.Forms.ToolStripButton();
            this.btnStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.btnStripToCurly = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStripToSqr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.removenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSpecialCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewSelected = new System.Windows.Forms.ToolStripButton();
            this.lblError = new System.Windows.Forms.LinkLabel();
            this.Url_decode = new System.Windows.Forms.TabPage();
            this.lbl_Row = new System.Windows.Forms.Label();
            this.querylist = new System.Windows.Forms.DataGridView();
            this.btn_DeepDecode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.txt_ToSortUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.txt_RawUrl = new System.Windows.Forms.TextBox();
            this.Url_View = new System.Windows.Forms.TabPage();
            this.ddl_item = new System.Windows.Forms.ComboBox();
            this.txt_GetHTML = new System.Windows.Forms.TextBox();
            this.GetWebString = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.httpViewer = new System.Windows.Forms.TabPage();
            this.dgv_ResponseList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HttpGetUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.browser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.spcViewer)).BeginInit();
            this.spcViewer.Panel1.SuspendLayout();
            this.spcViewer.Panel2.SuspendLayout();
            this.spcViewer.SuspendLayout();
            this.mnuTree.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.mnuVisualizerPnl.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageTreeView.SuspendLayout();
            this.pageTextView.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Url_decode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.querylist)).BeginInit();
            this.Url_View.SuspendLayout();
            this.httpViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResponseList)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcViewer
            // 
            this.spcViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcViewer.Location = new System.Drawing.Point(3, 3);
            this.spcViewer.Name = "spcViewer";
            // 
            // spcViewer.Panel1
            // 
            this.spcViewer.Panel1.Controls.Add(this.tvJson);
            this.spcViewer.Panel1.Controls.Add(this.pnlFind);
            // 
            // spcViewer.Panel2
            // 
            this.spcViewer.Panel2.Controls.Add(this.pnlVisualizer);
            this.spcViewer.Panel2.Controls.Add(this.cbVisualizers);
            this.spcViewer.Size = new System.Drawing.Size(778, 526);
            this.spcViewer.SplitterDistance = 552;
            this.spcViewer.TabIndex = 5;
            // 
            // tvJson
            // 
            this.tvJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvJson.ContextMenuStrip = this.mnuTree;
            this.tvJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvJson.FullRowSelect = true;
            this.tvJson.HideSelection = false;
            this.tvJson.ImageIndex = 0;
            this.tvJson.ImageList = this.imgList;
            this.tvJson.Location = new System.Drawing.Point(0, 0);
            this.tvJson.Name = "tvJson";
            this.tvJson.SelectedImageIndex = 0;
            this.tvJson.Size = new System.Drawing.Size(552, 496);
            this.tvJson.TabIndex = 3;
            this.tvJson.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvJson_BeforeExpand);
            this.tvJson.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvJson_AfterSelect);
            this.tvJson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JsonViewer_KeyDown);
            this.tvJson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvJson_MouseDown);
            // 
            // mnuTree
            // 
            this.mnuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuExpandAll,
            this.toolStripMenuItem1,
            this.mnuCopy,
            this.mnuCopyName,
            this.mnuCopyValue});
            this.mnuTree.Name = "mnuTree";
            this.mnuTree.Size = new System.Drawing.Size(146, 120);
            this.mnuTree.Opening += new System.ComponentModel.CancelEventHandler(this.mnuTree_Opening);
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(145, 22);
            this.mnuFind.Text = "&Find";
            this.mnuFind.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // mnuExpandAll
            // 
            this.mnuExpandAll.Name = "mnuExpandAll";
            this.mnuExpandAll.Size = new System.Drawing.Size(145, 22);
            this.mnuExpandAll.Text = "Expand &All";
            this.mnuExpandAll.Click += new System.EventHandler(this.expandallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(145, 22);
            this.mnuCopy.Text = "&Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuCopyName
            // 
            this.mnuCopyName.Name = "mnuCopyName";
            this.mnuCopyName.Size = new System.Drawing.Size(145, 22);
            this.mnuCopyName.Text = "Copy Name";
            this.mnuCopyName.Click += new System.EventHandler(this.mnuCopyName_Click);
            // 
            // mnuCopyValue
            // 
            this.mnuCopyValue.Name = "mnuCopyValue";
            this.mnuCopyValue.Size = new System.Drawing.Size(145, 22);
            this.mnuCopyValue.Text = "Copy &Value";
            this.mnuCopyValue.Click += new System.EventHandler(this.mnuCopyValue_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.White;
            this.imgList.Images.SetKeyName(0, "obj.bmp");
            this.imgList.Images.SetKeyName(1, "array.bmp");
            this.imgList.Images.SetKeyName(2, "prop.bmp");
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.btnCloseFind);
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Controls.Add(this.lblFind);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFind.Location = new System.Drawing.Point(0, 496);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(552, 30);
            this.pnlFind.TabIndex = 6;
            // 
            // btnCloseFind
            // 
            this.btnCloseFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFind.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseFind.BackgroundImage")));
            this.btnCloseFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseFind.FlatAppearance.BorderSize = 0;
            this.btnCloseFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFind.Location = new System.Drawing.Point(525, 6);
            this.btnCloseFind.Name = "btnCloseFind";
            this.btnCloseFind.Size = new System.Drawing.Size(16, 15);
            this.btnCloseFind.TabIndex = 2;
            this.btnCloseFind.UseVisualStyleBackColor = false;
            this.btnCloseFind.Click += new System.EventHandler(this.btnCloseFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(32, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(479, 21);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(3, 8);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(29, 12);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "&Find";
            // 
            // pnlVisualizer
            // 
            this.pnlVisualizer.ContextMenuStrip = this.mnuVisualizerPnl;
            this.pnlVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVisualizer.Location = new System.Drawing.Point(0, 20);
            this.pnlVisualizer.Name = "pnlVisualizer";
            this.pnlVisualizer.Size = new System.Drawing.Size(222, 506);
            this.pnlVisualizer.TabIndex = 6;
            // 
            // mnuVisualizerPnl
            // 
            this.mnuVisualizerPnl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowOnRight,
            this.mnuShowOnBottom});
            this.mnuVisualizerPnl.Name = "mnuVisualizerPnl";
            this.mnuVisualizerPnl.Size = new System.Drawing.Size(120, 48);
            // 
            // mnuShowOnRight
            // 
            this.mnuShowOnRight.Checked = true;
            this.mnuShowOnRight.CheckOnClick = true;
            this.mnuShowOnRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuShowOnRight.Name = "mnuShowOnRight";
            this.mnuShowOnRight.Size = new System.Drawing.Size(119, 22);
            this.mnuShowOnRight.Text = "&Right";
            this.mnuShowOnRight.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // mnuShowOnBottom
            // 
            this.mnuShowOnBottom.CheckOnClick = true;
            this.mnuShowOnBottom.Name = "mnuShowOnBottom";
            this.mnuShowOnBottom.Size = new System.Drawing.Size(119, 22);
            this.mnuShowOnBottom.Text = "&Bottom";
            this.mnuShowOnBottom.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // cbVisualizers
            // 
            this.cbVisualizers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVisualizers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisualizers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbVisualizers.FormattingEnabled = true;
            this.cbVisualizers.Location = new System.Drawing.Point(0, 0);
            this.cbVisualizers.Name = "cbVisualizers";
            this.cbVisualizers.Size = new System.Drawing.Size(222, 20);
            this.cbVisualizers.Sorted = true;
            this.cbVisualizers.TabIndex = 7;
            this.cbVisualizers.SelectedIndexChanged += new System.EventHandler(this.cbVisualizers_SelectedIndexChanged);
            this.cbVisualizers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbVisualizers_Format);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageTreeView);
            this.tabControl.Controls.Add(this.pageTextView);
            this.tabControl.Controls.Add(this.Url_decode);
            this.tabControl.Controls.Add(this.Url_View);
            this.tabControl.Controls.Add(this.httpViewer);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 558);
            this.tabControl.TabIndex = 6;
            // 
            // pageTreeView
            // 
            this.pageTreeView.Controls.Add(this.spcViewer);
            this.pageTreeView.Location = new System.Drawing.Point(4, 22);
            this.pageTreeView.Name = "pageTreeView";
            this.pageTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.pageTreeView.Size = new System.Drawing.Size(784, 532);
            this.pageTreeView.TabIndex = 0;
            this.pageTreeView.Text = "Viewer";
            this.pageTreeView.UseVisualStyleBackColor = true;
            // 
            // pageTextView
            // 
            this.pageTextView.Controls.Add(this.txtJson);
            this.pageTextView.Controls.Add(this.toolStrip1);
            this.pageTextView.Controls.Add(this.lblError);
            this.pageTextView.Location = new System.Drawing.Point(4, 22);
            this.pageTextView.Name = "pageTextView";
            this.pageTextView.Padding = new System.Windows.Forms.Padding(3);
            this.pageTextView.Size = new System.Drawing.Size(784, 532);
            this.pageTextView.TabIndex = 1;
            this.pageTextView.Text = "Text";
            this.pageTextView.UseVisualStyleBackColor = true;
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.HideSelection = false;
            this.txtJson.Location = new System.Drawing.Point(3, 28);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(778, 479);
            this.txtJson.TabIndex = 7;
            this.txtJson.Text = "";
            this.txtJson.SelectionChanged += new System.EventHandler(this.txtJson_SelectionChanged);
            this.txtJson.TextChanged += new System.EventHandler(this.txtJson_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPaste,
            this.btnCopy,
            this.toolStripSeparator1,
            this.btnFormat,
            this.btnStrip,
            this.toolStripSplitButton1,
            this.btnViewSelected});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(43, 22);
            this.btnPaste.Text = "&Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(42, 22);
            this.btnCopy.Text = "&Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFormat
            // 
            this.btnFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFormat.Image = ((System.Drawing.Image)(resources.GetObject("btnFormat.Image")));
            this.btnFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(53, 22);
            this.btnFormat.Text = "&Format";
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnStrip
            // 
            this.btnStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStripToCurly,
            this.btnStripToSqr});
            this.btnStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnStrip.Image")));
            this.btnStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStrip.Name = "btnStrip";
            this.btnStrip.Size = new System.Drawing.Size(79, 22);
            this.btnStrip.Text = "Strip to {}";
            this.btnStrip.ButtonClick += new System.EventHandler(this.btnStripToCurly_Click);
            // 
            // btnStripToCurly
            // 
            this.btnStripToCurly.Name = "btnStripToCurly";
            this.btnStripToCurly.Size = new System.Drawing.Size(131, 22);
            this.btnStripToCurly.Text = "Strip to {}";
            this.btnStripToCurly.Click += new System.EventHandler(this.btnStripToCurly_Click);
            // 
            // btnStripToSqr
            // 
            this.btnStripToSqr.Name = "btnStripToSqr";
            this.btnStripToSqr.Size = new System.Drawing.Size(131, 22);
            this.btnStripToSqr.Text = "Strip to []";
            this.btnStripToSqr.Click += new System.EventHandler(this.btnStripToSqr_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removenToolStripMenuItem,
            this.removeSpecialCharsToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(152, 22);
            this.toolStripSplitButton1.Text = "Remove new lines (\\n)";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.removeNewLineMenuItem_Click);
            // 
            // removenToolStripMenuItem
            // 
            this.removenToolStripMenuItem.Name = "removenToolStripMenuItem";
            this.removenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.removenToolStripMenuItem.Text = "Remove new lines (\\n)";
            this.removenToolStripMenuItem.Click += new System.EventHandler(this.removeNewLineMenuItem_Click);
            // 
            // removeSpecialCharsToolStripMenuItem
            // 
            this.removeSpecialCharsToolStripMenuItem.Name = "removeSpecialCharsToolStripMenuItem";
            this.removeSpecialCharsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.removeSpecialCharsToolStripMenuItem.Text = "Remove special chars (\\)";
            this.removeSpecialCharsToolStripMenuItem.Click += new System.EventHandler(this.removeSpecialCharsToolStripMenuItem_Click);
            // 
            // btnViewSelected
            // 
            this.btnViewSelected.CheckOnClick = true;
            this.btnViewSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnViewSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSelected.Image")));
            this.btnViewSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewSelected.Name = "btnViewSelected";
            this.btnViewSelected.Size = new System.Drawing.Size(92, 22);
            this.btnViewSelected.Text = "View Selected";
            this.btnViewSelected.Click += new System.EventHandler(this.btnViewSelected_Click);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblError.LinkColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 507);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(778, 22);
            this.lblError.TabIndex = 5;
            this.lblError.TabStop = true;
            this.lblError.Text = "aa";
            this.lblError.VisitedLinkColor = System.Drawing.Color.Red;
            this.lblError.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblError_LinkClicked);
            // 
            // Url_decode
            // 
            this.Url_decode.Controls.Add(this.lbl_Row);
            this.Url_decode.Controls.Add(this.querylist);
            this.Url_decode.Controls.Add(this.btn_DeepDecode);
            this.Url_decode.Controls.Add(this.label3);
            this.Url_decode.Controls.Add(this.label2);
            this.Url_decode.Controls.Add(this.btn_Sort);
            this.Url_decode.Controls.Add(this.txt_ToSortUrl);
            this.Url_decode.Controls.Add(this.label1);
            this.Url_decode.Controls.Add(this.btn_Decode);
            this.Url_decode.Controls.Add(this.txt_RawUrl);
            this.Url_decode.Location = new System.Drawing.Point(4, 22);
            this.Url_decode.Name = "Url_decode";
            this.Url_decode.Padding = new System.Windows.Forms.Padding(3);
            this.Url_decode.Size = new System.Drawing.Size(784, 532);
            this.Url_decode.TabIndex = 2;
            this.Url_decode.Text = "Query Sort";
            this.Url_decode.UseVisualStyleBackColor = true;
            // 
            // lbl_Row
            // 
            this.lbl_Row.AutoSize = true;
            this.lbl_Row.Location = new System.Drawing.Point(13, 327);
            this.lbl_Row.Name = "lbl_Row";
            this.lbl_Row.Size = new System.Drawing.Size(71, 12);
            this.lbl_Row.TabIndex = 10;
            this.lbl_Row.Text = "Sort Data :";
            // 
            // querylist
            // 
            this.querylist.AllowUserToAddRows = false;
            this.querylist.AllowUserToDeleteRows = false;
            this.querylist.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.querylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.querylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.querylist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.querylist.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.querylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ËÎÌו", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.querylist.DefaultCellStyle = dataGridViewCellStyle2;
            this.querylist.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.querylist.Location = new System.Drawing.Point(99, 196);
            this.querylist.Name = "querylist";
            this.querylist.RowTemplate.Height = 23;
            this.querylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.querylist.Size = new System.Drawing.Size(646, 254);
            this.querylist.TabIndex = 9;
            this.querylist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.querylist_CellDoubleClick);
            // 
            // btn_DeepDecode
            // 
            this.btn_DeepDecode.Location = new System.Drawing.Point(670, 81);
            this.btn_DeepDecode.Name = "btn_DeepDecode";
            this.btn_DeepDecode.Size = new System.Drawing.Size(75, 23);
            this.btn_DeepDecode.TabIndex = 8;
            this.btn_DeepDecode.Text = "DeepDecode";
            this.btn_DeepDecode.UseVisualStyleBackColor = true;
            this.btn_DeepDecode.Click += new System.EventHandler(this.btn_DeepDecode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ToSort Url :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Raw Url :";
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(670, 143);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 4;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // txt_ToSortUrl
            // 
            this.txt_ToSortUrl.Location = new System.Drawing.Point(99, 122);
            this.txt_ToSortUrl.Multiline = true;
            this.txt_ToSortUrl.Name = "txt_ToSortUrl";
            this.txt_ToSortUrl.Size = new System.Drawing.Size(555, 67);
            this.txt_ToSortUrl.TabIndex = 3;
            this.txt_ToSortUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ToSortUrl_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url Sort And Decode";
            // 
            // btn_Decode
            // 
            this.btn_Decode.Location = new System.Drawing.Point(670, 35);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(75, 23);
            this.btn_Decode.TabIndex = 1;
            this.btn_Decode.Text = "Decode";
            this.btn_Decode.UseVisualStyleBackColor = true;
            this.btn_Decode.Click += new System.EventHandler(this.btn_Decode_Click);
            // 
            // txt_RawUrl
            // 
            this.txt_RawUrl.Location = new System.Drawing.Point(99, 37);
            this.txt_RawUrl.Multiline = true;
            this.txt_RawUrl.Name = "txt_RawUrl";
            this.txt_RawUrl.Size = new System.Drawing.Size(555, 68);
            this.txt_RawUrl.TabIndex = 0;
            this.txt_RawUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_RawUrl_KeyDown);
            // 
            // Url_View
            // 
            this.Url_View.Controls.Add(this.ddl_item);
            this.Url_View.Controls.Add(this.txt_GetHTML);
            this.Url_View.Controls.Add(this.GetWebString);
            this.Url_View.Controls.Add(this.label4);
            this.Url_View.Controls.Add(this.txt_Url);
            this.Url_View.Location = new System.Drawing.Point(4, 22);
            this.Url_View.Name = "Url_View";
            this.Url_View.Padding = new System.Windows.Forms.Padding(3);
            this.Url_View.Size = new System.Drawing.Size(784, 532);
            this.Url_View.TabIndex = 3;
            this.Url_View.Text = "Url View";
            this.Url_View.UseVisualStyleBackColor = true;
            // 
            // ddl_item
            // 
            this.ddl_item.FormattingEnabled = true;
            this.ddl_item.Items.AddRange(new object[] {
            "Default",
            "UTF-8"});
            this.ddl_item.Location = new System.Drawing.Point(557, 33);
            this.ddl_item.Name = "ddl_item";
            this.ddl_item.Size = new System.Drawing.Size(88, 20);
            this.ddl_item.TabIndex = 4;
            this.ddl_item.Text = "UTF-8";
            // 
            // txt_GetHTML
            // 
            this.txt_GetHTML.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txt_GetHTML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_GetHTML.Location = new System.Drawing.Point(3, 115);
            this.txt_GetHTML.Multiline = true;
            this.txt_GetHTML.Name = "txt_GetHTML";
            this.txt_GetHTML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GetHTML.Size = new System.Drawing.Size(778, 414);
            this.txt_GetHTML.TabIndex = 3;
            this.txt_GetHTML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GetHTML_KeyDown);
            // 
            // GetWebString
            // 
            this.GetWebString.Location = new System.Drawing.Point(669, 31);
            this.GetWebString.Name = "GetWebString";
            this.GetWebString.Size = new System.Drawing.Size(94, 23);
            this.GetWebString.TabIndex = 2;
            this.GetWebString.Text = "Get";
            this.GetWebString.UseVisualStyleBackColor = true;
            this.GetWebString.Click += new System.EventHandler(this.GetWebString_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "URL :";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(68, 33);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(472, 21);
            this.txt_Url.TabIndex = 0;
            // 
            // httpViewer
            // 
            this.httpViewer.Controls.Add(this.dgv_ResponseList);
            this.httpViewer.Controls.Add(this.label7);
            this.httpViewer.Controls.Add(this.label5);
            this.httpViewer.Controls.Add(this.txt_HttpGetUrl);
            this.httpViewer.Controls.Add(this.button1);
            this.httpViewer.Location = new System.Drawing.Point(4, 22);
            this.httpViewer.Name = "httpViewer";
            this.httpViewer.Padding = new System.Windows.Forms.Padding(3);
            this.httpViewer.Size = new System.Drawing.Size(784, 532);
            this.httpViewer.TabIndex = 4;
            this.httpViewer.Text = "HttpViewer";
            this.httpViewer.UseVisualStyleBackColor = true;
            // 
            // dgv_ResponseList
            // 
            this.dgv_ResponseList.AllowUserToAddRows = false;
            this.dgv_ResponseList.AllowUserToDeleteRows = false;
            this.dgv_ResponseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResponseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ResponseList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("ËÎÌו", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ResponseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ResponseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("ËÎÌו", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ResponseList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ResponseList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ResponseList.Location = new System.Drawing.Point(3, 121);
            this.dgv_ResponseList.Name = "dgv_ResponseList";
            this.dgv_ResponseList.ReadOnly = true;
            this.dgv_ResponseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ResponseList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ResponseList.RowTemplate.Height = 23;
            this.dgv_ResponseList.Size = new System.Drawing.Size(778, 408);
            this.dgv_ResponseList.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Response Header :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Site Url :";
            // 
            // txt_HttpGetUrl
            // 
            this.txt_HttpGetUrl.Location = new System.Drawing.Point(110, 23);
            this.txt_HttpGetUrl.Name = "txt_HttpGetUrl";
            this.txt_HttpGetUrl.Size = new System.Drawing.Size(526, 21);
            this.txt_HttpGetUrl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.browser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 532);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "WebBrowser";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // browser1
            // 
            this.browser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser1.Location = new System.Drawing.Point(3, 3);
            this.browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser1.Name = "browser1";
            this.browser1.ScriptErrorsSuppressed = true;
            this.browser1.Size = new System.Drawing.Size(778, 526);
            this.browser1.TabIndex = 4;
            // 
            // JsonViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "JsonViewer";
            this.Size = new System.Drawing.Size(792, 558);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JsonViewer_KeyDown);
            this.spcViewer.Panel1.ResumeLayout(false);
            this.spcViewer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcViewer)).EndInit();
            this.spcViewer.ResumeLayout(false);
            this.mnuTree.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.mnuVisualizerPnl.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pageTreeView.ResumeLayout(false);
            this.pageTextView.ResumeLayout(false);
            this.pageTextView.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Url_decode.ResumeLayout(false);
            this.Url_decode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.querylist)).EndInit();
            this.Url_View.ResumeLayout(false);
            this.Url_View.PerformLayout();
            this.httpViewer.ResumeLayout(false);
            this.httpViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResponseList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcViewer;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TreeView tvJson;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageTreeView;
        private System.Windows.Forms.TabPage pageTextView;
        private System.Windows.Forms.LinkLabel lblError;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFormat;
        private System.Windows.Forms.ToolStripSplitButton btnStrip;
        private System.Windows.Forms.ToolStripMenuItem btnStripToCurly;
        private System.Windows.Forms.ToolStripMenuItem btnStripToSqr;
        private System.Windows.Forms.Panel pnlVisualizer;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnCloseFind;
        private System.Windows.Forms.ContextMenuStrip mnuTree;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuExpandAll;
        private System.Windows.Forms.ContextMenuStrip mnuVisualizerPnl;
        private System.Windows.Forms.ToolStripMenuItem mnuShowOnRight;
        private System.Windows.Forms.ToolStripMenuItem mnuShowOnBottom;
        private System.Windows.Forms.ComboBox cbVisualizers;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyValue;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem removenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSpecialCharsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnViewSelected;
        private System.Windows.Forms.RichTextBox txtJson;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyName;
        private System.Windows.Forms.TabPage Url_decode;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.TextBox txt_ToSortUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.TextBox txt_RawUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DeepDecode;
        private System.Windows.Forms.DataGridView querylist;
        private System.Windows.Forms.Label lbl_Row;
        private System.Windows.Forms.TabPage Url_View;
        private System.Windows.Forms.Button GetWebString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.TextBox txt_GetHTML;
        private System.Windows.Forms.ComboBox ddl_item;
        private System.Windows.Forms.TabPage httpViewer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HttpGetUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser browser1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_ResponseList;

    }
}
