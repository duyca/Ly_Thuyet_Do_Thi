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
    public partial class CheckOut : Form
    {
        private HomePage parent;
        public CheckOut(HomePage parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void close()
        {
            parent.home1.checkout = false;
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.close();
        }
    }
}
