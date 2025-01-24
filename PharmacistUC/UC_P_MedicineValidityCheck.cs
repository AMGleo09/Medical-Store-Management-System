using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Shop_Management_System.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;


        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            labCheck.Text = "";
            query = "select * from medic";

            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            labCheck.Text = "All Medicines";
            labCheck.ForeColor = ColorTranslator.FromHtml("255, 90, 90");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                query = "select * from medic where CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) >= CONVERT(DATE, GETDATE(),106)";
                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                labCheck.Text = "Valid Medicines";
                labCheck.ForeColor = Color.Green;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                query = "select * from medic where CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) <= CONVERT(DATE, GETDATE(),106)";

                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                labCheck.Text = "Expired Medicines";
                labCheck.ForeColor = Color.Red;
            }
            else if (comboBox1.SelectedIndex==2)
            {
                query = "select * from medic";

                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                labCheck.Text = "All Medicines";
                labCheck.ForeColor = ColorTranslator.FromHtml("255, 90, 90");
            }

        }
    }
}
