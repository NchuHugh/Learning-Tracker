using Learning_Tracker.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learning_Tracker.Forms
{
    public partial class RecordForm : Form
    {
        private readonly int _userId;
        private StudyRecord _record;
        private readonly bool _isEditMode;

        // Add 模式
        public RecordForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _isEditMode = false;
        }

        // Edit 模式
        public RecordForm(StudyRecord record)
        {
            InitializeComponent();
            _record = record;
            _userId = record.UserId;
            _isEditMode = true;
            dtpStudyDate.Enabled = false; // 编辑模式下不允许修改日期
        }
        private void RecordForm_Load(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                this.Text = "编辑学习记录";

                txtSubject.Text = _record.Subject;
                txtContent.Text = _record.Content;
                txtStudyTime.Text = _record.StudyTime.ToString();
                dtpStudyDate.Value = _record.StudyDate;
            }
            else
            {
                this.Text = "新增学习记录";
                dtpStudyDate.Value = DateTime.Today;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1️⃣ 校验
            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("请输入学习主题");
                txtSubject.Focus();
                return;
            }

            if (!int.TryParse(txtStudyTime.Text.Trim(), out int studyTime) || studyTime <= 0)
            {
                MessageBox.Show("学习时长必须是正整数");
                txtStudyTime.Focus();
                return;
            }

            // 2️⃣ 组装 / 更新 Model
            if (_isEditMode)
            {
                _record.Subject = txtSubject.Text.Trim();
                _record.Content = txtContent.Text.Trim();
                _record.StudyTime = studyTime;
                _record.StudyDate = dtpStudyDate.Value.Date;
            }
            else
            {
                _record = new StudyRecord
                {
                    UserId = _userId,
                    Subject = txtSubject.Text.Trim(),
                    Content = txtContent.Text.Trim(),
                    StudyTime = studyTime,
                    StudyDate = dtpStudyDate.Value.Date
                };
            }

            try
            {
                // 3️⃣ 持久化
                if (_isEditMode)
                {
                    StudyRecordDAL.Update(_record);
                }
                else
                {
                    StudyRecordDAL.Add(_record);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("该日期已有学习记录，请修改原记录。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }


}
