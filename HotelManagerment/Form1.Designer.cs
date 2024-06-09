namespace HotelManagerment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            labelError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            btnSigup = new Guna.UI2.WinForms.Guna2Button();
            labelForget = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSigup);
            panel1.Controls.Add(labelForget);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 529);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelError
            // 
            labelError.BackColor = Color.Transparent;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(814, 440);
            labelError.Name = "labelError";
            labelError.Size = new Size(204, 22);
            labelError.TabIndex = 8;
            labelError.Text = "Wrong Username Or Password";
            labelError.Visible = false;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.WhiteSmoke;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(30, 30);
            btnExit.Location = new Point(3, 3);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(56, 48);
            btnExit.TabIndex = 7;
            btnExit.Click += btnExit_Click;
            // 
            // btnSigup
            // 
            btnSigup.BorderRadius = 18;
            btnSigup.CustomizableEdges = customizableEdges2;
            btnSigup.DisabledState.BorderColor = Color.DarkGray;
            btnSigup.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSigup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSigup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSigup.Font = new Font("Segoe UI", 9F);
            btnSigup.ForeColor = Color.White;
            btnSigup.Location = new Point(891, 363);
            btnSigup.Name = "btnSigup";
            btnSigup.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnSigup.Size = new Size(168, 56);
            btnSigup.TabIndex = 6;
            btnSigup.Text = "Signup";
            // 
            // labelForget
            // 
            labelForget.BackColor = Color.Transparent;
            labelForget.ForeColor = Color.Blue;
            labelForget.Location = new Point(925, 325);
            labelForget.Name = "labelForget";
            labelForget.Size = new Size(114, 22);
            labelForget.TabIndex = 5;
            labelForget.Text = "Quên mật khẩu ? ";
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 18;
            btnLogin.CustomizableEdges = customizableEdges4;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(693, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnLogin.Size = new Size(179, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.FromArgb(128, 255, 255);
            txtPassword.BorderRadius = 18;
            txtPassword.CustomizableEdges = customizableEdges6;
            txtPassword.DefaultText = "1234";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(224, 224, 224);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftSize = new Size(25, 25);
            txtPassword.Location = new Point(693, 246);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderForeColor = Color.SaddleBrown;
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtPassword.Size = new Size(366, 60);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += guna2TextBox2_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Cornsilk;
            txtUsername.BorderColor = Color.Cyan;
            txtUsername.BorderRadius = 18;
            txtUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            txtUsername.CustomizableEdges = customizableEdges8;
            txtUsername.DefaultText = "letrung";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(224, 224, 224);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.IconLeftSize = new Size(25, 25);
            txtUsername.Location = new Point(693, 148);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.SaddleBrown;
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtUsername.Size = new Size(366, 60);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(91, 14);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(502, 471);
            guna2CirclePictureBox1.TabIndex = 1;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(798, 26);
            label1.Name = "label1";
            label1.Size = new Size(179, 46);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1238, 800);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnSigup;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelForget;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelError;
    }
}
