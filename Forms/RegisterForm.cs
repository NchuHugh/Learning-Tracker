using Learning_Tracker.DAL;
using System;
using System.Windows.Forms;

namespace Learning_Tracker.Forms
{
    public partial class RegisterForm : Form
    {
        private UserDAL userDAL = new UserDAL();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("请填写完整信息");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("两次密码不一致");
                return;
            }

            bool success = userDAL.Register(username, password);

            if (success)
            {
                MessageBox.Show("注册成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名已存在");
            }
        }
    }
}
