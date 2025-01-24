namespace Medical_Shop_Management_System
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.pnlleft = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnViewuser = new System.Windows.Forms.Button();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlright = new System.Windows.Forms.Panel();
            this.uC_Admin_Profile1 = new Medical_Shop_Management_System.AdministratorUC.UC_Admin_Profile();
            this.uC_Admin_Viewuser1 = new Medical_Shop_Management_System.AdministratorUC.UC_Admin_Viewuser();
            this.uC_Admin_AddUser1 = new Medical_Shop_Management_System.AdministratorUC.UC_Admin_AddUser();
            this.uC_Admin_Dashboard1 = new Medical_Shop_Management_System.AdministratorUC.UC_Admin_Dashboard();
            this.pnlleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlright.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.pnlleft.Controls.Add(this.usernameLabel);
            this.pnlleft.Controls.Add(this.btnLogout);
            this.pnlleft.Controls.Add(this.btnProfile);
            this.pnlleft.Controls.Add(this.btnViewuser);
            this.pnlleft.Controls.Add(this.btnAdduser);
            this.pnlleft.Controls.Add(this.btnDashboard);
            this.pnlleft.Controls.Add(this.label1);
            this.pnlleft.Controls.Add(this.pictureBox1);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(423, 1080);
            this.pnlleft.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.usernameLabel.Location = new System.Drawing.Point(140, 984);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(123, 52);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(77, 812);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 80);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(77, 710);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(280, 80);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // btnViewuser
            // 
            this.btnViewuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnViewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewuser.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewuser.ForeColor = System.Drawing.Color.White;
            this.btnViewuser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewuser.Image")));
            this.btnViewuser.Location = new System.Drawing.Point(77, 609);
            this.btnViewuser.Name = "btnViewuser";
            this.btnViewuser.Size = new System.Drawing.Size(280, 80);
            this.btnViewuser.TabIndex = 4;
            this.btnViewuser.Text = "View Users";
            this.btnViewuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewuser.UseVisualStyleBackColor = false;
            this.btnViewuser.Click += new System.EventHandler(this.btnViewuser_Click);
            this.btnViewuser.MouseEnter += new System.EventHandler(this.btnViewuser_MouseEnter);
            this.btnViewuser.MouseLeave += new System.EventHandler(this.btnViewuser_MouseLeave);
            // 
            // btnAdduser
            // 
            this.btnAdduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdduser.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdduser.Image")));
            this.btnAdduser.Location = new System.Drawing.Point(77, 509);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(280, 80);
            this.btnAdduser.TabIndex = 3;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdduser.UseVisualStyleBackColor = false;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            this.btnAdduser.MouseEnter += new System.EventHandler(this.btnAdduser_MouseEnter);
            this.btnAdduser.MouseLeave += new System.EventHandler(this.btnAdduser_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(77, 410);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(280, 80);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(33, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlright
            // 
            this.pnlright.Controls.Add(this.uC_Admin_Profile1);
            this.pnlright.Controls.Add(this.uC_Admin_Viewuser1);
            this.pnlright.Controls.Add(this.uC_Admin_AddUser1);
            this.pnlright.Controls.Add(this.uC_Admin_Dashboard1);
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlright.Location = new System.Drawing.Point(423, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(1497, 1080);
            this.pnlright.TabIndex = 1;
            // 
            // uC_Admin_Profile1
            // 
            this.uC_Admin_Profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.uC_Admin_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_Admin_Profile1.Name = "uC_Admin_Profile1";
            this.uC_Admin_Profile1.Size = new System.Drawing.Size(1513, 1080);
            this.uC_Admin_Profile1.TabIndex = 3;
            // 
            // uC_Admin_Viewuser1
            // 
            this.uC_Admin_Viewuser1.Location = new System.Drawing.Point(0, 0);
            this.uC_Admin_Viewuser1.Name = "uC_Admin_Viewuser1";
            this.uC_Admin_Viewuser1.Size = new System.Drawing.Size(1513, 1080);
            this.uC_Admin_Viewuser1.TabIndex = 2;
            // 
            // uC_Admin_AddUser1
            // 
            this.uC_Admin_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_Admin_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_Admin_AddUser1.Name = "uC_Admin_AddUser1";
            this.uC_Admin_AddUser1.Size = new System.Drawing.Size(1513, 1080);
            this.uC_Admin_AddUser1.TabIndex = 1;
            // 
            // uC_Admin_Dashboard1
            // 
            this.uC_Admin_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Admin_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_Admin_Dashboard1.Name = "uC_Admin_Dashboard1";
            this.uC_Admin_Dashboard1.Size = new System.Drawing.Size(1497, 1080);
            this.uC_Admin_Dashboard1.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.pnlleft.ResumeLayout(false);
            this.pnlleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlright.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnViewuser;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.Label usernameLabel;
        private AdministratorUC.UC_Admin_Dashboard uC_Admin_Dashboard1;
        private AdministratorUC.UC_Admin_AddUser uC_Admin_AddUser1;
        private AdministratorUC.UC_Admin_Viewuser uC_Admin_Viewuser1;
        private AdministratorUC.UC_Admin_Profile uC_Admin_Profile1;
    }
}