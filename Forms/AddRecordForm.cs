using Learning_Tracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learning_Tracker.Forms
{
    public partial class AddRecordForm : Form
    {
        private readonly int _userId;

        public AddRecordForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1️⃣ 输入校验
            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("请输入学习主题", "提示");
                txtSubject.Focus();
                return;
            }

            if (!int.TryParse(txtStudyTime.Text.Trim(), out int studyTime) || studyTime <= 0)
            {
                MessageBox.Show("学习时长必须是大于 0 的整数", "提示");
                txtStudyTime.Focus();
                return;
            }

            // 2️⃣ 组装 Model
            StudyRecord record = new StudyRecord
            {
                UserId = _userId,
                Subject = txtSubject.Text.Trim(),
                Content = txtContent.Text.Trim(),
                StudyTime = studyTime,
                StudyDate = dtpStudyDate.Value.Date
            };

            try
            {
                if (StudyRecordDAL.Exists(_userId, dtpStudyDate.Value.Date))
                {
                    MessageBox.Show("该日期已有学习记录，请直接编辑。");
                    return;
                }

                // 3️⃣ 调用 DAL
                StudyRecordDAL.Add(record);

                MessageBox.Show("学习记录添加成功", "成功");

                // 4️⃣ 设置 DialogResult 并关闭
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败：" + ex.Message, "错误");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }


}
