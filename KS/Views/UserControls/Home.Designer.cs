namespace KS.Views.UserControls
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("001", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("002", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("003", 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("004", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("004", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("004", 0);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("004", 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("004", 0);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("004", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pn_Footer = new System.Windows.Forms.Panel();
            this.pn_ServiceList = new System.Windows.Forms.Panel();
            this.dgv_ListService = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_RoomInfo = new System.Windows.Forms.Panel();
            this.txtDonGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckInTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRentType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_RoomListService = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_Line = new System.Windows.Forms.Panel();
            this.linePass = new Bunifu.Framework.UI.BunifuSeparator();
            this.pn_ListRoom = new System.Windows.Forms.Panel();
            this.lv_ListRoom = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Footer.SuspendLayout();
            this.pn_ServiceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListService)).BeginInit();
            this.pn_RoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomListService)).BeginInit();
            this.pn_Line.SuspendLayout();
            this.pn_ListRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Footer
            // 
            this.pn_Footer.BackColor = System.Drawing.Color.White;
            this.pn_Footer.Controls.Add(this.pn_ServiceList);
            this.pn_Footer.Controls.Add(this.pn_RoomInfo);
            this.pn_Footer.Controls.Add(this.pn_Line);
            this.pn_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Footer.Location = new System.Drawing.Point(0, 400);
            this.pn_Footer.Name = "pn_Footer";
            this.pn_Footer.Size = new System.Drawing.Size(1183, 252);
            this.pn_Footer.TabIndex = 0;
            // 
            // pn_ServiceList
            // 
            this.pn_ServiceList.Controls.Add(this.dgv_ListService);
            this.pn_ServiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ServiceList.Location = new System.Drawing.Point(771, 5);
            this.pn_ServiceList.Name = "pn_ServiceList";
            this.pn_ServiceList.Size = new System.Drawing.Size(412, 247);
            this.pn_ServiceList.TabIndex = 2;
            // 
            // dgv_ListService
            // 
            this.dgv_ListService.AllowUserToAddRows = false;
            this.dgv_ListService.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ListService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListService.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ListService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ListService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.Price,
            this.maDichVu,
            this.Active,
            this.aa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("TUV Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListService.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ListService.DoubleBuffered = true;
            this.dgv_ListService.EnableHeadersVisualStyles = false;
            this.dgv_ListService.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_ListService.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.dgv_ListService.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_ListService.Location = new System.Drawing.Point(3, 3);
            this.dgv_ListService.MultiSelect = false;
            this.dgv_ListService.Name = "dgv_ListService";
            this.dgv_ListService.ReadOnly = true;
            this.dgv_ListService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("TUV Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListService.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ListService.RowHeadersVisible = false;
            this.dgv_ListService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ListService.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_ListService.RowTemplate.Height = 24;
            this.dgv_ListService.RowTemplate.ReadOnly = true;
            this.dgv_ListService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListService.ShowRowErrors = false;
            this.dgv_ListService.Size = new System.Drawing.Size(406, 232);
            this.dgv_ListService.TabIndex = 0;
            this.dgv_ListService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListService_CellClick);
            this.dgv_ListService.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ListService_CellFormatting);
            this.dgv_ListService.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_ListService_CellPainting);
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "tenDichVu";
            this.ServiceName.HeaderText = "    Tên DV";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "donGia";
            dataGridViewCellStyle3.Format = "###,###";
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.FillWeight = 80F;
            this.Price.HeaderText = "   Đơn Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // maDichVu
            // 
            this.maDichVu.DataPropertyName = "maDichVu";
            this.maDichVu.HeaderText = "maDV";
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.ReadOnly = true;
            this.maDichVu.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Column1";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // aa
            // 
            this.aa.DataPropertyName = "SuDungDichVuS";
            this.aa.HeaderText = "Column1";
            this.aa.Name = "aa";
            this.aa.ReadOnly = true;
            this.aa.Visible = false;
            // 
            // pn_RoomInfo
            // 
            this.pn_RoomInfo.Controls.Add(this.txtDonGia);
            this.pn_RoomInfo.Controls.Add(this.label4);
            this.pn_RoomInfo.Controls.Add(this.txtCheckInTime);
            this.pn_RoomInfo.Controls.Add(this.label2);
            this.pn_RoomInfo.Controls.Add(this.bunifuSeparator1);
            this.pn_RoomInfo.Controls.Add(this.txtTotal);
            this.pn_RoomInfo.Controls.Add(this.label11);
            this.pn_RoomInfo.Controls.Add(this.txtTime);
            this.pn_RoomInfo.Controls.Add(this.label9);
            this.pn_RoomInfo.Controls.Add(this.txtRentType);
            this.pn_RoomInfo.Controls.Add(this.label7);
            this.pn_RoomInfo.Controls.Add(this.txtGuestName);
            this.pn_RoomInfo.Controls.Add(this.label3);
            this.pn_RoomInfo.Controls.Add(this.txtRoomNumber);
            this.pn_RoomInfo.Controls.Add(this.label1);
            this.pn_RoomInfo.Controls.Add(this.dgv_RoomListService);
            this.pn_RoomInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_RoomInfo.Location = new System.Drawing.Point(0, 5);
            this.pn_RoomInfo.Name = "pn_RoomInfo";
            this.pn_RoomInfo.Size = new System.Drawing.Size(771, 247);
            this.pn_RoomInfo.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.AutoSize = true;
            this.txtDonGia.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.txtDonGia.Location = new System.Drawing.Point(127, 138);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(0, 19);
            this.txtDonGia.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Đơn Giá:";
            // 
            // txtCheckInTime
            // 
            this.txtCheckInTime.AutoSize = true;
            this.txtCheckInTime.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.txtCheckInTime.Location = new System.Drawing.Point(127, 109);
            this.txtCheckInTime.Name = "txtCheckInTime";
            this.txtCheckInTime.Size = new System.Drawing.Size(0, 19);
            this.txtCheckInTime.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giờ Vào:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(761, -2);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 249);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotal.Location = new System.Drawing.Point(126, 198);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(0, 19);
            this.txtTotal.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(16, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tổng Tiền";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.txtTime.Location = new System.Drawing.Point(127, 167);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(0, 19);
            this.txtTime.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label9.Location = new System.Drawing.Point(15, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Đã Thuê:";
            // 
            // txtRentType
            // 
            this.txtRentType.AutoSize = true;
            this.txtRentType.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.txtRentType.Location = new System.Drawing.Point(127, 80);
            this.txtRentType.Name = "txtRentType";
            this.txtRentType.Size = new System.Drawing.Size(0, 19);
            this.txtRentType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hình thức:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.AutoSize = true;
            this.txtGuestName.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.txtGuestName.Location = new System.Drawing.Point(127, 53);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(0, 19);
            this.txtGuestName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách Hàng:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.AutoSize = true;
            this.txtRoomNumber.Font = new System.Drawing.Font("TUV Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.txtRoomNumber.Location = new System.Drawing.Point(126, 20);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(0, 21);
            this.txtRoomNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TUV Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng:";
            // 
            // dgv_RoomListService
            // 
            this.dgv_RoomListService.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("TUV Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_RoomListService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_RoomListService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_RoomListService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_RoomListService.BackgroundColor = System.Drawing.Color.White;
            this.dgv_RoomListService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_RoomListService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("TUV Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_RoomListService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_RoomListService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RoomListService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.donGia,
            this.soLuong,
            this.maSuDung});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("TUV Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RoomListService.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_RoomListService.DoubleBuffered = true;
            this.dgv_RoomListService.EnableHeadersVisualStyles = false;
            this.dgv_RoomListService.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_RoomListService.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.dgv_RoomListService.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_RoomListService.Location = new System.Drawing.Point(309, 3);
            this.dgv_RoomListService.MultiSelect = false;
            this.dgv_RoomListService.Name = "dgv_RoomListService";
            this.dgv_RoomListService.ReadOnly = true;
            this.dgv_RoomListService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("TUV Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_RoomListService.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_RoomListService.RowHeadersVisible = false;
            this.dgv_RoomListService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_RoomListService.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_RoomListService.RowTemplate.ReadOnly = true;
            this.dgv_RoomListService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RoomListService.Size = new System.Drawing.Size(450, 232);
            this.dgv_RoomListService.TabIndex = 1;
            this.dgv_RoomListService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListRoomSV_CellClick);
            this.dgv_RoomListService.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ListRoomSV_CellFormatting);
            this.dgv_RoomListService.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_ListRoomSV_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tenDichVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "    Tên DV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            dataGridViewCellStyle8.Format = "###,###";
            this.donGia.DefaultCellStyle = dataGridViewCellStyle8;
            this.donGia.FillWeight = 70F;
            this.donGia.HeaderText = "    Đơn Giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.FillWeight = 90F;
            this.soLuong.HeaderText = "     Số Lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // maSuDung
            // 
            this.maSuDung.DataPropertyName = "maSuDung";
            this.maSuDung.HeaderText = "maSuDung";
            this.maSuDung.Name = "maSuDung";
            this.maSuDung.ReadOnly = true;
            this.maSuDung.Visible = false;
            // 
            // pn_Line
            // 
            this.pn_Line.Controls.Add(this.linePass);
            this.pn_Line.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Line.Location = new System.Drawing.Point(0, 0);
            this.pn_Line.Name = "pn_Line";
            this.pn_Line.Size = new System.Drawing.Size(1183, 5);
            this.pn_Line.TabIndex = 0;
            // 
            // linePass
            // 
            this.linePass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePass.BackColor = System.Drawing.Color.Transparent;
            this.linePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.linePass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.linePass.LineThickness = 3;
            this.linePass.Location = new System.Drawing.Point(0, 0);
            this.linePass.Name = "linePass";
            this.linePass.Size = new System.Drawing.Size(1183, 6);
            this.linePass.TabIndex = 18;
            this.linePass.Transparency = 255;
            this.linePass.Vertical = false;
            // 
            // pn_ListRoom
            // 
            this.pn_ListRoom.AutoScroll = true;
            this.pn_ListRoom.Controls.Add(this.lv_ListRoom);
            this.pn_ListRoom.Controls.Add(this.panel1);
            this.pn_ListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ListRoom.Location = new System.Drawing.Point(0, 0);
            this.pn_ListRoom.Name = "pn_ListRoom";
            this.pn_ListRoom.Size = new System.Drawing.Size(1183, 400);
            this.pn_ListRoom.TabIndex = 1;
            // 
            // lv_ListRoom
            // 
            this.lv_ListRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_ListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ListRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ListRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.lv_ListRoom.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lv_ListRoom.LargeImageList = this.imageList1;
            this.lv_ListRoom.Location = new System.Drawing.Point(0, 10);
            this.lv_ListRoom.MultiSelect = false;
            this.lv_ListRoom.Name = "lv_ListRoom";
            this.lv_ListRoom.Size = new System.Drawing.Size(1183, 390);
            this.lv_ListRoom.TabIndex = 1;
            this.lv_ListRoom.UseCompatibleStateImageBehavior = false;
            this.lv_ListRoom.SelectedIndexChanged += new System.EventHandler(this.lv_ListRoom_SelectedIndexChanged);
            this.lv_ListRoom.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "room-0.png");
            this.imageList1.Images.SetKeyName(1, "room-1.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 10);
            this.panel1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_ListRoom);
            this.Controls.Add(this.pn_Footer);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1183, 652);
            this.pn_Footer.ResumeLayout(false);
            this.pn_ServiceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListService)).EndInit();
            this.pn_RoomInfo.ResumeLayout(false);
            this.pn_RoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomListService)).EndInit();
            this.pn_Line.ResumeLayout(false);
            this.pn_ListRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Footer;
        private System.Windows.Forms.Panel pn_ListRoom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pn_Line;
        private Bunifu.Framework.UI.BunifuSeparator linePass;
        private System.Windows.Forms.Panel pn_RoomInfo;
        private System.Windows.Forms.Panel pn_ServiceList;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_ListService;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_RoomListService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtRentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtGuestName;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lv_ListRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTotal;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCheckInTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn aa;
    }
}
