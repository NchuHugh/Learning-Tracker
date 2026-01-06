using Learning_Tracker.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Learning_Tracker.Models;

namespace Learning_Tracker.Forms
{
    public partial class TaskForm : Form
    {
        private int _userId;
        private int? _editingTaskId;

        public TaskForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            InitStatusOptions();
            LoadCategories();
            LoadTasks();
            ResetEditor();

            AddCategoryManageButton();
        }

        private void AddCategoryManageButton()
        {
            Button btnCategory = new Button();
            btnCategory.Text = "分类管理";
            btnCategory.BackColor = Color.FromArgb(0, 123, 255);
            btnCategory.ForeColor = Color.White;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.Size = new Size(110, 35);
            btnCategory.Location = new Point(250, 18);
            btnCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            btnCategory.Click += (s, e) =>
            {
                using (var form = new CategoryForm())
                {
                    form.ShowDialog(this);
                }

                LoadCategories();
            };

            panelTop.Controls.Add(btnCategory);
            btnCategory.BringToFront();
        }

        private void InitStatusOptions()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("进行中");
            cmbStatus.Items.Add("已完成");
            cmbStatus.Items.Add("放弃");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadCategories()
        {
            var list = CategoryDAL.GetAllActive();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("请输入任务名称");
                txtTitle.Focus();
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("请选择任务分类");
                return;
            }

            Models.Task task = new Models.Task
            {
                UserId = _userId,
                Title = txtTitle.Text.Trim(),
                CategoryId = (int)cmbCategory.SelectedValue,
                TargetMinutes = (int)numMinutes.Value,
                StartDate = dtpStart.Value.Date,
                EndDate = dtpEnd.Checked ? dtpEnd.Value.Date : null,
                Status = ConvertStatus(cmbStatus.Text)
            };

            if (_editingTaskId.HasValue)
            {
                task.Id = _editingTaskId.Value;
                int rows = TaskDAL.Update(task);
                if (rows <= 0)
                {
                    MessageBox.Show("更新失败：未找到任务或无权限");
                    return;
                }
            }
            else
            {
                TaskDAL.Add(task);
            }

            LoadTasks();
            ResetEditor();
        }
        private string ConvertStatus(string text)
        {
            return text switch
            {
                "进行中" => "ongoing",
                "已完成" => "finished",
                "放弃" => "abandoned",
                _ => "ongoing"
            };
        }
        private void LoadTasks()
        {
            dgvTasks.Rows.Clear();

            List<TaskViewModel> list = TaskDAL.GetByUserId(_userId);

            foreach (var task in list)
            {
                dgvTasks.Rows.Add(
         task.Id,
             task.Title,
         task.CategoryName,
     task.TargetMinutes,   // 不再是 plan_minutes
     task.Status,
     task.StartDate.ToString("yyyy-MM-dd"),
     task.EndDate?.ToString("yyyy-MM-dd")
 );

            }
        }

        private int? GetSelectedTaskId()
        {
            if (dgvTasks.SelectedRows.Count == 0)
                return null;

            object value = dgvTasks.SelectedRows[0].Cells[0].Value;
            if (value == null)
                return null;

            return Convert.ToInt32(value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? taskId = GetSelectedTaskId();
            if (!taskId.HasValue)
            {
                MessageBox.Show("请选择要编辑的任务");
                return;
            }

            Models.Task? task = TaskDAL.GetById(taskId.Value, _userId);
            if (task == null)
            {
                MessageBox.Show("任务不存在或无权限");
                return;
            }

            _editingTaskId = task.Id;
            txtTitle.Text = task.Title;
            cmbCategory.SelectedValue = task.CategoryId;
            numMinutes.Value = task.TargetMinutes;
            dtpStart.Value = task.StartDate;

            if (task.EndDate.HasValue)
            {
                dtpEnd.Value = task.EndDate.Value;
                dtpEnd.Checked = true;
            }
            else
            {
                dtpEnd.Value = DateTime.Today;
                dtpEnd.Checked = false;
            }

            cmbStatus.SelectedItem = task.Status switch
            {
                "finished" => "已完成",
                "abandoned" => "放弃",
                _ => "进行中"
            };

            btnSave.Text = "保存修改";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? taskId = GetSelectedTaskId();
            if (!taskId.HasValue)
            {
                MessageBox.Show("请选择要删除的任务");
                return;
            }

            if (StudyRecordDAL.HasLinkedTaskRecord(_userId, taskId.Value))
            {
                MessageBox.Show("该任务已有学习记录关联，禁止删除。\n你可以先修改当天学习记录关联到其他任务，或删除该学习记录。");
                return;
            }

            if (MessageBox.Show("确认删除该任务？", "删除确认", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            int rows = TaskDAL.Delete(taskId.Value, _userId);
            if (rows <= 0)
            {
                MessageBox.Show("删除失败：未找到任务或无权限");
                return;
            }

            LoadTasks();
            if (_editingTaskId == taskId)
                ResetEditor();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetEditor();
        }

        private void ResetEditor()
        {
            _editingTaskId = null;
            txtTitle.Text = string.Empty;
            numMinutes.Value = 0;
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            dtpEnd.Checked = false;
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            btnSave.Text = "保存任务";
        }


    }

}
