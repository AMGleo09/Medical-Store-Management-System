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
    public partial class UC_Admin_Viewuser : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        String currentuser="";


        public UC_Admin_Viewuser()
        {
            InitializeComponent();
        }


        public string ID
        {
            set { currentuser = value; }
        }


        private void UC_Admin_Viewuser_Load(object sender, EventArgs e)
        {

            query = "select * from users";
            ds = fn.getData(query);

            dataGridView1.DataSource = ds.Tables[0];


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '"+txtUsername.Text+"%'"; //a% all the values which contains a...

            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String userName; 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                userName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch 
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you Sure?","Delete Confimation..!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes) {
                if (currentuser != userName)
                {
                    query="delete from users where username='"+userName+"'";
                    fn.setData(query, "User Record Deleted.");
                    UC_Admin_Viewuser_Load(this, null);

                }
                else
                {
                    MessageBox.Show("You are trying to delete \n your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Admin_Viewuser_Load(this, null);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = ColorTranslator.FromHtml("56, 192, 60");
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = ColorTranslator.FromHtml("56, 142, 60");
        }
    }
}
