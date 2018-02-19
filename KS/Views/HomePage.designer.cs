namespace KS.Views
{
    partial class HomePage
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.head = new System.Windows.Forms.Panel();
            this.btnMaxi = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitleLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pn_mainContain = new System.Windows.Forms.Panel();
            this.pn_Contain = new System.Windows.Forms.Panel();
            this.pn_data = new System.Windows.Forms.Panel();
            this.LeftPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMnu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRoomType = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnService = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelTran = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_tran2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.home1 = new KS.Views.UserControls.Home();
            this.service1 = new KS.Views.UserControls.Service();
            this.room1 = new KS.Views.UserControls.Room();
            this.roomtype1 = new KS.Views.UserControls.RoomType();
            this.history1 = new KS.Views.UserControls.History();
            this.setting1 = new KS.Views.UserControls.Setting();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLogo)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pn_mainContain.SuspendLayout();
            this.pn_Contain.SuspendLayout();
            this.pn_data.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // head
            // 
            this.head.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.head.Controls.Add(this.btnMaxi);
            this.head.Controls.Add(this.btnMini);
            this.head.Controls.Add(this.btnClose);
            this.head.Controls.Add(this.TitleLogo);
            this.head.Controls.Add(this.lbTitle);
            this.LogoTransition.SetDecoration(this.head, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.head, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.head, BunifuAnimatorNS.DecorationType.None);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1280, 40);
            this.head.TabIndex = 1;
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.LogoTransition.SetDecoration(this.btnMaxi, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnMaxi, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.btnMaxi, BunifuAnimatorNS.DecorationType.None);
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.ImageActive = null;
            this.btnMaxi.Location = new System.Drawing.Point(1219, 10);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(18, 18);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaxi.TabIndex = 5;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Zoom = 20;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.LogoTransition.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(1192, 10);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(21, 18);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 4;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 20;
            this.btnMini.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.LogoTransition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1246, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TitleLogo
            // 
            this.panel_tran2.SetDecoration(this.TitleLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.TitleLogo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.TitleLogo, BunifuAnimatorNS.DecorationType.None);
            this.TitleLogo.Image = ((System.Drawing.Image)(resources.GetObject("TitleLogo.Image")));
            this.TitleLogo.Location = new System.Drawing.Point(13, 11);
            this.TitleLogo.Name = "TitleLogo";
            this.TitleLogo.Size = new System.Drawing.Size(20, 20);
            this.TitleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleLogo.TabIndex = 1;
            this.TitleLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.panel_tran2.SetDecoration(this.lbTitle, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.lbTitle, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lbTitle, BunifuAnimatorNS.DecorationType.None);
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(39, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(155, 21);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Ateam Production";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.pn_mainContain);
            this.LogoTransition.SetDecoration(this.pnMain, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.pnMain, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.pnMain, BunifuAnimatorNS.DecorationType.None);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 40);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1280, 680);
            this.pnMain.TabIndex = 2;
            // 
            // pn_mainContain
            // 
            this.pn_mainContain.BackColor = System.Drawing.Color.Transparent;
            this.pn_mainContain.Controls.Add(this.pn_Contain);
            this.LogoTransition.SetDecoration(this.pn_mainContain, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.pn_mainContain, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.pn_mainContain, BunifuAnimatorNS.DecorationType.None);
            this.pn_mainContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_mainContain.Location = new System.Drawing.Point(0, 0);
            this.pn_mainContain.Name = "pn_mainContain";
            this.pn_mainContain.Size = new System.Drawing.Size(1280, 680);
            this.pn_mainContain.TabIndex = 1;
            // 
            // pn_Contain
            // 
            this.pn_Contain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_Contain.Controls.Add(this.pn_data);
            this.pn_Contain.Controls.Add(this.LeftPanel);
            this.LogoTransition.SetDecoration(this.pn_Contain, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.pn_Contain, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.pn_Contain, BunifuAnimatorNS.DecorationType.None);
            this.pn_Contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Contain.Location = new System.Drawing.Point(0, 0);
            this.pn_Contain.Name = "pn_Contain";
            this.pn_Contain.Size = new System.Drawing.Size(1280, 680);
            this.pn_Contain.TabIndex = 14;
            // 
            // pn_data
            // 
            this.pn_data.Controls.Add(this.home1);
            this.pn_data.Controls.Add(this.service1);
            this.pn_data.Controls.Add(this.room1);
            this.pn_data.Controls.Add(this.roomtype1);
            this.pn_data.Controls.Add(this.history1);
            this.pn_data.Controls.Add(this.setting1);
            this.LogoTransition.SetDecoration(this.pn_data, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.pn_data, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.pn_data, BunifuAnimatorNS.DecorationType.None);
            this.pn_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_data.Location = new System.Drawing.Point(260, 0);
            this.pn_data.Name = "pn_data";
            this.pn_data.Size = new System.Drawing.Size(1020, 680);
            this.pn_data.TabIndex = 18;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.Controls.Add(this.btnMnu);
            this.LeftPanel.Controls.Add(this.btnSetting);
            this.LeftPanel.Controls.Add(this.btnHistory);
            this.LeftPanel.Controls.Add(this.btnRoomType);
            this.LeftPanel.Controls.Add(this.btnService);
            this.LeftPanel.Controls.Add(this.btnRoom);
            this.LeftPanel.Controls.Add(this.btnSignOut);
            this.LeftPanel.Controls.Add(this.btnHome);
            this.LeftPanel.Controls.Add(this.logo);
            this.LogoTransition.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.LeftPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.GradientBottomLeft = System.Drawing.Color.Navy;
            this.LeftPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LeftPanel.GradientTopLeft = System.Drawing.Color.Purple;
            this.LeftPanel.GradientTopRight = System.Drawing.Color.Maroon;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Quality = 10;
            this.LeftPanel.Size = new System.Drawing.Size(260, 680);
            this.LeftPanel.TabIndex = 17;
            // 
            // btnMnu
            // 
            this.btnMnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMnu.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransition.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.btnMnu.Image = ((System.Drawing.Image)(resources.GetObject("btnMnu.Image")));
            this.btnMnu.ImageActive = null;
            this.btnMnu.Location = new System.Drawing.Point(215, 3);
            this.btnMnu.Name = "btnMnu";
            this.btnMnu.Size = new System.Drawing.Size(42, 39);
            this.btnMnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMnu.TabIndex = 10;
            this.btnMnu.TabStop = false;
            this.btnMnu.Zoom = 10;
            this.btnMnu.Click += new System.EventHandler(this.btnMnu_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "            Cài Đặt";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSetting, BunifuAnimatorNS.DecorationType.None);
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetting.Iconimage")));
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = true;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = true;
            this.btnSetting.IconZoom = 45D;
            this.btnSetting.IsTab = false;
            this.btnSetting.Location = new System.Drawing.Point(0, 481);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(260, 51);
            this.btnSetting.TabIndex = 21;
            this.btnSetting.Text = "            Cài Đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Textcolor = System.Drawing.Color.Silver;
            this.btnSetting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.ButtonText = "            Lịch Sử";
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnHistory, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnHistory, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnHistory, BunifuAnimatorNS.DecorationType.None);
            this.btnHistory.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistory.Font = new System.Drawing.Font("TUV Coco Gothic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistory.Iconimage")));
            this.btnHistory.Iconimage_right = null;
            this.btnHistory.Iconimage_right_Selected = null;
            this.btnHistory.Iconimage_Selected = null;
            this.btnHistory.IconMarginLeft = 0;
            this.btnHistory.IconMarginRight = 0;
            this.btnHistory.IconRightVisible = true;
            this.btnHistory.IconRightZoom = 0D;
            this.btnHistory.IconVisible = true;
            this.btnHistory.IconZoom = 45D;
            this.btnHistory.IsTab = true;
            this.btnHistory.Location = new System.Drawing.Point(0, 423);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHistory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHistory.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnHistory.selected = false;
            this.btnHistory.Size = new System.Drawing.Size(260, 51);
            this.btnHistory.TabIndex = 20;
            this.btnHistory.Text = "            Lịch Sử";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Textcolor = System.Drawing.Color.Silver;
            this.btnHistory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRoomType
            // 
            this.btnRoomType.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRoomType.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoomType.BorderRadius = 0;
            this.btnRoomType.ButtonText = "            Loại Phòng";
            this.btnRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnRoomType, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnRoomType, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnRoomType, BunifuAnimatorNS.DecorationType.None);
            this.btnRoomType.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoomType.Font = new System.Drawing.Font("TUV Coco Gothic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomType.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoomType.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRoomType.Iconimage")));
            this.btnRoomType.Iconimage_right = null;
            this.btnRoomType.Iconimage_right_Selected = null;
            this.btnRoomType.Iconimage_Selected = null;
            this.btnRoomType.IconMarginLeft = 0;
            this.btnRoomType.IconMarginRight = 0;
            this.btnRoomType.IconRightVisible = true;
            this.btnRoomType.IconRightZoom = 0D;
            this.btnRoomType.IconVisible = true;
            this.btnRoomType.IconZoom = 45D;
            this.btnRoomType.IsTab = true;
            this.btnRoomType.Location = new System.Drawing.Point(0, 364);
            this.btnRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoomType.Name = "btnRoomType";
            this.btnRoomType.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRoomType.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRoomType.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnRoomType.selected = false;
            this.btnRoomType.Size = new System.Drawing.Size(260, 51);
            this.btnRoomType.TabIndex = 19;
            this.btnRoomType.Text = "            Loại Phòng";
            this.btnRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomType.Textcolor = System.Drawing.Color.Silver;
            this.btnRoomType.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomType.Click += new System.EventHandler(this.btnRoomType_Click);
            // 
            // btnService
            // 
            this.btnService.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnService.BackColor = System.Drawing.Color.Transparent;
            this.btnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnService.BorderRadius = 0;
            this.btnService.ButtonText = "            Dịch Vụ";
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnService, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnService, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnService, BunifuAnimatorNS.DecorationType.None);
            this.btnService.DisabledColor = System.Drawing.Color.Gray;
            this.btnService.Font = new System.Drawing.Font("TUV Coco Gothic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Iconcolor = System.Drawing.Color.Transparent;
            this.btnService.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnService.Iconimage")));
            this.btnService.Iconimage_right = null;
            this.btnService.Iconimage_right_Selected = null;
            this.btnService.Iconimage_Selected = null;
            this.btnService.IconMarginLeft = 0;
            this.btnService.IconMarginRight = 0;
            this.btnService.IconRightVisible = true;
            this.btnService.IconRightZoom = 0D;
            this.btnService.IconVisible = true;
            this.btnService.IconZoom = 45D;
            this.btnService.IsTab = true;
            this.btnService.Location = new System.Drawing.Point(0, 305);
            this.btnService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnService.Name = "btnService";
            this.btnService.Normalcolor = System.Drawing.Color.Transparent;
            this.btnService.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnService.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnService.selected = false;
            this.btnService.Size = new System.Drawing.Size(260, 51);
            this.btnService.TabIndex = 17;
            this.btnService.Text = "            Dịch Vụ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Textcolor = System.Drawing.Color.Silver;
            this.btnService.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoom.BorderRadius = 0;
            this.btnRoom.ButtonText = "            Phòng";
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnRoom, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnRoom, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnRoom, BunifuAnimatorNS.DecorationType.None);
            this.btnRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoom.Font = new System.Drawing.Font("TUV Coco Gothic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRoom.Iconimage")));
            this.btnRoom.Iconimage_right = null;
            this.btnRoom.Iconimage_right_Selected = null;
            this.btnRoom.Iconimage_Selected = null;
            this.btnRoom.IconMarginLeft = 0;
            this.btnRoom.IconMarginRight = 0;
            this.btnRoom.IconRightVisible = true;
            this.btnRoom.IconRightZoom = 0D;
            this.btnRoom.IconVisible = true;
            this.btnRoom.IconZoom = 45D;
            this.btnRoom.IsTab = true;
            this.btnRoom.Location = new System.Drawing.Point(0, 248);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRoom.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnRoom.selected = false;
            this.btnRoom.Size = new System.Drawing.Size(260, 51);
            this.btnRoom.TabIndex = 16;
            this.btnRoom.Text = "            Phòng";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Textcolor = System.Drawing.Color.Silver;
            this.btnRoom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.BorderRadius = 0;
            this.btnSignOut.ButtonText = "             Thoát";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.btnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Iconimage")));
            this.btnSignOut.Iconimage_right = null;
            this.btnSignOut.Iconimage_right_Selected = null;
            this.btnSignOut.Iconimage_Selected = null;
            this.btnSignOut.IconMarginLeft = 0;
            this.btnSignOut.IconMarginRight = 0;
            this.btnSignOut.IconRightVisible = true;
            this.btnSignOut.IconRightZoom = 0D;
            this.btnSignOut.IconVisible = true;
            this.btnSignOut.IconZoom = 45D;
            this.btnSignOut.IsTab = true;
            this.btnSignOut.Location = new System.Drawing.Point(0, 533);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSignOut.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnSignOut.selected = false;
            this.btnSignOut.Size = new System.Drawing.Size(260, 49);
            this.btnSignOut.TabIndex = 15;
            this.btnSignOut.Text = "             Thoát";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Textcolor = System.Drawing.Color.Silver;
            this.btnSignOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "            Trang Chính";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_tran2.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("TUV Coco Gothic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 45D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 191);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(260, 51);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "            Trang Chính";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.Silver;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_tran2.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(45, 30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(167, 77);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.LogoTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation3;
            // 
            // PanelTran
            // 
            this.PanelTran.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelTran.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelTran.DefaultAnimation = animation2;
            this.PanelTran.MaxAnimationTime = 2000;
            this.PanelTran.TimeStep = 0.01F;
            // 
            // panel_tran2
            // 
            this.panel_tran2.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.panel_tran2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.panel_tran2.DefaultAnimation = animation1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.head;
            this.bunifuDragControl1.Vertical = true;
            // 
            // service1
            // 
            this.service1.BackColor = System.Drawing.Color.White;
            this.panel_tran2.SetDecoration(this.service1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.service1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.service1, BunifuAnimatorNS.DecorationType.None);
            this.service1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.service1.Location = new System.Drawing.Point(0, 0);
            this.service1.Name = "service1";
            this.service1.Size = new System.Drawing.Size(1020, 680);
            this.service1.TabIndex = 2;
            // 
            // home1
            // 
            this.panel_tran2.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.home1, BunifuAnimatorNS.DecorationType.None);
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1020, 680);
            this.home1.TabIndex = 1;
            // 
            // room1
            // 
            this.panel_tran2.SetDecoration(this.room1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.room1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.room1, BunifuAnimatorNS.DecorationType.None);
            this.room1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room1.Location = new System.Drawing.Point(0, 0);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(1020, 680);
            this.room1.TabIndex = 1;
            // 
            // roomtype1
            // 
            this.roomtype1.BackColor = System.Drawing.Color.White;
            this.panel_tran2.SetDecoration(this.roomtype1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.roomtype1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.roomtype1, BunifuAnimatorNS.DecorationType.None);
            this.roomtype1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomtype1.Location = new System.Drawing.Point(0, 0);
            this.roomtype1.Name = "roomtype1";
            this.roomtype1.Size = new System.Drawing.Size(1020, 680);
            this.roomtype1.TabIndex = 0;
            // 
            // history1
            // 
            this.history1.BackColor = System.Drawing.Color.White;
            this.panel_tran2.SetDecoration(this.history1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.history1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.history1, BunifuAnimatorNS.DecorationType.None);
            this.history1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history1.Location = new System.Drawing.Point(0, 0);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(1020, 680);
            this.history1.TabIndex = 0;
            // 
            // setting1
            // 
            this.setting1.BackColor = System.Drawing.Color.White;
            this.panel_tran2.SetDecoration(this.setting1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTran.SetDecoration(this.setting1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.setting1, BunifuAnimatorNS.DecorationType.None);
            this.setting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setting1.Location = new System.Drawing.Point(0, 0);
            this.setting1.Name = "setting1";
            this.setting1.Size = new System.Drawing.Size(1020, 680);
            this.setting1.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.head);
            this.PanelTran.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panel_tran2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlatTranfomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Resize += new System.EventHandler(this.HomePage_Resize);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLogo)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pn_mainContain.ResumeLayout(false);
            this.pn_Contain.ResumeLayout(false);
            this.pn_data.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private BunifuAnimatorNS.BunifuTransition PanelTran;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pn_mainContain;
        private System.Windows.Forms.PictureBox TitleLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnMaxi;
        private Bunifu.Framework.UI.BunifuImageButton btnMini;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel pn_Contain;
        private System.Windows.Forms.Panel head;
        private Bunifu.Framework.UI.BunifuGradientPanel LeftPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignOut;
        private Bunifu.Framework.UI.BunifuImageButton btnMnu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel pn_data;
        public Bunifu.Framework.UI.BunifuFlatButton btnHome;
        public Bunifu.Framework.UI.BunifuFlatButton btnRoom;
        public Bunifu.Framework.UI.BunifuFlatButton btnService;
        public Bunifu.Framework.UI.BunifuFlatButton btnRoomType;
        public Bunifu.Framework.UI.BunifuFlatButton btnHistory;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetting;
        public UserControls.Room room1;
        public UserControls.Home home1;
        public UserControls.Service service1;
        public UserControls.RoomType roomtype1;
        public UserControls.History history1;
        public UserControls.Setting setting1;
        private BunifuAnimatorNS.BunifuTransition panel_tran2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

