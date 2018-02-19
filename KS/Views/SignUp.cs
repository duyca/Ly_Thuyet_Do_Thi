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
    public partial class SignUp : Form
    {
        SignIn sign;
        public SignUp(SignIn sign)
        {
            this.sign = sign;
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //bool check = true;
            ////Kiem tra du lieu nhap
            //if (txtfullname.Text == "")
            //{
            //    linefullname.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtID.Text == "")
            //{
            //    lineID.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtaddress.Text == "")
            //{
            //    lineAddress.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtemail.Text == "")
            //{
            //    lineEmail.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtPass.Text == "")
            //{
            //    linePass.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtphone.Text == "")
            //{
            //    linePhone.LineColor = Color.Red;
            //    check = false;
            //}
            //if (txtUsername.Text == "")
            //{
            //    LineUsername.LineColor = Color.Red;
            //    check = false;
            //}
            //if (!check)
            //{
            //    MessageBox.Show("Plz insert all field");
            //    return;
            //}
            //else
            //{
            //    if (!customer.IsValid(txtemail.Text))
            //    {
            //        MessageBox.Show("Invalid email!");
            //        lineEmail.LineColor = Color.Red;
            //        return;
            //    }
            //    Model.KhachHang khach = new Model.KhachHang();
            //    khach.hoTen = txtfullname.Text;
            //    khach.tenDangNhap = txtUsername.Text;
            //    khach.matKhau = txtPass.Text;
            //    khach.soCMND = txtID.Text;
            //    khach.diaChi = txtaddress.Text;
            //    khach.soDienThoai = txtphone.Text;
            //    khach.moTa = txtdes.Text;
            //    khach.email = txtemail.Text;


            //    int status = Controllers.customer.SignUp(khach);
            //    if (status == 1)
            //    {
            //        SignIn signin = new SignIn();
            //        MessageBox.Show("Sign Up success!");
            //        this.Hide();
            //        signin.Show();
            //    }
            //    else
            //    {
            //        if (status == 0)
            //        {
            //            MessageBox.Show("Username not available! plz try again with another name of your choice");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Something wrong, plz check!");
            //        }
                    
            //    }
            //}

        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign.Show();
        }





        //textbox event
        private void txtfullname_Enter(object sender, EventArgs e)
        {
            linefullname.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtfullname_Leave(object sender, EventArgs e)
        {
            if (txtfullname.Text !="")
            {
                linefullname.LineColor = Color.Gray;
            }
            else
            {
                linefullname.LineColor = Color.Red;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            lineEmail.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                lineEmail.LineColor = Color.Gray;
            }
            else
            {
                lineEmail.LineColor = Color.Red;
            }
        }

        private void txtaddress_Enter(object sender, EventArgs e)
        {
            lineAddress.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text != "")
            {
                lineAddress.LineColor = Color.Gray;
            }
            else
            {
                lineAddress.LineColor = Color.Red;
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            lineID.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                lineID.LineColor = Color.Gray;
            }
            else
            {
                lineID.LineColor = Color.Red;
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            linePhone.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text != "")
            {
                linePhone.LineColor = Color.Gray;
            }
            else
            {
                linePhone.LineColor = Color.Red;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            LineUsername.LineColor = Color.FromArgb(93, 148, 227);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
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
            txtPass.Text = "";
            linePass.LineColor = Color.FromArgb(93, 148, 227);
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

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
