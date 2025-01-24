namespace Medical_Shop_Management_System.PharmacistUC
{
    partial class UC_P_SellMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_SellMedicine));
            this.btnSync = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchMedicine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfUnits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker2ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txtCustomerNmae = new System.Windows.Forms.TextBox();
            this.dateTimePicker1TodaysDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPurchaseAndPrint = new System.Windows.Forms.Button();
            this.labtotalprice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.Location = new System.Drawing.Point(453, 40);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 71);
            this.btnSync.TabIndex = 9;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 68);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sell Medicines";
            // 
            // txtSearchMedicine
            // 
            this.txtSearchMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtSearchMedicine.Location = new System.Drawing.Point(24, 213);
            this.txtSearchMedicine.Multiline = true;
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.Size = new System.Drawing.Size(353, 44);
            this.txtSearchMedicine.TabIndex = 0;
            this.txtSearchMedicine.TextChanged += new System.EventHandler(this.txtSearchMedicine_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(123, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(24, 315);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 655);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtMedicineId.Location = new System.Drawing.Point(421, 213);
            this.txtMedicineId.Multiline = true;
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(455, 44);
            this.txtMedicineId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(415, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Medicine Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(415, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price Per Unit";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtPricePerUnit.Location = new System.Drawing.Point(421, 435);
            this.txtPricePerUnit.Multiline = true;
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(455, 44);
            this.txtPricePerUnit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(966, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Number Of Units";
            // 
            // txtNumberOfUnits
            // 
            this.txtNumberOfUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtNumberOfUnits.Location = new System.Drawing.Point(972, 435);
            this.txtNumberOfUnits.Multiline = true;
            this.txtNumberOfUnits.Name = "txtNumberOfUnits";
            this.txtNumberOfUnits.Size = new System.Drawing.Size(455, 44);
            this.txtNumberOfUnits.TabIndex = 4;
            this.txtNumberOfUnits.TextChanged += new System.EventHandler(this.txtNumberOfUnits_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(966, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtMedicineName.Location = new System.Drawing.Point(972, 213);
            this.txtMedicineName.Multiline = true;
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(455, 44);
            this.txtMedicineName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(966, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(972, 548);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(455, 44);
            this.txtTotalPrice.TabIndex = 23;
            // 
            // dateTimePicker2ExpireDate
            // 
            this.dateTimePicker2ExpireDate.Location = new System.Drawing.Point(421, 324);
            this.dateTimePicker2ExpireDate.Name = "dateTimePicker2ExpireDate";
            this.dateTimePicker2ExpireDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2ExpireDate.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label8.Location = new System.Drawing.Point(415, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "Expire Date";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lab.Location = new System.Drawing.Point(415, 495);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(211, 31);
            this.lab.TabIndex = 24;
            this.lab.Text = "Customer Name";
            // 
            // txtCustomerNmae
            // 
            this.txtCustomerNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNmae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txtCustomerNmae.Location = new System.Drawing.Point(421, 548);
            this.txtCustomerNmae.Multiline = true;
            this.txtCustomerNmae.Name = "txtCustomerNmae";
            this.txtCustomerNmae.Size = new System.Drawing.Size(455, 44);
            this.txtCustomerNmae.TabIndex = 5;
            // 
            // dateTimePicker1TodaysDate
            // 
            this.dateTimePicker1TodaysDate.Location = new System.Drawing.Point(972, 334);
            this.dateTimePicker1TodaysDate.Name = "dateTimePicker1TodaysDate";
            this.dateTimePicker1TodaysDate.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1TodaysDate.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label10.Location = new System.Drawing.Point(966, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 31);
            this.label10.TabIndex = 28;
            this.label10.Text = "Todays Date";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnaddtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddtocart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtocart.ForeColor = System.Drawing.Color.White;
            this.btnaddtocart.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtocart.Image")));
            this.btnaddtocart.Location = new System.Drawing.Point(1209, 608);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(218, 51);
            this.btnaddtocart.TabIndex = 6;
            this.btnaddtocart.Text = "Add To Cart";
            this.btnaddtocart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddtocart.UseVisualStyleBackColor = false;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            this.btnaddtocart.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnaddtocart.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 677);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1006, 309);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(421, 992);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(218, 74);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            // 
            // btnPurchaseAndPrint
            // 
            this.btnPurchaseAndPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnPurchaseAndPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchaseAndPrint.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseAndPrint.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseAndPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchaseAndPrint.Image")));
            this.btnPurchaseAndPrint.Location = new System.Drawing.Point(1143, 992);
            this.btnPurchaseAndPrint.Name = "btnPurchaseAndPrint";
            this.btnPurchaseAndPrint.Size = new System.Drawing.Size(284, 74);
            this.btnPurchaseAndPrint.TabIndex = 8;
            this.btnPurchaseAndPrint.Text = "Purchase And Print";
            this.btnPurchaseAndPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchaseAndPrint.UseVisualStyleBackColor = false;
            this.btnPurchaseAndPrint.Click += new System.EventHandler(this.btnPurchaseAndPrint_Click);
            this.btnPurchaseAndPrint.MouseEnter += new System.EventHandler(this.btnPurchaseAndPrint_MouseEnter);
            this.btnPurchaseAndPrint.MouseLeave += new System.EventHandler(this.btnPurchaseAndPrint_MouseLeave);
            // 
            // labtotalprice
            // 
            this.labtotalprice.AutoSize = true;
            this.labtotalprice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labtotalprice.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtotalprice.Location = new System.Drawing.Point(827, 1003);
            this.labtotalprice.Name = "labtotalprice";
            this.labtotalprice.Size = new System.Drawing.Size(121, 49);
            this.labtotalprice.TabIndex = 31;
            this.labtotalprice.Text = "Rs. 00";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(125)))), ((int)(((byte)(112)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(421, 608);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 51);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // UC_P_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labtotalprice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPurchaseAndPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.dateTimePicker1TodaysDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2ExpireDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerNmae);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumberOfUnits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedicineId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSearchMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_SellMedicine";
            this.Size = new System.Drawing.Size(1497, 1080);
            this.Load += new System.EventHandler(this.UC_P_SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker2ExpireDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtCustomerNmae;
        private System.Windows.Forms.DateTimePicker dateTimePicker1TodaysDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPurchaseAndPrint;
        private System.Windows.Forms.Label labtotalprice;
        private System.Windows.Forms.Button btnReset;
    }
}
