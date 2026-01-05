namespace Learning_Tracker.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 45, 48);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(450, 80);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微软雅黑", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(85, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "学习记录管理系统";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnRegister);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(lblPassword);
            panelMain.Controls.Add(lblUsername);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(40);
            panelMain.Size = new Size(450, 270);
            panelMain.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(108, 117, 125);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(240, 180);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 45);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "注册账号";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(70, 180);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("微软雅黑", 11F);
            txtPassword.Location = new Point(70, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(310, 37);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("微软雅黑", 11F);
            txtUsername.Location = new Point(70, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 37);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(66, 90);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 27);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "密码：";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(66, 25);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 27);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "用户名：";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(450, 350);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Font = new Font("微软雅黑", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "系统登录";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}