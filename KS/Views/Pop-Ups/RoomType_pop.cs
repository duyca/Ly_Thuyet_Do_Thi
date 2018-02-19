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
    public partial class RoomType_pop : Form
    {
        private HomePage parent;
        public RoomType_pop(HomePage parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void close()
        {
            parent.roomtype1.Pop_Ups = false;
            this.Close();        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            close();
        }
    }
}
