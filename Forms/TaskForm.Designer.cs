namespace Learning_Tracker.Forms
{
    partial class TaskForm
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
            panelLeft = new Panel();
            gbTaskEdit = new GroupBox();
            btnReset = new Button();
            btnSave = new Button();
            cmbStatus = new ComboBox();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            numMinutes = new NumericUpDown();
            cmbCategory = new ComboBox();
            txtTitle = new TextBox();
            lblStatus = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            lblMinutes = new Label();
            lblCategory = new Label();
            lblTaskTitle = new Label();
            panelRight = new Panel();
            dgvTasks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colMinutes = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colEndDate = new DataGridViewTextBoxColumn();
            panelRightTop = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            gbTaskEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panelRightTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 45, 48);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 70);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微软雅黑", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "学习任务管理";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.WhiteSmoke;
            panelLeft.Controls.Add(gbTaskEdit);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 70);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(15);
            panelLeft.Size = new Size(450, 630);
            panelLeft.TabIndex = 1;
            // 
            // gbTaskEdit
            // 
            gbTaskEdit.BackColor = Color.White;
            gbTaskEdit.Controls.Add(btnReset);
            gbTaskEdit.Controls.Add(btnSave);
            gbTaskEdit.Controls.Add(cmbStatus);
            gbTaskEdit.Controls.Add(dtpEnd);
            gbTaskEdit.Controls.Add(dtpStart);
            gbTaskEdit.Controls.Add(numMinutes);
            gbTaskEdit.Controls.Add(cmbCategory);
            gbTaskEdit.Controls.Add(txtTitle);
            gbTaskEdit.Controls.Add(lblStatus);
            gbTaskEdit.Controls.Add(lblEndDate);
            gbTaskEdit.Controls.Add(lblStartDate);
            gbTaskEdit.Controls.Add(lblMinutes);
            gbTaskEdit.Controls.Add(lblCategory);
            gbTaskEdit.Controls.Add(lblTaskTitle);
            gbTaskEdit.Dock = DockStyle.Fill;
            gbTaskEdit.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            gbTaskEdit.ForeColor = Color.FromArgb(64, 64, 64);
            gbTaskEdit.Location = new Point(15, 15);
            gbTaskEdit.Name = "gbTaskEdit";
            gbTaskEdit.Padding = new Padding(20);
            gbTaskEdit.Size = new Size(420, 600);
            gbTaskEdit.TabIndex = 0;
            gbTaskEdit.TabStop = false;
            gbTaskEdit.Text = "任务编辑";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(225, 530);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(170, 45);
            btnReset.TabIndex = 13;
            btnReset.Text = "清空";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(25, 530);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 45);
            btnSave.TabIndex = 12;
            btnSave.Text = "保存任务";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("微软雅黑", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(25, 460);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(370, 35);
            cmbStatus.TabIndex = 11;
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarFont = new Font("微软雅黑", 10F);
            dtpEnd.Font = new Font("微软雅黑", 10F);
            dtpEnd.Location = new Point(25, 395);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(370, 34);
            dtpEnd.TabIndex = 10;
            // 
            // dtpStart
            // 
            dtpStart.CalendarFont = new Font("微软雅黑", 10F);
            dtpStart.Font = new Font("微软雅黑", 10F);
            dtpStart.Location = new Point(25, 330);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(370, 34);
            dtpStart.TabIndex = 9;
            // 
            // numMinutes
            // 
            numMinutes.Font = new Font("微软雅黑", 10F);
            numMinutes.Location = new Point(25, 265);
            numMinutes.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(370, 34);
            numMinutes.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("微软雅黑", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(25, 135);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(370, 35);
            cmbCategory.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("微软雅黑", 10F);
            txtTitle.Location = new Point(25, 70);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(370, 34);
            txtTitle.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(21, 435);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(112, 27);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "任务状态：";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblEndDate.Location = new Point(21, 370);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(112, 27);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "结束日期：";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblStartDate.Location = new Point(21, 305);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(112, 27);
            lblStartDate.TabIndex = 3;
            lblStartDate.Text = "开始日期：";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblMinutes.Location = new Point(21, 240);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(192, 27);
            lblMinutes.TabIndex = 2;
            lblMinutes.Text = "计划时长（分钟）：";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblCategory.Location = new Point(21, 110);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(112, 27);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "任务分类：";
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.AutoSize = true;
            lblTaskTitle.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblTaskTitle.Location = new Point(21, 45);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(112, 27);
            lblTaskTitle.TabIndex = 0;
            lblTaskTitle.Text = "任务名称：";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(dgvTasks);
            panelRight.Controls.Add(panelRightTop);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(450, 70);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(750, 630);
            panelRight.TabIndex = 2;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.BackgroundColor = Color.White;
            dgvTasks.BorderStyle = BorderStyle.None;
            dgvTasks.ColumnHeadersHeight = 40;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategory, colMinutes, colStatus, colStartDate, colEndDate });
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(0, 70);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.RowTemplate.Height = 35;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(750, 560);
            dgvTasks.TabIndex = 1;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colTitle
            // 
            colTitle.FillWeight = 120F;
            colTitle.HeaderText = "任务名称";
            colTitle.MinimumWidth = 8;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.FillWeight = 80F;
            colCategory.HeaderText = "分类";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colMinutes
            // 
            colMinutes.FillWeight = 80F;
            colMinutes.HeaderText = "计划时长";
            colMinutes.MinimumWidth = 8;
            colMinutes.Name = "colMinutes";
            colMinutes.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 70F;
            colStatus.HeaderText = "状态";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colStartDate
            // 
            colStartDate.FillWeight = 90F;
            colStartDate.HeaderText = "开始日期";
            colStartDate.MinimumWidth = 8;
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            colEndDate.FillWeight = 90F;
            colEndDate.HeaderText = "结束日期";
            colEndDate.MinimumWidth = 8;
            colEndDate.Name = "colEndDate";
            colEndDate.ReadOnly = true;
            // 
            // panelRightTop
            // 
            panelRightTop.BackColor = Color.WhiteSmoke;
            panelRightTop.Controls.Add(btnDelete);
            panelRightTop.Controls.Add(btnEdit);
            panelRightTop.Dock = DockStyle.Top;
            panelRightTop.Location = new Point(0, 0);
            panelRightTop.Name = "panelRightTop";
            panelRightTop.Padding = new Padding(15, 15, 15, 10);
            panelRightTop.Size = new Size(750, 70);
            panelRightTop.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(155, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "删除任务";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 123, 255);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(15, 15);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "编辑任务";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Font = new Font("微软雅黑", 9F);
            MinimumSize = new Size(1000, 600);
            Name = "TaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学习任务管理";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            gbTaskEdit.ResumeLayout(false);
            gbTaskEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panelRightTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox gbTaskEdit;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelRightTop;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
    }
}