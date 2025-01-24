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
    public partial class UC_P_ViewMedicines : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;


        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnDelete.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnDelete.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            ds = fn.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {

            query = "select * from medic where mname like '" + txtMedicineName.Text + "%' ";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        String medicineID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if(MessageBox.Show("Are You Sure","Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query="delete from medic where mid= '"+medicineID+"'";
                fn.setData(query,"Medicine Record Deleted ");
                UC_P_ViewMedicines_Load(this,null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicines_Load(this, null);
        }
    }
}
