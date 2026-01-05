using Learning_Tracker.Models;
using System.Diagnostics;
namespace Learning_Tracker.Forms;

public partial class MainForm : Form
{
    private int _userId;
    private string _username;

    public MainForm(User user)
    {
        InitializeComponent();

        _userId = user.Id;
        _username = user.Username;

        lblWelcome.Text = $"欢迎，{_username}";

        Debug.WriteLine("[MainForm] 构造完成，开始加载数据");

        LoadRecords();
    }

    private void LoadRecords()
    {
        try
        {
            Debug.WriteLine("[MainForm] 加载学习记录");

            List<StudyRecord> list =
                StudyRecordDAL.GetByUserId(_userId);

            dgvRecords.AutoGenerateColumns = false;
            dgvRecords.DataSource = list;

            Debug.WriteLine($"[MainForm] 加载完成，记录数：{list.Count}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("[MainForm] 加载失败：" + ex.Message);
            MessageBox.Show("加载学习记录失败");
        }
    }
    /*
     * 退出登录按钮点击事件
     */
    private void btnLogout_Click(object sender, EventArgs e)
    {
        Debug.WriteLine("[MainForm] 退出登录");

        this.Hide();
        new LoginForm().Show();
    }
    /*
     * 刷新按钮点击事件
     */
    private void btnRefresh_Click(object sender, EventArgs e)
    {
        Debug.WriteLine("[MainForm] 手动刷新");
        LoadRecords();
    }

    private void btnAddRecord_Click(object sender, EventArgs e)
    {
        using (AddRecordForm form = new AddRecordForm(_userId))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                // 子窗口添加成功后，刷新列表
                LoadRecords();
            }
        }
    }

}
