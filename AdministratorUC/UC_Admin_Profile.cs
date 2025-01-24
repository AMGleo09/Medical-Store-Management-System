using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Shop_Management_System.AdministratorUC
{
    public partial class UC_Admin_Profile : UserControl
    {
        function fn = new function();
        DataSet ds;
        String query;


        public UC_Admin_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { viewuserLabel.Text = value; }
        }

        private void UC_Admin_Profile_Load(object sender, EventArgs e)
        {

        }

        private void UC_Admin_Profile_Enter(object sender, EventArgs e)
        {

            query = "select * from users where username='" + viewuserLabel.Text + "'";
            ds = fn.getData(query);

            cmbUserrole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Admin_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = cmbUserrole.Text;
            String name = txtname.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = viewuserLabel.Text;
            String pass = txtPass.Text;

            query = "update users set userRole='" + role + "',name='" + name + "',dob='" + dob + "',mobile=" + mobile + ",email='" + email + "',pass='" + pass + "'  where username='"+username+"'";
            fn.setData(query, "Profile Updated Succesfully.");

        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = ColorTranslator.FromHtml("56, 142, 60");
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
