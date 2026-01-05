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

    /*
     * 添加记录按钮点击事件
     */
    private void btnAddRecord_Click(object sender, EventArgs e)
    {
        using (RecordForm form = new RecordForm(_userId))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRecords();
            }
        }
    }

    /*
     * 双击记录行，打开编辑窗口
     */
    private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        StudyRecord record = dgvRecords.Rows[e.RowIndex].DataBoundItem as StudyRecord;
        if (record == null)
            return;

        using (RecordForm form = new RecordForm(record))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRecords();
            }
        }
    }
    /*
     * 打开任务管理
     */
    private void btnTask_Click(object sender, EventArgs e)
    {
        TaskForm taskForm = new TaskForm(_userId);
        taskForm.ShowDialog();   // 推荐用 ShowDialog
    }

}
