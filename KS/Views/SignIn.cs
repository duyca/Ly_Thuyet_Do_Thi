using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KS.Views
{
    public partial class SignIn : Form
    {
        public HomePage home = new HomePage();
        public SignIn()
        {

            InitializeComponent();
        }
        private void CloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntabdangnhap_Click(object sender, EventArgs e)
        {
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            signin();
        }
        private void signin()
        {
            this.Hide();
            home.setSignInform(this);
            home.home1.LoadData();
            home.Show();
            //Model.KhachHang user2 = new Model.KhachHang();
            //user2.maKH = 1;
            //user2.hoTen = "Umaru hitoru";
            //user2.diaChi = "6614 Jenkins Prairie";
            //user2.moTa = "Sống nội tâm hay khóc thầm";
            //user2.email = "geovany@stroman.com";
            //user2.tenDangNhap = "geovany@stroman.com";
            //user2.matKhau = "geovany@stroman.com";
            //user2.soCMND = "123213";
            //user2.soDienThoai = "123123";
            //home.setKH(user2);
            //home.setSignInform(this);
            //home.Show(); //TODO By pass login
            //this.Hide();
            //return;

            //bool check = true;
            //// kiem tra du lieu 
            //if (txtUsername.Text == "")
            //{
            //    LineUsername.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtPass.Text == "")
            //{
            //    linePass.LineColor = Color.Red;
            //    check = false;
            //}

            //if (!check)
            //{
            //    MessageBox.Show("Pls insert all field");
            //    return;
            //}
            // xu ly
            //Model.KhachHang user = new Model.KhachHang();
            //user = Controllers.customer.SignIn(txtUsername.Text, txtPass.Text);
            //if (user != null)
            //{
            //    this.Hide();
            //    home.setSignInform(this);
            //    home.setKH(user);
            //    home.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong User Name or Pass");
            //}
        }
        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            LineUsername.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text !="")
            {
                LineUsername.LineColor = Color.Gray;
            }
            else
            {
                LineUsername.LineColor = Color.Red;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            linePass.LineColor = Color.FromArgb(93, 148, 227);
            txtPass.Text = "";
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != "")
            {
                linePass.LineColor = Color.Gray;
            }
            else
            {
                linePass.LineColor = Color.Red;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SignUp signuup = new SignUp(this);
            signuup.Show();
            this.Hide();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }
    }
}
