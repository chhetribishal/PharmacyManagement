
namespace PharmacyManagement
{
    partial class Adminstrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Profile1 = new PharmacyManagement.AdminstratorUC.UC_Profile();
            this.uC_ViewUsers1 = new PharmacyManagement.AdminstratorUC.UC_ViewUsers();
            this.uC_AddUser1 = new PharmacyManagement.AdminstratorUC.UC_AddUser();
            this.uC_Dashboard1 = new PharmacyManagement.AdminstratorUC.UC_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 769);
            this.panel1.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(41, 660);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(89, 37);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "Bishal";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(48, 572);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(224, 45);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProfile.Location = new System.Drawing.Point(48, 503);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(224, 45);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.CheckedState.Parent = this.btnViewUser;
            this.btnViewUser.CustomImages.Parent = this.btnViewUser;
            this.btnViewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.HoverState.Parent = this.btnViewUser;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(48, 431);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.ShadowDecoration.Parent = this.btnViewUser;
            this.btnViewUser.Size = new System.Drawing.Size(224, 45);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.Location = new System.Drawing.Point(48, 353);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(224, 45);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(48, 292);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(224, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adminstrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_ViewUsers1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 770);
            this.panel2.TabIndex = 0;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.ForeColor = System.Drawing.Color.Black;
            this.uC_Profile1.Location = new System.Drawing.Point(-1, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Profile1.TabIndex = 8;
            // 
            // uC_ViewUsers1
            // 
            this.uC_ViewUsers1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUsers1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewUsers1.Name = "uC_ViewUsers1";
            this.uC_ViewUsers1.Size = new System.Drawing.Size(1103, 770);
            this.uC_ViewUsers1.TabIndex = 2;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddUser1.TabIndex = 1;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.Location = new System.Drawing.Point(-3, -3);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1103, 770);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminstratorUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        protected internal System.Windows.Forms.Label userNameLabel;
        private AdminstratorUC.UC_ViewUsers uC_ViewUsers1;
        private AdminstratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdminstratorUC.UC_Profile uC_Profile1;
    }
}