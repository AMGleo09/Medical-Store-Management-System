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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnAdd.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnAdd.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMedicineId.Text!="" && txtMedicineName.Text!="" && txtMedicineNumber.Text!="" && txtQuantity.Text!="" && txtQuantity.Text != "")
            {
                String mid = txtMedicineId.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNumber.Text;
                String mdate = dateTimePicker1Mgfdate.Text;
                String edate = dateTimePicker2ExpireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic(mid,mname,mnumber,MFGdate,EXPdate,quantity,perunit) values('"+mid+"','"+mname+ "','"+mnumber+ "','"+mdate+ "','"+edate+"',"+quantity+","+perunit+")";

                fn.setData(query,"Medicine Added To Database.");
                clearall();
            }
            else
            {

                MessageBox.Show("Enter All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            labelMedicineId.Visible = false;
            pbMedicineId.ImageLocation = @"";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearall();

            pbMedicineId.ImageLocation = @"";
            labelMedicineId.Visible=false;
        }

        public void clearall()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            dateTimePicker1Mgfdate.ResetText();
            dateTimePicker2ExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtQuantity.Clear();
        }

        private void txtMedicineId_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mid = '" + txtMedicineId.Text + "'";
             ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pbMedicineId.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\yes.png";
                labelMedicineId.Visible = false;
            }
            else
            {
                pbMedicineId.ImageLocation = @"E:\Users\anike\source\repos\1 all projects\Medical Shop Management System\Medical Management System Icons\Pharmacy Management System in C#\no.png";
                labelMedicineId.Visible = true;
                labelMedicineId.Text = "Medicine Id Already Exists";
                labelMedicineId.ForeColor = Color.Red;
            }
        }
    }
}
