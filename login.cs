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
    public partial class login : Form
    {

        function fn = new function();
        String query;
        DataSet ds;


        public login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            query = "select * from users";

             ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsername.Text=="root" && txtPassword.Text == "root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username ='" + txtUsername.Text + "' and pass='"+txtPassword.Text+"'";
                ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count!= 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();

                    if(role== "Administrator")
                    {
                        Administrator admin = new Administrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role== "Pharmacist")
                    {
                        Pharmacist pharma =new Pharmacist();
                        pharma.Show();
                        this.Hide();
                    }

                    //else if (role == "Customer")
                    //{
                    //    Customer cust = new Customer();
                    //    cust.Show();
                    //    this.Hide();
                    //}                   


                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
            
            
                     
            
            
            
            
            
            
            
            
            
            
            //if( txtUsername.Text == "aniket" && txtPassword.Text == "aniket123")
            //{
            //    Administrator am = new Administrator();
            //    am.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Username Or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnSignin_MouseLeave(object sender, EventArgs e)
        {
            btnSignin.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }

        private void btnSignin_MouseEnter(object sender, EventArgs e)
        {
            btnSignin.BackColor = ColorTranslator.FromHtml("56, 192, 60");
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
