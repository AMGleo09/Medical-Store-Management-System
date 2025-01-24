using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Shop_Management_System.AdministratorUC
{
    public partial class UC_Admin_AddUser : UserControl
    {

        function fn = new function();
        String query;

        public UC_Admin_AddUser()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UC_Admin_AddUser_Load(object sender, EventArgs e)
        {
            //label10.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            txtMobilenumber.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            cmbUserrole.SelectedIndex = -1;
            dateTimePicker1.ResetText();

            pbUsername.ImageLocation = @"";
            labUsername.Visible = false;

            pbEmail.ImageLocation = @"";
            labEmail.Visible = false;

            labPassword.Visible = false;
            pbPassword.ImageLocation = @"";
            
            labMobile.Visible = false;
            pbMobile.ImageLocation = @"";


        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
           
            
            
            
            


            if (cmbUserrole.Text != "" && txtName.Text != "" && dateTimePicker1.Text != "null" && txtMobilenumber.Text != "" && txtemail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")

            {

                String role = cmbUserrole.Text;
                String name = txtName.Text;
                String dob = dateTimePicker1.Text;
                Int64 mobile = Int64.Parse(txtMobilenumber.Text);
                String mail = txtemail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;


                try
                {
                    query = "insert into users(userRole,name,dob,mobile,email,username,pass) values('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + mail + "','" + username + "','" + pass + "')";
                    fn.setData(query, "Sign up Succesful");
                }
                catch (Exception)
                {
                    MessageBox.Show("Username Already Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                txtemail.Clear();
                txtMobilenumber.Clear();
                txtName.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
                cmbUserrole.SelectedIndex = -1;
                dateTimePicker1.ResetText();

                pbUsername.ImageLocation = @"";
                labUsername.Visible = false;

                pbEmail.ImageLocation = @"";
                labEmail.Visible = false;

                labPassword.Visible = false;
                pbPassword.ImageLocation = @"";

                labMobile.Visible = false;
                pbMobile.ImageLocation = @"";

            }
            else
            {
                MessageBox.Show("Enter All Details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pbUsername.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\yes.png";
                labUsername.Visible= false;
            }
            else
            {
                pbUsername.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\no.png";
                labUsername.Visible = true;
                labUsername.Text = "User Already Exists";
                labUsername.ForeColor = Color.Red;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (txtemail.Text.Length < 2 || !txtemail.Text.Contains(".") || txtemail.Text.Split('.').Length != 2 || txtemail.Text.EndsWith(".") || txtemail.Text.StartsWith("."))
            {
                pbEmail.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\no.png";
                labEmail.Visible = true;
                labEmail.Text = "Invalid Email";
                labEmail.ForeColor = Color.Red;
            }
            else
            {
                pbEmail.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\yes.png";
                labEmail.Visible= false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length > 8)
            {
                pbPassword.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\yes.png";
                labPassword.Visible = false;
            }
            else
            {
                pbPassword.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\no.png";
                labPassword.Visible = true;
                labPassword.Text = "Password Must Be Greater Than 8 Digits";
                labPassword.ForeColor = Color.Red;
            }
        }

        private void txtMobilenumber_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(txtMobilenumber.Text, @"^[6-9]\d{9}$").Success)
            {
                pbMobile.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\yes.png";
                labMobile.Visible = false;
            }
            else
            {
                pbMobile.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\no.png";
                labMobile.Visible = true;
                labMobile.Text = "Enter Correct Mobile Number(10 digits Indian number)";
                labMobile.ForeColor = Color.Red;
            }
              

        }

        private void btnSignup_MouseEnter(object sender, EventArgs e)
        {
            btnSignup.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnSignup_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }
    }
}
