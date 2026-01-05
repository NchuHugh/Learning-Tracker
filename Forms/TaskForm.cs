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

        public TaskForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            //LoadCategories();
            LoadTasks();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            TaskDAL.Add(task);
            LoadTasks();
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


    }

}
