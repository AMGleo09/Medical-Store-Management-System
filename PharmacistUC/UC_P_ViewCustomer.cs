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
    public partial class UC_P_ViewCustomer : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_ViewCustomer()
        {
            InitializeComponent();
        }

        private void UC_P_ViewCustomer_Load(object sender, EventArgs e)
        {

            query = "select * from cust";
            ds = fn.getData(query);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewCustomer_Load(this, null);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cust where cname like '" + txtCustomerName.Text + "%' ";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
