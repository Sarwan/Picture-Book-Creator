namespace PictureBookCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddPage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeletePage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearValidateLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuldBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbRight = new System.Windows.Forms.TabControl();
            this.tpPages = new System.Windows.Forms.TabPage();
            this.btnRemovePage = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.lbPages = new System.Windows.Forms.ListBox();
            this.tpResource = new System.Windows.Forms.TabPage();
            this.tvResource = new System.Windows.Forms.TreeView();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.btnImportThumbnail = new System.Windows.Forms.Button();
            this.btnImportCover = new System.Windows.Forms.Button();
            this.txtThumbnail = new System.Windows.Forms.TextBox();
            this.txtCover = new System.Windows.Forms.TextBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCatgory = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCatgory = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.btnEditImportSound = new System.Windows.Forms.Button();
            this.btnEditImportPicture = new System.Windows.Forms.Button();
            this.cmbEditSound = new System.Windows.Forms.ComboBox();
            this.cmbEditPicture = new System.Windows.Forms.ComboBox();
            this.txtEditText = new System.Windows.Forms.TextBox();
            this.lblEditText = new System.Windows.Forms.Label();
            this.lblEditSound = new System.Windows.Forms.Label();
            this.lblEditPicture = new System.Windows.Forms.Label();
            this.tpValidate = new System.Windows.Forms.TabPage();
            this.txtValidateInfo = new System.Windows.Forms.TextBox();
            this.pbValidate = new System.Windows.Forms.ProgressBar();
            this.btnValidate = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.TabPage();
            this.btnPreview = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.TabPage();
            this.txtBuildInfo = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbRight.SuspendLayout();
            this.tpPages.SuspendLayout();
            this.tpResource.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.tpValidate.SuspendLayout();
            this.Preview.SuspendLayout();
            this.Finish.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.32956F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpMain.Controls.Add(this.splitContainer1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.43086F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.56914F));
            this.tlpMain.Size = new System.Drawing.Size(784, 562);
            this.tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("ALKATIP Tor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuValidate,
            this.mnuPreview,
            this.mnuBuild,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateProject,
            this.mnuProjectOpen,
            this.mnuCloseProject,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(74, 26);
            this.mnuFile.Text = "ھۆججەت";
            // 
            // mnuCreateProject
            // 
            this.mnuCreateProject.Name = "mnuCreateProject";
            this.mnuCreateProject.Size = new System.Drawing.Size(168, 26);
            this.mnuCreateProject.Text = "كىتاب قۇرۇش";
            this.mnuCreateProject.Click += new System.EventHandler(this.mnuCreateProject_Click);
            // 
            // mnuProjectOpen
            // 
            this.mnuProjectOpen.Name = "mnuProjectOpen";
            this.mnuProjectOpen.Size = new System.Drawing.Size(168, 26);
            this.mnuProjectOpen.Text = "كىتاب ئېچىش";
            this.mnuProjectOpen.ToolTipText = "Open Book";
            this.mnuProjectOpen.Click += new System.EventHandler(this.mnuProjectOpen_Click);
            // 
            // mnuCloseProject
            // 
            this.mnuCloseProject.Name = "mnuCloseProject";
            this.mnuCloseProject.Size = new System.Drawing.Size(168, 26);
            this.mnuCloseProject.Text = "كىتاب تاقاش";
            this.mnuCloseProject.Click += new System.EventHandler(this.mnuCloseProject_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(168, 26);
            this.mnuExit.Text = "چىقىپ كېتىش";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddPage,
            this.mnuDeletePage});
            this.mnuEdit.Enabled = false;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(64, 26);
            this.mnuEdit.Text = "تەھرىر";
            // 
            // mnuAddPage
            // 
            this.mnuAddPage.Name = "mnuAddPage";
            this.mnuAddPage.Size = new System.Drawing.Size(166, 26);
            this.mnuAddPage.Text = "بەت قوش";
            this.mnuAddPage.Click += new System.EventHandler(this.mnuAddPage_Click);
            // 
            // mnuDeletePage
            // 
            this.mnuDeletePage.Name = "mnuDeletePage";
            this.mnuDeletePage.Size = new System.Drawing.Size(166, 26);
            this.mnuDeletePage.Text = "بەت ئۆچۈرۈش";
            this.mnuDeletePage.Click += new System.EventHandler(this.mnuDeletePage_Click);
            // 
            // mnuValidate
            // 
            this.mnuValidate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoValidate,
            this.mnuClearValidateLog});
            this.mnuValidate.Name = "mnuValidate";
            this.mnuValidate.Size = new System.Drawing.Size(87, 26);
            this.mnuValidate.Text = "تەكشۈرۈش";
            // 
            // mnuGoValidate
            // 
            this.mnuGoValidate.Name = "mnuGoValidate";
            this.mnuGoValidate.Size = new System.Drawing.Size(253, 26);
            this.mnuGoValidate.Text = "تەكشۈر";
            // 
            // mnuClearValidateLog
            // 
            this.mnuClearValidateLog.Name = "mnuClearValidateLog";
            this.mnuClearValidateLog.Size = new System.Drawing.Size(253, 26);
            this.mnuClearValidateLog.Text = "تەكشۈرۈش خاتىرسىنى تازىلا";
            // 
            // mnuPreview
            // 
            this.mnuPreview.Name = "mnuPreview";
            this.mnuPreview.Size = new System.Drawing.Size(122, 26);
            this.mnuPreview.Text = "تەقلىدى كۆرۈش";
            // 
            // mnuBuild
            // 
            this.mnuBuild.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBuldBook});
            this.mnuBuild.Name = "mnuBuild";
            this.mnuBuild.Size = new System.Drawing.Size(48, 26);
            this.mnuBuild.Text = "تامام";
            // 
            // mnuBuldBook
            // 
            this.mnuBuldBook.Name = "mnuBuldBook";
            this.mnuBuldBook.Size = new System.Drawing.Size(262, 26);
            this.mnuBuldBook.Text = "كىتاب ھۆججىتىنى ھاسىل قىل";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(59, 26);
            this.mnuHelp.Text = "ياردەم";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.aboutToolStripMenuItem.Text = "ھەققىدە";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 89);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbRight);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbMain);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(778, 470);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbRight
            // 
            this.tbRight.Controls.Add(this.tpPages);
            this.tbRight.Controls.Add(this.tpResource);
            this.tbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRight.Location = new System.Drawing.Point(0, 0);
            this.tbRight.Name = "tbRight";
            this.tbRight.RightToLeftLayout = true;
            this.tbRight.SelectedIndex = 0;
            this.tbRight.Size = new System.Drawing.Size(234, 470);
            this.tbRight.TabIndex = 0;
            // 
            // tpPages
            // 
            this.tpPages.Controls.Add(this.btnRemovePage);
            this.tpPages.Controls.Add(this.btnAddPage);
            this.tpPages.Controls.Add(this.lbPages);
            this.tpPages.Location = new System.Drawing.Point(4, 31);
            this.tpPages.Name = "tpPages";
            this.tpPages.Padding = new System.Windows.Forms.Padding(3);
            this.tpPages.Size = new System.Drawing.Size(226, 435);
            this.tpPages.TabIndex = 0;
            this.tpPages.Text = "بەتلەر";
            this.tpPages.UseVisualStyleBackColor = true;
            // 
            // btnRemovePage
            // 
            this.btnRemovePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemovePage.Location = new System.Drawing.Point(19, 421);
            this.btnRemovePage.Name = "btnRemovePage";
            this.btnRemovePage.Size = new System.Drawing.Size(75, 29);
            this.btnRemovePage.TabIndex = 2;
            this.btnRemovePage.Text = "ئۆچۈرۈش";
            this.btnRemovePage.UseVisualStyleBackColor = true;
            this.btnRemovePage.Click += new System.EventHandler(this.btnRemovePage_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPage.Location = new System.Drawing.Point(134, 421);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(75, 29);
            this.btnAddPage.TabIndex = 1;
            this.btnAddPage.Text = "قوشۇش";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // lbPages
            // 
            this.lbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPages.FormattingEnabled = true;
            this.lbPages.ItemHeight = 22;
            this.lbPages.Location = new System.Drawing.Point(3, 3);
            this.lbPages.Name = "lbPages";
            this.lbPages.Size = new System.Drawing.Size(220, 400);
            this.lbPages.TabIndex = 0;
            this.lbPages.SelectedIndexChanged += new System.EventHandler(this.lbPages_SelectedIndexChanged);
            // 
            // tpResource
            // 
            this.tpResource.Controls.Add(this.tvResource);
            this.tpResource.Location = new System.Drawing.Point(4, 22);
            this.tpResource.Name = "tpResource";
            this.tpResource.Padding = new System.Windows.Forms.Padding(3);
            this.tpResource.Size = new System.Drawing.Size(226, 444);
            this.tpResource.TabIndex = 1;
            this.tpResource.Text = "ھۆججەتلەر";
            this.tpResource.UseVisualStyleBackColor = true;
            // 
            // tvResource
            // 
            this.tvResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResource.Location = new System.Drawing.Point(3, 3);
            this.tvResource.Name = "tvResource";
            this.tvResource.Size = new System.Drawing.Size(220, 438);
            this.tvResource.TabIndex = 0;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpBookInfo);
            this.tbMain.Controls.Add(this.tpEdit);
            this.tbMain.Controls.Add(this.tpValidate);
            this.tbMain.Controls.Add(this.Preview);
            this.tbMain.Controls.Add(this.Finish);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.RightToLeftLayout = true;
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(540, 470);
            this.tbMain.TabIndex = 0;
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.Controls.Add(this.btnImportThumbnail);
            this.tpBookInfo.Controls.Add(this.btnImportCover);
            this.tpBookInfo.Controls.Add(this.txtThumbnail);
            this.tpBookInfo.Controls.Add(this.txtCover);
            this.tpBookInfo.Controls.Add(this.lblThumbnail);
            this.tpBookInfo.Controls.Add(this.lblCover);
            this.tpBookInfo.Controls.Add(this.txtDescription);
            this.tpBookInfo.Controls.Add(this.txtCatgory);
            this.tpBookInfo.Controls.Add(this.txtAuthor);
            this.tpBookInfo.Controls.Add(this.txtBookTitle);
            this.tpBookInfo.Controls.Add(this.lblDescription);
            this.tpBookInfo.Controls.Add(this.lblCatgory);
            this.tpBookInfo.Controls.Add(this.lblAuthor);
            this.tpBookInfo.Controls.Add(this.lblBookTitle);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 31);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(532, 435);
            this.tpBookInfo.TabIndex = 0;
            this.tpBookInfo.Text = "كتاب ئۇچۇرى";
            this.tpBookInfo.UseVisualStyleBackColor = true;
            this.tpBookInfo.Leave += new System.EventHandler(this.tpBookInfo_Leave);
            // 
            // btnImportThumbnail
            // 
            this.btnImportThumbnail.Location = new System.Drawing.Point(8, 292);
            this.btnImportThumbnail.Name = "btnImportThumbnail";
            this.btnImportThumbnail.Size = new System.Drawing.Size(75, 23);
            this.btnImportThumbnail.TabIndex = 12;
            this.btnImportThumbnail.Text = "...";
            this.btnImportThumbnail.UseVisualStyleBackColor = true;
            this.btnImportThumbnail.Click += new System.EventHandler(this.btnImportThumbnail_Click);
            // 
            // btnImportCover
            // 
            this.btnImportCover.Location = new System.Drawing.Point(8, 256);
            this.btnImportCover.Name = "btnImportCover";
            this.btnImportCover.Size = new System.Drawing.Size(75, 23);
            this.btnImportCover.TabIndex = 11;
            this.btnImportCover.Text = "...";
            this.btnImportCover.UseVisualStyleBackColor = true;
            this.btnImportCover.Click += new System.EventHandler(this.btnImportCover_Click);
            // 
            // txtThumbnail
            // 
            this.txtThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThumbnail.Location = new System.Drawing.Point(107, 292);
            this.txtThumbnail.Name = "txtThumbnail";
            this.txtThumbnail.ReadOnly = true;
            this.txtThumbnail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThumbnail.Size = new System.Drawing.Size(299, 30);
            this.txtThumbnail.TabIndex = 10;
            // 
            // txtCover
            // 
            this.txtCover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCover.Location = new System.Drawing.Point(107, 256);
            this.txtCover.Name = "txtCover";
            this.txtCover.ReadOnly = true;
            this.txtCover.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCover.Size = new System.Drawing.Size(299, 30);
            this.txtCover.TabIndex = 10;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(416, 300);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(110, 22);
            this.lblThumbnail.TabIndex = 9;
            this.lblThumbnail.Text = "كىچىك رەسىمى:";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(471, 259);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(48, 22);
            this.lblCover.TabIndex = 8;
            this.lblCover.Text = "مۇقاۋا:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(8, 128);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(398, 113);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtCatgory
            // 
            this.txtCatgory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatgory.Location = new System.Drawing.Point(8, 89);
            this.txtCatgory.Name = "txtCatgory";
            this.txtCatgory.Size = new System.Drawing.Size(398, 30);
            this.txtCatgory.TabIndex = 6;
            this.txtCatgory.Leave += new System.EventHandler(this.txtCatgory_Leave);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.Location = new System.Drawing.Point(8, 42);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(398, 30);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookTitle.Location = new System.Drawing.Point(8, 6);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(398, 30);
            this.txtBookTitle.TabIndex = 4;
            this.txtBookTitle.Leave += new System.EventHandler(this.txtBookTitle_Leave);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(416, 131);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 22);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "قىسقىچە مەزمۇنى:";
            // 
            // lblCatgory
            // 
            this.lblCatgory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCatgory.AutoSize = true;
            this.lblCatgory.Location = new System.Drawing.Point(487, 97);
            this.lblCatgory.Name = "lblCatgory";
            this.lblCatgory.Size = new System.Drawing.Size(45, 22);
            this.lblCatgory.TabIndex = 2;
            this.lblCatgory.Text = "تۈرى:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(471, 50);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 22);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "ئاپتورى:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(450, 14);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(82, 22);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "كىتاب نامى:";
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.btnEditImportSound);
            this.tpEdit.Controls.Add(this.btnEditImportPicture);
            this.tpEdit.Controls.Add(this.cmbEditSound);
            this.tpEdit.Controls.Add(this.cmbEditPicture);
            this.tpEdit.Controls.Add(this.txtEditText);
            this.tpEdit.Controls.Add(this.lblEditText);
            this.tpEdit.Controls.Add(this.lblEditSound);
            this.tpEdit.Controls.Add(this.lblEditPicture);
            this.tpEdit.Location = new System.Drawing.Point(4, 31);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(532, 435);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "تەھرىرلەش";
            this.tpEdit.UseVisualStyleBackColor = true;
            this.tpEdit.Enter += new System.EventHandler(this.tpEdit_Enter);
            this.tpEdit.Leave += new System.EventHandler(this.tpEdit_Leave);
            // 
            // btnEditImportSound
            // 
            this.btnEditImportSound.Location = new System.Drawing.Point(6, 70);
            this.btnEditImportSound.Name = "btnEditImportSound";
            this.btnEditImportSound.Size = new System.Drawing.Size(75, 23);
            this.btnEditImportSound.TabIndex = 8;
            this.btnEditImportSound.Text = "...";
            this.btnEditImportSound.UseVisualStyleBackColor = true;
            this.btnEditImportSound.Click += new System.EventHandler(this.btnEditImportSound_Click);
            // 
            // btnEditImportPicture
            // 
            this.btnEditImportPicture.Location = new System.Drawing.Point(6, 29);
            this.btnEditImportPicture.Name = "btnEditImportPicture";
            this.btnEditImportPicture.Size = new System.Drawing.Size(75, 23);
            this.btnEditImportPicture.TabIndex = 7;
            this.btnEditImportPicture.Text = "...";
            this.btnEditImportPicture.UseVisualStyleBackColor = true;
            this.btnEditImportPicture.Click += new System.EventHandler(this.btnEditImportPicture_Click);
            // 
            // cmbEditSound
            // 
            this.cmbEditSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEditSound.FormattingEnabled = true;
            this.cmbEditSound.Location = new System.Drawing.Point(87, 70);
            this.cmbEditSound.Name = "cmbEditSound";
            this.cmbEditSound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEditSound.Size = new System.Drawing.Size(335, 30);
            this.cmbEditSound.TabIndex = 6;
            this.cmbEditSound.Leave += new System.EventHandler(this.cmbEditSound_Leave);
            // 
            // cmbEditPicture
            // 
            this.cmbEditPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEditPicture.FormattingEnabled = true;
            this.cmbEditPicture.Location = new System.Drawing.Point(87, 27);
            this.cmbEditPicture.Name = "cmbEditPicture";
            this.cmbEditPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEditPicture.Size = new System.Drawing.Size(335, 30);
            this.cmbEditPicture.TabIndex = 5;
            this.cmbEditPicture.Leave += new System.EventHandler(this.cmbEditPicture_Leave);
            // 
            // txtEditText
            // 
            this.txtEditText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditText.Location = new System.Drawing.Point(6, 115);
            this.txtEditText.Multiline = true;
            this.txtEditText.Name = "txtEditText";
            this.txtEditText.Size = new System.Drawing.Size(416, 124);
            this.txtEditText.TabIndex = 4;
            this.txtEditText.Leave += new System.EventHandler(this.txtEditText_Leave);
            // 
            // lblEditText
            // 
            this.lblEditText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditText.AutoSize = true;
            this.lblEditText.Location = new System.Drawing.Point(457, 118);
            this.lblEditText.Name = "lblEditText";
            this.lblEditText.Size = new System.Drawing.Size(64, 22);
            this.lblEditText.TabIndex = 2;
            this.lblEditText.Text = "تېكىست:";
            // 
            // lblEditSound
            // 
            this.lblEditSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditSound.AutoSize = true;
            this.lblEditSound.Location = new System.Drawing.Point(480, 78);
            this.lblEditSound.Name = "lblEditSound";
            this.lblEditSound.Size = new System.Drawing.Size(41, 22);
            this.lblEditSound.TabIndex = 1;
            this.lblEditSound.Text = "ئاۋاز:";
            // 
            // lblEditPicture
            // 
            this.lblEditPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditPicture.AutoSize = true;
            this.lblEditPicture.Location = new System.Drawing.Point(470, 30);
            this.lblEditPicture.Name = "lblEditPicture";
            this.lblEditPicture.Size = new System.Drawing.Size(51, 22);
            this.lblEditPicture.TabIndex = 0;
            this.lblEditPicture.Text = "رەسىم:";
            // 
            // tpValidate
            // 
            this.tpValidate.Controls.Add(this.txtValidateInfo);
            this.tpValidate.Controls.Add(this.pbValidate);
            this.tpValidate.Controls.Add(this.btnValidate);
            this.tpValidate.Location = new System.Drawing.Point(4, 31);
            this.tpValidate.Name = "tpValidate";
            this.tpValidate.Size = new System.Drawing.Size(532, 435);
            this.tpValidate.TabIndex = 2;
            this.tpValidate.Text = "تەكشۈرۈش";
            this.tpValidate.UseVisualStyleBackColor = true;
            // 
            // txtValidateInfo
            // 
            this.txtValidateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValidateInfo.Location = new System.Drawing.Point(5, 46);
            this.txtValidateInfo.Multiline = true;
            this.txtValidateInfo.Name = "txtValidateInfo";
            this.txtValidateInfo.ReadOnly = true;
            this.txtValidateInfo.Size = new System.Drawing.Size(524, 399);
            this.txtValidateInfo.TabIndex = 2;
            // 
            // pbValidate
            // 
            this.pbValidate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbValidate.Location = new System.Drawing.Point(5, 7);
            this.pbValidate.Name = "pbValidate";
            this.pbValidate.Size = new System.Drawing.Size(443, 33);
            this.pbValidate.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(454, 7);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 33);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "تەكشۈر";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.btnPreview);
            this.Preview.Location = new System.Drawing.Point(4, 31);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(532, 435);
            this.Preview.TabIndex = 3;
            this.Preview.Text = "تەقلىدى كۆرۈش";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPreview.Location = new System.Drawing.Point(204, 27);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(125, 33);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "كۆرۈپ بېقىش";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // Finish
            // 
            this.Finish.Controls.Add(this.txtBuildInfo);
            this.Finish.Controls.Add(this.btnBuild);
            this.Finish.Location = new System.Drawing.Point(4, 31);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(532, 435);
            this.Finish.TabIndex = 4;
            this.Finish.Text = "تامام";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // txtBuildInfo
            // 
            this.txtBuildInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuildInfo.Location = new System.Drawing.Point(5, 57);
            this.txtBuildInfo.Multiline = true;
            this.txtBuildInfo.Name = "txtBuildInfo";
            this.txtBuildInfo.Size = new System.Drawing.Size(524, 373);
            this.txtBuildInfo.TabIndex = 1;
            // 
            // btnBuild
            // 
            this.btnBuild.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuild.Location = new System.Drawing.Point(207, 15);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(123, 36);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "ھاسىل قىلىش";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("ALKATIP Tor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رەسىملىك كىتاب ياسىغۇچ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbRight.ResumeLayout(false);
            this.tpPages.ResumeLayout(false);
            this.tpResource.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            this.tpBookInfo.PerformLayout();
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            this.tpValidate.ResumeLayout(false);
            this.tpValidate.PerformLayout();
            this.Preview.ResumeLayout(false);
            this.Finish.ResumeLayout(false);
            this.Finish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tbRight;
        private System.Windows.Forms.TabPage tpPages;
        private System.Windows.Forms.TabPage tpResource;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpBookInfo;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.TabPage tpValidate;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.TabPage Finish;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuValidate;
        private System.Windows.Forms.ToolStripMenuItem mnuPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuBuild;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ListBox lbPages;
        private System.Windows.Forms.TreeView tvResource;
        private System.Windows.Forms.Button btnEditImportSound;
        private System.Windows.Forms.Button btnEditImportPicture;
        private System.Windows.Forms.ComboBox cmbEditSound;
        private System.Windows.Forms.ComboBox cmbEditPicture;
        private System.Windows.Forms.TextBox txtEditText;
        private System.Windows.Forms.Label lblEditText;
        private System.Windows.Forms.Label lblEditSound;
        private System.Windows.Forms.Label lblEditPicture;
        private System.Windows.Forms.ProgressBar pbValidate;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtValidateInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCatgory;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCatgory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Button btnImportThumbnail;
        private System.Windows.Forms.Button btnImportCover;
        private System.Windows.Forms.TextBox txtThumbnail;
        private System.Windows.Forms.TextBox txtCover;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtBuildInfo;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseProject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuGoValidate;
        private System.Windows.Forms.ToolStripMenuItem mnuClearValidateLog;
        private System.Windows.Forms.ToolStripMenuItem mnuBuldBook;
        private System.Windows.Forms.ToolStripMenuItem mnuAddPage;
        private System.Windows.Forms.ToolStripMenuItem mnuDeletePage;
        private System.Windows.Forms.Button btnRemovePage;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

