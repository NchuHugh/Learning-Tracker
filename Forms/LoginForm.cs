using Learning_Tracker.DAL;
using Learning_Tracker.Models;
using System;
using System.Windows.Forms;

namespace Learning_Tracker.Forms
{
    public partial class LoginForm : Form
    {
        private UserDAL userDAL = new UserDAL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("请输入用户名和密码");
                return;
            }

            User user = userDAL.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("用户名或密码错误");
                return;
            }

            // 登录成功
            MessageBox.Show("登录成功");

            MainForm main = new MainForm(user);
            main.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }
    }
}
