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
    public partial class UC_P_UpdateMedicine : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;


        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnSearch.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnSearch.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnUpdate.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnUpdate.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnReset.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnReset.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtMedicineId.Text != "")
            {
                query = "select * from medic where mid='" + txtMedicineId.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    dateTimePicker1Mgfdate.Text = ds.Tables[0].Rows[0][4].ToString();
                    dateTimePicker2ExpireDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                    

                }
                else
                {
                    MessageBox.Show("No Medicine With ID= " + txtMedicineId.Text + " Exits","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            else
            {
                ClearAll();
            }

        }

        public void ClearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            dateTimePicker1Mgfdate.ResetText();
            dateTimePicker2ExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtQuantity.Clear();

            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMedicineName.Text;
            String mnumber = txtMedicineNumber.Text;
            String mdate = dateTimePicker1Mgfdate.Text;
            String edate = dateTimePicker2ExpireDate.Text;
            Int64 quantity = Int64.Parse(txtQuantity.Text);
            Int64 addquantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addquantity;

            query = "update medic set mname='" + mname + "',mnumber='" + mnumber + "',MFGdate='" + mdate + "',EXPdate='" + edate + "',quantity=" + totalQuantity + ",perunit="+unitprice+" where mid='"+txtMedicineId.Text+"'";
            fn.setData(query, "Medicine Details Updated.");
        }
    }
}
