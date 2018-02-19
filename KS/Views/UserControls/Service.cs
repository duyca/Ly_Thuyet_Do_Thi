using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KS.Views.Pop_Ups;

namespace KS.Views.UserControls
{
    public partial class Service : UserControl
    {
        public bool Pop_Ups = false;
        public Service()
        {
            InitializeComponent();
            setting();
        }
        private void setting()
        {
            dgv_ListService.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.Edit_Property_32px,
                Name = "Edit",
                HeaderText = ""
            });
            dgv_ListService.Columns[3].FillWeight = 20;
            dgv_ListService.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Properties.Resources.Cancel_32px,
                Name = "Delete",
                HeaderText = ""
            });
            dgv_ListService.Columns[4].FillWeight = 20;
            //dgv_ListService.AllowUserToAddRows = false;
        }

        private void dgv_ListRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //I supposed the image column is at index 1
            if (e.ColumnIndex == 3)
                e.Value = Properties.Resources.Edit_Property_32px;
            if (e.ColumnIndex == 4)
                e.Value = Properties.Resources.Cancel_32px;
        }

        private void dgv_ListRoom_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Edit_Property_32px.Width;
                var h = Properties.Resources.Edit_Property_32px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Edit_Property_32px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Cancel_32px.Width;
                var h = Properties.Resources.Cancel_32px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Cancel_32px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgv_ListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 && e.ColumnIndex != 4)
            {
                return;
            }
            else if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Delete");
            }
            else
            {
                MessageBox.Show(dgv_ListService.CurrentCell.RowIndex.ToString());
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!Pop_Ups)
            {
                Service_pop pop = new Service_pop(this.FindForm() as HomePage);
                pop.Show();
                Pop_Ups = true;
            }
        }
    }
}
