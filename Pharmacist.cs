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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnDashboard.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnDashboard_MouseLeave_1(object sender, EventArgs e)
        {
            btnDashboard.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnDashboard.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnAddMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnAddMedicine.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnAddMedicine.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnAddMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnAddMedicine.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnAddMedicine.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnViewMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnViewMedicine.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnViewMedicine.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnViewMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnViewMedicine.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnViewMedicine.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnModifyMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnModifyMedicine.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnModifyMedicine.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnModifyMedicine_MouseLeave(object sender, EventArgs e)
        {
            btnModifyMedicine.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnModifyMedicine.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnMedValidationCheck_MouseEnter(object sender, EventArgs e)
        {
            btnMedValidationCheck.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnMedValidationCheck.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnMedValidationCheck_MouseLeave(object sender, EventArgs e)
        {
            btnMedValidationCheck.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnMedValidationCheck.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnSell_MouseEnter(object sender, EventArgs e)
        {
            btnSell.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnSell.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnSell_MouseLeave(object sender, EventArgs e)
        {
            btnSell.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnSell.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnLogout.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnLogout.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();    
        }

        private void uC_P_Dashboard1_Load(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void uC_P_AddMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {

            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicines1.Visible = false;
            uC_P_UpdateMedicine1.Visible=false;
            uC_P_SellMedicine1.Visible = false;
            uC_P_ViewCustomer1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;

            btnDashboard.PerformClick();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicines1.Visible = true;
            uC_P_ViewMedicines1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible=true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnMedValidationCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible=true;
            uC_P_MedicineValidityCheck1.BringToFront();

        }

        private void btnViewCustomers_MouseEnter(object sender, EventArgs e)
        {
            btnViewCustomers.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnViewCustomers.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnViewCustomers_MouseLeave(object sender, EventArgs e)
        {
            btnViewCustomers.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnViewCustomers.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            uC_P_ViewCustomer1.Visible = true;
            uC_P_ViewCustomer1.BringToFront();
        }
    }
}
