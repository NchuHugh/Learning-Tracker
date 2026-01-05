namespace Learning_Tracker.Forms
{
    partial class MainForm
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
            btnLogout = new Button();
            btnRefresh = new Button();
            btnAddRecord = new Button();
            lblWelcome = new Label();
            dgvRecords = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colContent = new DataGridViewTextBoxColumn();
            colStudyTime = new DataGridViewTextBoxColumn();
            colStudyDate = new DataGridViewTextBoxColumn();
            colCreateTime = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 45, 48);
            panelTop.Controls.Add(btnLogout);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(btnAddRecord);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 70);
            panelTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(870, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 35);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "退出登录";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(0, 123, 255);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(740, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRecord.BackColor = Color.FromArgb(40, 167, 69);
            btnAddRecord.FlatAppearance.BorderSize = 0;
            btnAddRecord.FlatStyle = FlatStyle.Flat;
            btnAddRecord.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnAddRecord.ForeColor = Color.White;
            btnAddRecord.Location = new Point(610, 20);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(110, 35);
            btnAddRecord.TabIndex = 1;
            btnAddRecord.Text = "新增记录";
            btnAddRecord.UseVisualStyleBackColor = false;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(20, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(128, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "欢迎，xxx";
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BackgroundColor = Color.White;
            dgvRecords.BorderStyle = BorderStyle.None;
            dgvRecords.ColumnHeadersHeight = 40;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colId, colSubject, colContent, colStudyTime, colStudyDate, colCreateTime });
            colId.DataPropertyName = "Id";
            colSubject.DataPropertyName = "Subject";
            colContent.DataPropertyName = "Content";
            colStudyTime.DataPropertyName = "StudyTime";
            colStudyDate.DataPropertyName = "StudyDate";
            colCreateTime.DataPropertyName = "CreateTime";
            dgvRecords.Dock = DockStyle.Fill;
            dgvRecords.Location = new Point(0, 70);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowHeadersWidth = 62;
            dgvRecords.RowTemplate.Height = 35;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(1000, 530);
            dgvRecords.TabIndex = 1;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colSubject
            // 
            colSubject.FillWeight = 80F;
            colSubject.HeaderText = "学习科目";
            colSubject.MinimumWidth = 8;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            // 
            // colContent
            // 
            colContent.FillWeight = 150F;
            colContent.HeaderText = "学习内容";
            colContent.MinimumWidth = 8;
            colContent.Name = "colContent";
            colContent.ReadOnly = true;
            // 
            // colStudyTime
            // 
            colStudyTime.FillWeight = 80F;
            colStudyTime.HeaderText = "学习时长(min)";
            colStudyTime.MinimumWidth = 8;
            colStudyTime.Name = "colStudyTime";
            colStudyTime.ReadOnly = true;
            // 
            // colStudyDate
            // 
            colStudyDate.FillWeight = 90F;
            colStudyDate.HeaderText = "学习日期";
            colStudyDate.MinimumWidth = 8;
            colStudyDate.Name = "colStudyDate";
            colStudyDate.ReadOnly = true;
            // 
            // colCreateTime
            // 
            colCreateTime.HeaderText = "记录时间";
            colCreateTime.MinimumWidth = 8;
            colCreateTime.Name = "colCreateTime";
            colCreateTime.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvRecords);
            Controls.Add(panelTop);
            Font = new Font("微软雅黑", 9F);
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学习记录管理系统";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvRecords;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colContent;
        private DataGridViewTextBoxColumn colStudyTime;
        private DataGridViewTextBoxColumn colStudyDate;
        private DataGridViewTextBoxColumn colCreateTime;
    }
}