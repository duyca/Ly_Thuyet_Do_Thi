using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KS.Views.Pop_Ups
{
    public partial class RoomPop : Form
    {
        private HomePage parent;
        public RoomPop(HomePage parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void close()
        {
            this.Close();
            parent.room1.Pop_Ups = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.close();
        }

    }
}
