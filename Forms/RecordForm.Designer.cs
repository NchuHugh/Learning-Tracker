namespace Learning_Tracker.Forms
{
    partial class RecordForm
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
            lblTitle = new Label();
            panelMain = new Panel();
            btnCancel = new Button();
            btnAddRecord = new Button();
            dtpStudyDate = new DateTimePicker();
            txtStudyTime = new TextBox();
            txtContent = new TextBox();
            txtSubject = new TextBox();
            lblStudyDate = new Label();
            lblStudyTime = new Label();
            lblContent = new Label();
            lblSubject = new Label();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 45, 48);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(510, 60);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "新增学习记录";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnAddRecord);
            panelMain.Controls.Add(dtpStudyDate);
            panelMain.Controls.Add(txtStudyTime);
            panelMain.Controls.Add(txtContent);
            panelMain.Controls.Add(txtSubject);
            panelMain.Controls.Add(lblStudyDate);
            panelMain.Controls.Add(lblStudyTime);
            panelMain.Controls.Add(lblContent);
            panelMain.Controls.Add(lblSubject);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30, 30, 30, 20);
            panelMain.Size = new Size(510, 457);
            panelMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(260, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 45);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.BackColor = Color.FromArgb(40, 167, 69);
            btnAddRecord.FlatAppearance.BorderSize = 0;
            btnAddRecord.FlatStyle = FlatStyle.Flat;
            btnAddRecord.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnAddRecord.ForeColor = Color.White;
            btnAddRecord.Location = new Point(60, 360);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(180, 45);
            btnAddRecord.TabIndex = 8;
            btnAddRecord.Text = "添加记录";
            btnAddRecord.UseVisualStyleBackColor = false;
            btnAddRecord.Click += btnSave_Click;
            // 
            // dtpStudyDate
            // 
            dtpStudyDate.CalendarFont = new Font("微软雅黑", 10F);
            dtpStudyDate.Font = new Font("微软雅黑", 10F);
            dtpStudyDate.Location = new Point(56, 305);
            dtpStudyDate.Name = "dtpStudyDate";
            dtpStudyDate.Size = new Size(380, 34);
            dtpStudyDate.TabIndex = 7;
            // 
            // txtStudyTime
            // 
            txtStudyTime.Font = new Font("微软雅黑", 10F);
            txtStudyTime.Location = new Point(60, 240);
            txtStudyTime.Name = "txtStudyTime";
            txtStudyTime.Size = new Size(380, 34);
            txtStudyTime.TabIndex = 6;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("微软雅黑", 10F);
            txtContent.Location = new Point(60, 130);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(380, 60);
            txtContent.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("微软雅黑", 10F);
            txtSubject.Location = new Point(60, 60);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(380, 34);
            txtSubject.TabIndex = 4;
            // 
            // lblStudyDate
            // 
            lblStudyDate.AutoSize = true;
            lblStudyDate.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblStudyDate.ForeColor = Color.FromArgb(64, 64, 64);
            lblStudyDate.Location = new Point(56, 275);
            lblStudyDate.Name = "lblStudyDate";
            lblStudyDate.Size = new Size(112, 27);
            lblStudyDate.TabIndex = 3;
            lblStudyDate.Text = "学习日期：";
            // 
            // lblStudyTime
            // 
            lblStudyTime.AutoSize = true;
            lblStudyTime.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblStudyTime.ForeColor = Color.FromArgb(64, 64, 64);
            lblStudyTime.Location = new Point(56, 215);
            lblStudyTime.Name = "lblStudyTime";
            lblStudyTime.Size = new Size(192, 27);
            lblStudyTime.TabIndex = 2;
            lblStudyTime.Text = "学习时长（分钟）：";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblContent.ForeColor = Color.FromArgb(64, 64, 64);
            lblContent.Location = new Point(56, 105);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(112, 27);
            lblContent.TabIndex = 1;
            lblContent.Text = "学习内容：";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblSubject.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubject.Location = new Point(56, 35);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(112, 27);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "学习科目：";
            // 
            // AddRecordForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(510, 517);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Font = new Font("微软雅黑", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddRecordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "新增学习记录";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblStudyTime;
        private System.Windows.Forms.Label lblStudyDate;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtStudyTime;
        private System.Windows.Forms.DateTimePicker dtpStudyDate;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnCancel;
    }
}