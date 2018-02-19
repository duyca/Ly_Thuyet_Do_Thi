namespace KS.Views.UserControls
{
    partial class Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.pn_contain = new System.Windows.Forms.Panel();
            this.pn_main = new System.Windows.Forms.Panel();
            this.dgv_ListRoom = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Qualty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_top = new System.Windows.Forms.Panel();
            this.btnCheckOut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pn_contain.SuspendLayout();
            this.pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListRoom)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_contain
            // 
            this.pn_contain.BackColor = System.Drawing.Color.White;
            this.pn_contain.Controls.Add(this.pn_main);
            this.pn_contain.Controls.Add(this.pn_top);
            this.pn_contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contain.Location = new System.Drawing.Point(0, 0);
            this.pn_contain.Name = "pn_contain";
            this.pn_contain.Size = new System.Drawing.Size(1183, 652);
            this.pn_contain.TabIndex = 0;
            // 
            // pn_main
            // 
            this.pn_main.Controls.Add(this.dgv_ListRoom);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 88);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1183, 564);
            this.pn_main.TabIndex = 1;
            // 
            // dgv_ListRoom
            // 
            this.dgv_ListRoom.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ListRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ListRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ListRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qualty,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_ListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListRoom.DoubleBuffered = true;
            this.dgv_ListRoom.EnableHeadersVisualStyles = false;
            this.dgv_ListRoom.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_ListRoom.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.dgv_ListRoom.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_ListRoom.Location = new System.Drawing.Point(0, 0);
            this.dgv_ListRoom.MultiSelect = false;
            this.dgv_ListRoom.Name = "dgv_ListRoom";
            this.dgv_ListRoom.ReadOnly = true;
            this.dgv_ListRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListRoom.RowHeadersVisible = false;
            this.dgv_ListRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ListRoom.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_ListRoom.RowTemplate.ReadOnly = true;
            this.dgv_ListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListRoom.Size = new System.Drawing.Size(1183, 564);
            this.dgv_ListRoom.TabIndex = 2;
            this.dgv_ListRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListRoom_CellClick);
            this.dgv_ListRoom.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ListRoom_CellFormatting);
            this.dgv_ListRoom.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_ListRoom_CellPainting);
            // 
            // Qualty
            // 
            this.Qualty.FillWeight = 60F;
            this.Qualty.HeaderText = "Mã Phòng";
            this.Qualty.Name = "Qualty";
            this.Qualty.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại Phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.White;
            this.pn_top.Controls.Add(this.btnCheckOut);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1183, 88);
            this.pn_top.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.ActiveBorderThickness = 1;
            this.btnCheckOut.ActiveCornerRadius = 30;
            this.btnCheckOut.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.btnCheckOut.ActiveForecolor = System.Drawing.Color.White;
            this.btnCheckOut.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.BackgroundImage")));
            this.btnCheckOut.ButtonText = "Thêm Mới";
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnCheckOut.IdleBorderThickness = 1;
            this.btnCheckOut.IdleCornerRadius = 30;
            this.btnCheckOut.IdleFillColor = System.Drawing.Color.White;
            this.btnCheckOut.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.btnCheckOut.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(227)))));
            this.btnCheckOut.Location = new System.Drawing.Point(1016, 25);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(141, 41);
            this.btnCheckOut.TabIndex = 34;
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_contain);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(1183, 652);
            this.pn_contain.ResumeLayout(false);
            this.pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListRoom)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_contain;
        private System.Windows.Forms.Panel pn_top;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCheckOut;
        private System.Windows.Forms.Panel pn_main;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_ListRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
