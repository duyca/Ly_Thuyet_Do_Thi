using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KS.Views
{
    public partial class HomePage : Form
    {
        public bool Rent = false;
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int CS_DBLCLKS = 0x8;
        private bool _isMaximized = false;
        private SignIn si;


        public HomePage()
        {
            InitializeComponent();
            InitSetting();
        }
        public void setSignInform(SignIn Signin)
        {
            si = Signin;
        }

        //form event
        private void InitSetting()
        {
            LeftPanel.Width = 50;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Home panel
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            btnHome.selected = true;
            home1.BringToFront();
        }
        //public void ActiveUserControl(Control con)
        //{
        //    foreach (Control c in listUserControl)
        //    {
        //        c.Visible = false;
        //        //if (c!= con)
        //        //{
        //        //    c.Visible = false;
        //        //}
        //        //else
        //        //{
        //        //    c.Visible = true;
        //        //}
        //    }
        //}
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //icon click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            foreach (UserControl c in pn_data.Controls)
            {
                c.Hide();
            }
            this.WindowState = FormWindowState.Minimized;

        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (_isMaximized == true)
            {
                this.WindowState = FormWindowState.Normal;
                _isMaximized = false;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                _isMaximized = true;
            }

        }
        private void btnMnu_Click(object sender, EventArgs e)
        {
            if (LeftPanel.Width == 50)
            {
                logo.Hide();
                LeftPanel.Hide();
                LeftPanel.Width = 260;
                LeftPanel.Show();
                LogoTransition.ShowSync(logo);
                //LeftPanel.Hide();
            }
            else
            {
                //LogoTransition.HideSync(logo);
                logo.Hide();
                LeftPanel.Hide();
                LeftPanel.Width = 50;
                panel_tran2.ShowSync(LeftPanel);
                
            }
        }
        //button Click events
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            si.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }
        private void HomePage_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                foreach (UserControl c in pn_data.Controls)
                {
                    c.Show();
                }
            }
            if (WindowState == FormWindowState.Minimized)
            {
                foreach (UserControl c in pn_data.Controls)
                {
                    c.Hide();
                }
            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            room1.BringToFront();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            service1.BringToFront();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            logo.Hide();
            LogoTransition.ShowSync(logo);
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            roomtype1.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            history1.BringToFront();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setting1.BringToFront();
        }
    }
}
