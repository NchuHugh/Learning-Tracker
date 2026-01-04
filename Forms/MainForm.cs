using Learning_Tracker.Models;
using System.Windows.Forms;

namespace Learning_Tracker.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.Text = $"学习管理系统 - 当前用户：{user.Username}";
        }
    }
}
