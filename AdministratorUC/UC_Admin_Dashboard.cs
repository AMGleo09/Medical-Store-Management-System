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
    public partial class UC_Admin_Dashboard : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;


        public UC_Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='Administrator'";
            ds = fn.getData(query);
            setLabel(ds, labAdmin);

            query = "select count(userRole) from users where userRole='Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, labPharmacist);
            
            query = "select count(cname) from cust";
            ds = fn.getData(query);
            setLabel(ds, labCustomer);

            
        }

        private void setLabel(DataSet ds,Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Admin_Dashboard_Load(this, null); 
        }
    }
}
