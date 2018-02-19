using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KS.Views.UserControls
{
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
            setting();
        }
        private void setting()
        {
            dgv_ListRoom.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.More_Details_32px,
                Name = "Detail",
                HeaderText = ""
            });
            dgv_ListRoom.Columns[5].FillWeight = 20;
            dgv_ListRoom.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.Print_32px,
                Name = "Print",
                HeaderText = ""
            });
            dgv_ListRoom.Columns[6].FillWeight = 20;
            //dgv_ListService.AllowUserToAddRows = false;
        }

        private void dgv_ListRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //I supposed the image column is at index 1
            if (e.ColumnIndex == 5)
                e.Value = Properties.Resources.More_Details_32px;
            if (e.ColumnIndex == 6)
                e.Value = Properties.Resources.Print_32px;
        }

        private void dgv_ListRoom_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.More_Details_32px.Width;
                var h = Properties.Resources.More_Details_32px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.More_Details_32px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Print_32px.Width;
                var h = Properties.Resources.Print_32px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Print_32px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgv_ListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 && e.ColumnIndex != 6)
            {
                return;
            }
            else if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Print");
            }
            else
            {
                MessageBox.Show(dgv_ListRoom.CurrentCell.RowIndex.ToString());
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //if (!Pop_Ups)
            //{
            //    RoomPop pop = new RoomPop(this.FindForm() as HomePage);
            //    pop.Show();
            //    Pop_Ups = true;
            //}
        }
    }
}
