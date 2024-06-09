namespace HotelManagerment
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnLogOut = new Guna.UI2.WinForms.Guna2CircleButton();
            btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            uc_control = new All_user_control.UC_AddRoom();
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            uC_Employee1 = new All_user_control.UC_Employee();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnCustomerDetails);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(btnCustomerRegistration);
            panel1.Controls.Add(btnAddRoom);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1805, 723);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.DisabledState.BorderColor = Color.DarkGray;
            btnLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogOut.FillColor = Color.SteelBlue;
            btnLogOut.Font = new Font("Segoe UI", 9F);
            btnLogOut.ForeColor = Color.Transparent;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageSize = new Size(35, 35);
            btnLogOut.Location = new Point(75, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnLogOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnLogOut.Size = new Size(59, 66);
            btnLogOut.TabIndex = 6;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BorderRadius = 26;
            btnEmployee.CustomizableEdges = customizableEdges15;
            btnEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEmployee.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = HorizontalAlignment.Left;
            btnEmployee.ImageSize = new Size(35, 35);
            btnEmployee.Location = new Point(1505, 29);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnEmployee.Size = new Size(225, 56);
            btnEmployee.TabIndex = 4;
            btnEmployee.Text = "Employees";
            // 
            // btnCustomerDetails
            // 
            btnCustomerDetails.BorderRadius = 26;
            btnCustomerDetails.CustomizableEdges = customizableEdges17;
            btnCustomerDetails.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerDetails.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerDetails.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerDetails.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerDetails.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerDetails.ForeColor = Color.White;
            btnCustomerDetails.Image = (Image)resources.GetObject("btnCustomerDetails.Image");
            btnCustomerDetails.ImageAlign = HorizontalAlignment.Left;
            btnCustomerDetails.ImageSize = new Size(35, 35);
            btnCustomerDetails.Location = new Point(1195, 29);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCustomerDetails.Size = new Size(225, 56);
            btnCustomerDetails.TabIndex = 3;
            btnCustomerDetails.Text = "Customer Details";
            // 
            // panel2
            // 
            panel2.Controls.Add(uC_Employee1);
            panel2.Controls.Add(uc_control);
            panel2.Location = new Point(3, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(1800, 596);
            panel2.TabIndex = 1;
            // 
            // uc_control
            // 
            uc_control.BackColor = Color.White;
            uc_control.Location = new Point(9, 19);
            uc_control.Name = "uc_control";
            uc_control.Size = new Size(2154, 661);
            uc_control.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 26;
            btnCheckOut.CustomizableEdges = customizableEdges19;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Image = (Image)resources.GetObject("btnCheckOut.Image");
            btnCheckOut.ImageAlign = HorizontalAlignment.Left;
            btnCheckOut.ImageSize = new Size(35, 35);
            btnCheckOut.Location = new Point(875, 29);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnCheckOut.Size = new Size(225, 56);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCustomerRegistration
            // 
            btnCustomerRegistration.BorderRadius = 26;
            btnCustomerRegistration.CustomizableEdges = customizableEdges21;
            btnCustomerRegistration.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerRegistration.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerRegistration.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerRegistration.ForeColor = Color.White;
            btnCustomerRegistration.Image = (Image)resources.GetObject("btnCustomerRegistration.Image");
            btnCustomerRegistration.ImageAlign = HorizontalAlignment.Left;
            btnCustomerRegistration.ImageSize = new Size(35, 35);
            btnCustomerRegistration.Location = new Point(512, 29);
            btnCustomerRegistration.Name = "btnCustomerRegistration";
            btnCustomerRegistration.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnCustomerRegistration.Size = new Size(250, 56);
            btnCustomerRegistration.TabIndex = 1;
            btnCustomerRegistration.Text = "Customer Registration";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BorderRadius = 26;
            btnAddRoom.CustomizableEdges = customizableEdges23;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Image = (Image)resources.GetObject("btnAddRoom.Image");
            btnAddRoom.ImageAlign = HorizontalAlignment.Left;
            btnAddRoom.ImageSize = new Size(35, 35);
            btnAddRoom.Location = new Point(170, 29);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnAddRoom.Size = new Size(225, 56);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.SteelBlue;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(35, 35);
            btnExit.Location = new Point(2, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges25;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(69, 66);
            btnExit.TabIndex = 0;
            btnExit.Click += btnExit_Click;
            // 
            // guna2CircleButton2
            // 
            guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton2.FillColor = Color.SteelBlue;
            guna2CircleButton2.Font = new Font("Segoe UI", 9F);
            guna2CircleButton2.ForeColor = Color.Transparent;
            guna2CircleButton2.Image = (Image)resources.GetObject("guna2CircleButton2.Image");
            guna2CircleButton2.ImageSize = new Size(35, 35);
            guna2CircleButton2.Location = new Point(2, 71);
            guna2CircleButton2.Name = "guna2CircleButton2";
            guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton2.Size = new Size(59, 66);
            guna2CircleButton2.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = panel2;
            // 
            // uC_Employee1
            // 
            uC_Employee1.Location = new Point(9, 19);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(1793, 580);
            uC_Employee1.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1805, 723);
            Controls.Add(guna2CircleButton2);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_user_control.UC_AddRoom uc_control;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogOut;
        private All_user_control.UC_Employee uC_Employee1;
    }
}