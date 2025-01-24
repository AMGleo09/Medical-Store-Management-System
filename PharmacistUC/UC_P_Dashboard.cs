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
    public partial class UC_P_Dashboard : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;
        public UC_P_Dashboard()
        {
            InitializeComponent();
        }

        

        

        private void btnReload_MouseEnter_1(object sender, EventArgs e)
        {
            btnReload.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnReload.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnReload_MouseLeave(object sender, EventArgs e)
        {
            btnReload.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnReload.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadchart();
        }

        public void loadchart()
        {
            query = "select count(mname) from medic where CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) >= CONVERT(DATE, GETDATE(),106)";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", count);


            query = "select count(mname) from medic where CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) <= CONVERT(DATE, GETDATE(),106)";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);



        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicines"].Points.Clear();

            loadchart();
        }
    }
}
