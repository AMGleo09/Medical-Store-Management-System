using DGVPrinterHelper;
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
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        DataTable cartTable; // DataTable for storing cart items


        public UC_P_SellMedicine()
        {
            InitializeComponent();
            InitializeCartTable(); // Initialize the DataTable
        }

        private void InitializeCartTable()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("Medicine ID", typeof(string));
            cartTable.Columns.Add("Medicine Name", typeof(string));
            cartTable.Columns.Add("Expire Date", typeof(string));
            cartTable.Columns.Add("Price Per Unit", typeof(string));
            cartTable.Columns.Add("Number of Units", typeof(string));
            cartTable.Columns.Add("Total Price", typeof(string));

            dataGridView1.DataSource = cartTable; // Bind the DataTable to the DataGridView
        }






        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnaddtocart.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnaddtocart.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnaddtocart.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnaddtocart.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            btnRemove.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnRemove.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnRemove.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnPurchaseAndPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPurchaseAndPrint.BackColor = ColorTranslator.FromHtml("#B14F45");
            btnPurchaseAndPrint.ForeColor = ColorTranslator.FromHtml("#FFF1F0");
        }

        private void btnPurchaseAndPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPurchaseAndPrint.BackColor = ColorTranslator.FromHtml("211, 125, 112");
            btnPurchaseAndPrint.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dateTimePicker1TodaysDate.Value = DateTime.Now; 


            query = "select mname from medic where CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) >= CONVERT(DATE, GETDATE(),106) and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this,null);
        }

        private void txtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            query = "select mname from medic where mname like '" + txtSearchMedicine.Text + "%' and CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) >= CONVERT(DATE, GETDATE(),106) and quantity > '0' ";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumberOfUnits.Clear();

            String name = listBox1.GetItemText(listBox1.SelectedItem);

            txtMedicineName.Text = name;

            query = "select mid,EXPdate,perunit from medic where mname='" + name + "'";
            ds = fn.getData(query);

            txtMedicineId.Text = ds.Tables[0].Rows[0][0].ToString(); 
            dateTimePicker2ExpireDate.Text = ds.Tables[0].Rows[0][1].ToString(); 
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString(); 

        }

        private void txtNumberOfUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNumberOfUnits.Text != "")
            {
                Int64 unitprice =  Int64.Parse(txtPricePerUnit.Text);
                Int64 noofunitprice =  Int64.Parse(txtNumberOfUnits.Text);

                Int64 totalprice = unitprice * noofunitprice;

                txtTotalPrice.Text = totalprice.ToString(); 
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalamount = 0;
        protected Int64 quantity, newquantity;

       

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            //if (txtMedicineId.Text != "")
            //{

            //    query = " select quantity from medic where mid='" + txtMedicineId.Text + "'";
            //    ds = fn.getData(query);

            //    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            //    newquantity = quantity - Int64.Parse(txtNumberOfUnits.Text);

            //    //if (newquantity >= 0)
            //    if (newquantity >= 0)
            //    {
            //        n = dataGridView1.Rows.Add();

            //        dataGridView1.Rows[n].Cells[0].Value = txtMedicineId.Text;
            //        dataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
            //        dataGridView1.Rows[n].Cells[2].Value = dateTimePicker2ExpireDate.Text;
            //        dataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
            //        dataGridView1.Rows[n].Cells[4].Value = txtNumberOfUnits.Text;
            //        dataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;


            //        totalamount = totalamount + int.Parse(txtTotalPrice.Text);

            //        labtotalprice.Text = "Rs. " + totalamount.ToString();


            //        query = "update medic set  quantity ='" + newquantity + "' where mid='" + txtMedicineId.Text + "' ";
            //        fn.setData(query, "Medicine Added.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Medicine Out Of Stock.\n only " + quantity + " Left", "Warning !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //    clearall();
            //    UC_P_SellMedicine_Load(this, null);

            //}
            //else
            //{
            //    MessageBox.Show("Select Medicine First","Information",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            //}








            if (txtMedicineId.Text != "" && txtNumberOfUnits.Text!="" && txtCustomerNmae.Text!="")
            {
                query = "select quantity from medic where mid='" + txtMedicineId.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(txtNumberOfUnits.Text);

                if (newquantity >= 0)
                {
                    // Add a new row to the DataTable instead of directly to the DataGridView
                    DataRow row = cartTable.NewRow();
                    row["Medicine ID"] = txtMedicineId.Text;
                    row["Medicine Name"] = txtMedicineName.Text;
                    row["Expire Date"] = dateTimePicker2ExpireDate.Text;
                    row["Price Per Unit"] = txtPricePerUnit.Text;
                    row["Number of Units"] = txtNumberOfUnits.Text;
                    row["Total Price"] = txtTotalPrice.Text;

                    cartTable.Rows.Add(row); // Add the row to the DataTable

                    totalamount += int.Parse(txtTotalPrice.Text);
                    labtotalprice.Text = "Rs. " + totalamount.ToString();

                    query = "update medic set quantity ='" + newquantity + "' where mid='" + txtMedicineId.Text + "'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine Out Of Stock.\nOnly " + quantity + " left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                clearall();     
                UC_P_SellMedicine_Load(this, null);
               
            }
            else
            {
                MessageBox.Show("Select Medicine First And Fill All Details ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }








        }

        int valueAmount;
        String valueid;
        protected Int64 noofunit; 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueid= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noofunit = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());


            }
            catch(Exception) 
            {
                
            }


        }

      

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if (valueid != null)
            //{
            //    try
            //    {
            //        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            //    }
            //    catch 
            //    {

            //    }
            //    finally
            //    {
            //        query = "select quantity from medic where mid = '" + valueid + "'";
            //        ds=fn.getData(query);

            //        quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            //        newquantity = quantity + noofunit;


            //        query = "update medic set quantity ='" + newquantity + "' where mid = '" + valueid + "' ";
            //        fn.setData(query, "Medicine Removed From The Cart");
            //        totalamount = totalamount - valueAmount;

            //        labtotalprice.Text = "Rs. " + totalamount.ToString();


            //     }
            //    UC_P_SellMedicine_Load(this,null);
            //}









            //if (valueid != null)
            //{
            //    try
            //    {
            //        DataRow[] rows = cartTable.Select("Medicine ID = '" + valueid + "'");
            //        if (rows.Length > 0)
            //        {
            //            cartTable.Rows.Remove(rows[0]);
            //        }
            //    }
            //    catch
            //    {
            //        // Handle exceptions if necessary
            //    }
            //    finally
            //    {
            //        query = "select quantity from medic where mid = '" + valueid + "'";
            //        ds = fn.getData(query);

            //        quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            //        newquantity = quantity + noofunit;

            //        query = "update medic set quantity ='" + newquantity + "' where mid = '" + valueid + "'";
            //        fn.setData(query, "Medicine Removed From The Cart");

            //        totalamount -= valueAmount;
            //        labtotalprice.Text = "Rs. " + totalamount.ToString();
            //    }
            //    UC_P_SellMedicine_Load(this, null);

            //}



            if (!string.IsNullOrEmpty(valueid))
            {
                try
                {
                    // Use brackets around the column name to avoid syntax issues
                    string filterExpression = $"[Medicine ID] = '{valueid.Replace("'", "''")}'";

                    // Find and remove the row from the DataTable
                    DataRow[] rows = cartTable.Select(filterExpression);
                    if (rows.Length > 0)
                    {
                        // Adjust the total amount before removing the row
                        totalamount -= int.Parse(rows[0]["Total Price"].ToString());
                        labtotalprice.Text = "Rs. " + totalamount.ToString();

                        // Remove the row from the DataTable
                        cartTable.Rows.Remove(rows[0]);
                    }

                    // Update the database to reflect the restored quantity
                    query = "select quantity from medic where mid = '" + valueid + "'";
                    ds = fn.getData(query);

                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noofunit;

                    query = "update medic set quantity ='" + newquantity + "' where mid = '" + valueid + "'";
                    fn.setData(query, "Medicine Removed From The Cart");

                    // Rebind the DataGridView to the updated DataTable
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = cartTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while removing the item: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }








        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerNmae.Clear();
            txtNumberOfUnits.Clear();
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            txtSearchMedicine.Clear();
            dateTimePicker2ExpireDate.ResetText();

            cartTable.Clear();

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

        private void btnPurchaseAndPrint_Click(object sender, EventArgs e)
        {



            //String cnam = txtCustomerNmae.Text;
            //String dofpresent = dateTimePicker1TodaysDate.Text;

            //String item="";
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    item += dataGridView1.Rows[i].Cells[1].Value.ToString();
            //}

            //String items = item;



            //String ppu = "";
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    ppu += dataGridView1.Rows[i].Cells["Price Per Unit"].Value.ToString() + " ";
            //}

            //String PricePerUnit = ppu;



            //String noofunitsss = "";
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    noofunitsss += dataGridView1.Rows[i].Cells["No of Units"].Value.ToString() + " ";
            //}

            //String numberofitem = noofunitsss;




            //Int64 totpriceee = totalamount;

            // Retrieve customer name and date
            String cnam = txtCustomerNmae.Text;
            String dofpresent = dateTimePicker1TodaysDate.Text;

            String item = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Ensure that the cell is not null before converting it to string
                var cellValue = dataGridView1.Rows[i].Cells[1].Value;
                if (cellValue != null)
                {
                    item += cellValue.ToString() + ", ";
                }
            }
            String items = item.Trim(); // Remove any trailing spaces

            String ppu = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Ensure that the column name matches exactly
                if (dataGridView1.Rows[i].Cells[3] != null)
                {
                    var cellValue = dataGridView1.Rows[i].Cells[3].Value;
                    if (cellValue != null)
                    {
                        ppu += cellValue.ToString() + ", ";
                    }
                }
            }
            String PricePerUnit = ppu.Trim(); // Remove any trailing spaces

            String noofunitsss = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // Ensure that the column name matches exactly
                if (dataGridView1.Rows[i].Cells[4] != null)
                {
                    var cellValue = dataGridView1.Rows[i].Cells[4].Value;
                    if (cellValue != null)
                    {
                        noofunitsss += cellValue.ToString() + ", ";
                    }
                }
            }
            String numberofitem = noofunitsss.Trim(); // Remove any trailing spaces

            // Ensure totalamount is initialized
            Int64 totpriceee = totalamount; // Ensure 'totalamount' is not null and is assigned a value









            query = "insert into cust(cname,dop,items,priceperunit,numberofitems,totalprice) values('" + cnam + "','" + dofpresent + "', '" + items + "' ,'" + PricePerUnit + "', '" + numberofitem + "'," + totpriceee + ")";
            fn.setData(query, "Customer Details Added.");

           







            DGVPrinter print = new DGVPrinter();

            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitle = String.Format(txtCustomerNmae.Text);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;

            print.HeaderCellAlignment = StringAlignment.Near;

            print.Footer = "Total Payable Amount : "+labtotalprice.Text;
            print.FooterSpacing = 15;

            print.PrintDataGridView(dataGridView1);

            //print.PrintPreviewDataGridView(dataGridView1);















            txtCustomerNmae.Clear();
            totalamount = 0;
            labtotalprice.Text = "Rs. 00";
            //dataGridView1.DataSource = 0;
            cartTable.Clear();
            UC_P_SellMedicine_Load(this, null);
            
        }



        private void clearall()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            dateTimePicker2ExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNumberOfUnits.Clear();
        }

        


    }
}
