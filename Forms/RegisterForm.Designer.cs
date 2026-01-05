namespace Learning_Tracker.Forms
{
    partial class RegisterForm
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
            panelTop = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            btnCancel = new Button();
            btnRegister = new Button();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblConfirm = new Label();
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
            lblTitle.Location = new Point(160, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "用户注册";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnRegister);
            panelMain.Controls.Add(txtConfirm);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(lblConfirm);
            panelMain.Controls.Add(lblPassword);
            panelMain.Controls.Add(lblUsername);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(40);
            panelMain.Size = new Size(450, 320);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(240, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 45);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(70, 235);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 45);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "注册";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Font = new Font("微软雅黑", 11F);
            txtConfirm.Location = new Point(70, 175);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '●';
            txtConfirm.Size = new Size(310, 37);
            txtConfirm.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("微软雅黑", 11F);
            txtPassword.Location = new Point(70, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(310, 37);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("微软雅黑", 11F);
            txtUsername.Location = new Point(70, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 37);
            txtUsername.TabIndex = 1;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfirm.Location = new Point(66, 150);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(112, 27);
            lblConfirm.TabIndex = 4;
            lblConfirm.Text = "确认密码：";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(66, 85);
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
            lblUsername.Location = new Point(66, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 27);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "用户名：";
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(450, 400);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Font = new Font("微软雅黑", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "用户注册";
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
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}