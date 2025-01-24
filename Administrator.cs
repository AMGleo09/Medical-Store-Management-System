using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Shop_Management_System
{
    public partial class Administrator : Form
    {
        String user = "";

        public Administrator()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return  user.ToString(); }
        }

        public Administrator( String username)
        {
            InitializeComponent();
            usernameLabel.Text = username;  
            user= username;
            uC_Admin_Viewuser1.ID = ID;
            uC_Admin_Profile1.ID = ID;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            login li = new login(); 
            li.Show();  
            this.Hide();
        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void guna2WinProgressIndicator1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Admin_Dashboard1.Visible = true;            
            uC_Admin_Dashboard1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Admin_Dashboard1.Visible=false;
            uC_Admin_AddUser1.Visible = false;
            uC_Admin_Viewuser1.Visible = false;
            uC_Admin_Profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uC_Admin_AddUser1.Visible = true;
            uC_Admin_AddUser1.BringToFront();
        }

        private void btnViewuser_Click(object sender, EventArgs e)
        {
            uC_Admin_Viewuser1.Visible = true;
            uC_Admin_Viewuser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Admin_Profile1.Visible = true;
            uC_Admin_Profile1.BringToFront();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }

        private void btnAdduser_MouseEnter(object sender, EventArgs e)
        {
            btnAdduser.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnAdduser_MouseLeave(object sender, EventArgs e)
        {
            btnAdduser.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }

        private void btnViewuser_MouseEnter(object sender, EventArgs e)
        {
            btnViewuser.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnViewuser_MouseLeave(object sender, EventArgs e)
        {
            btnViewuser.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }
    }
}
