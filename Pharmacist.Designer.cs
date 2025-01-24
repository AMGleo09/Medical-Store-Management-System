namespace Medical_Shop_Management_System
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.pannelleft = new System.Windows.Forms.Panel();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnMedValidationCheck = new System.Windows.Forms.Button();
            this.btnModifyMedicine = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pannelright = new System.Windows.Forms.Panel();
            this.uC_P_SellMedicine1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_SellMedicine();
            this.uC_P_MedicineValidityCheck1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_ViewMedicines1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_Dashboard();
            this.uC_P_ViewCustomer1 = new Medical_Shop_Management_System.PharmacistUC.UC_P_ViewCustomer();
            this.pannelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pannelright.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelleft
            // 
            this.pannelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.pannelleft.Controls.Add(this.btnViewCustomers);
            this.pannelleft.Controls.Add(this.btnLogout);
            this.pannelleft.Controls.Add(this.btnSell);
            this.pannelleft.Controls.Add(this.btnMedValidationCheck);
            this.pannelleft.Controls.Add(this.btnModifyMedicine);
            this.pannelleft.Controls.Add(this.btnViewMedicine);
            this.pannelleft.Controls.Add(this.btnAddMedicine);
            this.pannelleft.Controls.Add(this.btnDashboard);
            this.pannelleft.Controls.Add(this.label1);
            this.pannelleft.Controls.Add(this.pictureBox1);
            this.pannelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pannelleft.Location = new System.Drawing.Point(0, 0);
            this.pannelleft.Name = "pannelleft";
            this.pannelleft.Size = new System.Drawing.Size(423, 1080);
            this.pannelleft.TabIndex = 0;
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnViewCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCustomers.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCustomers.Image")));
            this.btnViewCustomers.Location = new System.Drawing.Point(28, 882);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(358, 80);
            this.btnViewCustomers.TabIndex = 11;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            this.btnViewCustomers.MouseEnter += new System.EventHandler(this.btnViewCustomers_MouseEnter);
            this.btnViewCustomers.MouseLeave += new System.EventHandler(this.btnViewCustomers_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(28, 979);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(358, 80);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.Location = new System.Drawing.Point(28, 779);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(358, 80);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Sell Medicine";
            this.btnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            this.btnSell.MouseEnter += new System.EventHandler(this.btnSell_MouseEnter);
            this.btnSell.MouseLeave += new System.EventHandler(this.btnSell_MouseLeave);
            // 
            // btnMedValidationCheck
            // 
            this.btnMedValidationCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnMedValidationCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedValidationCheck.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedValidationCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedValidationCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnMedValidationCheck.Image")));
            this.btnMedValidationCheck.Location = new System.Drawing.Point(28, 679);
            this.btnMedValidationCheck.Name = "btnMedValidationCheck";
            this.btnMedValidationCheck.Size = new System.Drawing.Size(358, 80);
            this.btnMedValidationCheck.TabIndex = 10;
            this.btnMedValidationCheck.Text = "Medicine Validity Check";
            this.btnMedValidationCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedValidationCheck.UseVisualStyleBackColor = false;
            this.btnMedValidationCheck.Click += new System.EventHandler(this.btnMedValidationCheck_Click);
            this.btnMedValidationCheck.MouseEnter += new System.EventHandler(this.btnMedValidationCheck_MouseEnter);
            this.btnMedValidationCheck.MouseLeave += new System.EventHandler(this.btnMedValidationCheck_MouseLeave);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnModifyMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyMedicine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.Location = new System.Drawing.Point(28, 581);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(358, 80);
            this.btnModifyMedicine.TabIndex = 10;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifyMedicine.UseVisualStyleBackColor = false;
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            this.btnModifyMedicine.MouseEnter += new System.EventHandler(this.btnModifyMedicine_MouseEnter);
            this.btnModifyMedicine.MouseLeave += new System.EventHandler(this.btnModifyMedicine_MouseLeave);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnViewMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.Location = new System.Drawing.Point(28, 480);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(358, 80);
            this.btnViewMedicine.TabIndex = 9;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewMedicine.UseVisualStyleBackColor = false;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            this.btnViewMedicine.MouseEnter += new System.EventHandler(this.btnViewMedicine_MouseEnter);
            this.btnViewMedicine.MouseLeave += new System.EventHandler(this.btnViewMedicine_MouseLeave);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.Location = new System.Drawing.Point(28, 380);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(358, 80);
            this.btnAddMedicine.TabIndex = 8;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            this.btnAddMedicine.MouseEnter += new System.EventHandler(this.btnAddMedicine_MouseEnter);
            this.btnAddMedicine.MouseLeave += new System.EventHandler(this.btnAddMedicine_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(28, 282);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(358, 80);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(16, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHARMACIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pannelright
            // 
            this.pannelright.Controls.Add(this.uC_P_ViewCustomer1);
            this.pannelright.Controls.Add(this.uC_P_SellMedicine1);
            this.pannelright.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.pannelright.Controls.Add(this.uC_P_UpdateMedicine1);
            this.pannelright.Controls.Add(this.uC_P_ViewMedicines1);
            this.pannelright.Controls.Add(this.uC_P_AddMedicine1);
            this.pannelright.Controls.Add(this.uC_P_Dashboard1);
            this.pannelright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelright.Location = new System.Drawing.Point(423, 0);
            this.pannelright.Name = "pannelright";
            this.pannelright.Size = new System.Drawing.Size(1497, 1080);
            this.pannelright.TabIndex = 1;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_SellMedicine1.TabIndex = 5;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_UpdateMedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_ViewMedicines1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_AddMedicine1.TabIndex = 1;
            this.uC_P_AddMedicine1.Load += new System.EventHandler(this.uC_P_AddMedicine1_Load);
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(-3, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // uC_P_ViewCustomer1
            // 
            this.uC_P_ViewCustomer1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ViewCustomer1.Name = "uC_P_ViewCustomer1";
            this.uC_P_ViewCustomer1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_P_ViewCustomer1.TabIndex = 6;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pannelright);
            this.Controls.Add(this.pannelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.pannelleft.ResumeLayout(false);
            this.pannelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pannelright.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pannelleft;
        private System.Windows.Forms.Panel pannelright;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnMedValidationCheck;
        private System.Windows.Forms.Button btnModifyMedicine;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnDashboard;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private System.Windows.Forms.Button btnViewCustomers;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
        private PharmacistUC.UC_P_ViewCustomer uC_P_ViewCustomer1;
    }
}