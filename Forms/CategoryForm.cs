using Learning_Tracker.DAL;
using Learning_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Learning_Tracker.Forms
{
    public class CategoryForm : Form
    {
        private readonly DataGridView _grid = new();
        private readonly TextBox _txtName = new();
        private readonly TextBox _txtDesc = new();
        private readonly TextBox _txtColor = new();
        private readonly CheckBox _chkActive = new();
        private readonly Button _btnSave = new();
        private readonly Button _btnReset = new();
        private readonly Button _btnDeactivate = new();

        private int? _editingId;

        public CategoryForm()
        {
            Text = "分类管理";
            StartPosition = FormStartPosition.CenterParent;
            Width = 900;
            Height = 600;
            BackColor = Color.WhiteSmoke;
            Font = new Font("微软雅黑", 9F);

            var panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(45, 45, 48)
            };
            var lblTitle = new Label
            {
                Text = "学习分类管理",
                ForeColor = Color.White,
                Font = new Font("微软雅黑", 16F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 18)
            };
            panelTop.Controls.Add(lblTitle);

            var panelLeft = new Panel
            {
                Dock = DockStyle.Left,
                Width = 360,
                Padding = new Padding(15),
                BackColor = Color.WhiteSmoke
            };

            var gb = new GroupBox
            {
                Text = "分类编辑",
                Dock = DockStyle.Fill,
                Font = new Font("微软雅黑", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            var lblName = new Label { Text = "名称：", AutoSize = true, Location = new Point(22, 40) };
            _txtName.Location = new Point(25, 70);
            _txtName.Width = 300;

            var lblDesc = new Label { Text = "描述：", AutoSize = true, Location = new Point(22, 120) };
            _txtDesc.Location = new Point(25, 150);
            _txtDesc.Width = 300;

            var lblColor = new Label { Text = "颜色(可选)：", AutoSize = true, Location = new Point(22, 200) };
            _txtColor.Location = new Point(25, 230);
            _txtColor.Width = 300;

            _chkActive.Text = "启用";
            _chkActive.Checked = true;
            _chkActive.AutoSize = true;
            _chkActive.Location = new Point(25, 285);

            _btnSave.Text = "保存";
            _btnSave.BackColor = Color.FromArgb(40, 167, 69);
            _btnSave.ForeColor = Color.White;
            _btnSave.FlatStyle = FlatStyle.Flat;
            _btnSave.FlatAppearance.BorderSize = 0;
            _btnSave.Location = new Point(25, 340);
            _btnSave.Size = new Size(140, 42);
            _btnSave.Click += BtnSave_Click;

            _btnReset.Text = "清空";
            _btnReset.BackColor = Color.FromArgb(108, 117, 125);
            _btnReset.ForeColor = Color.White;
            _btnReset.FlatStyle = FlatStyle.Flat;
            _btnReset.FlatAppearance.BorderSize = 0;
            _btnReset.Location = new Point(185, 340);
            _btnReset.Size = new Size(140, 42);
            _btnReset.Click += (s, e) => ResetEditor();

            _btnDeactivate.Text = "停用";
            _btnDeactivate.BackColor = Color.FromArgb(220, 53, 69);
            _btnDeactivate.ForeColor = Color.White;
            _btnDeactivate.FlatStyle = FlatStyle.Flat;
            _btnDeactivate.FlatAppearance.BorderSize = 0;
            _btnDeactivate.Location = new Point(25, 395);
            _btnDeactivate.Size = new Size(300, 42);
            _btnDeactivate.Click += BtnDeactivate_Click;

            gb.Controls.Add(lblName);
            gb.Controls.Add(_txtName);
            gb.Controls.Add(lblDesc);
            gb.Controls.Add(_txtDesc);
            gb.Controls.Add(lblColor);
            gb.Controls.Add(_txtColor);
            gb.Controls.Add(_chkActive);
            gb.Controls.Add(_btnSave);
            gb.Controls.Add(_btnReset);
            gb.Controls.Add(_btnDeactivate);
            panelLeft.Controls.Add(gb);

            var panelRight = new Panel { Dock = DockStyle.Fill, Padding = new Padding(15), BackColor = Color.White };

            _grid.Dock = DockStyle.Fill;
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.AllowUserToDeleteRows = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.RowHeadersVisible = false;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.ColumnHeadersHeight = 40;
            _grid.CellDoubleClick += Grid_CellDoubleClick;

            _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", Visible = false });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "名称" });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "描述" });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Color", HeaderText = "颜色" });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "IsActive", HeaderText = "启用" });

            panelRight.Controls.Add(_grid);

            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);

            LoadCategories();
            ResetEditor();
        }

        private void LoadCategories()
        {
            _grid.Rows.Clear();
            List<Category> list = CategoryDAL.GetAll();
            foreach (var c in list)
            {
                _grid.Rows.Add(c.Id, c.Name, c.Description, c.Color, c.IsActive ? "是" : "否");
            }
        }

        private int? GetSelectedId()
        {
            if (_grid.SelectedRows.Count == 0)
                return null;

            object value = _grid.SelectedRows[0].Cells[0].Value;
            if (value == null)
                return null;

            return Convert.ToInt32(value);
        }

        private void Grid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = _grid.Rows[e.RowIndex];
            _editingId = Convert.ToInt32(row.Cells[0].Value);
            _txtName.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
            _txtDesc.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            _txtColor.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            _chkActive.Checked = (row.Cells[4].Value?.ToString() ?? "否") == "是";
            _btnSave.Text = "保存修改";
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtName.Text))
            {
                MessageBox.Show("请输入分类名称");
                _txtName.Focus();
                return;
            }

            var category = new Category
            {
                Id = _editingId ?? 0,
                Name = _txtName.Text.Trim(),
                Description = string.IsNullOrWhiteSpace(_txtDesc.Text) ? null : _txtDesc.Text.Trim(),
                Color = string.IsNullOrWhiteSpace(_txtColor.Text) ? null : _txtColor.Text.Trim(),
                IsActive = _chkActive.Checked
            };

            try
            {
                if (_editingId.HasValue)
                    CategoryDAL.Update(category);
                else
                    CategoryDAL.Add(category);

                LoadCategories();
                ResetEditor();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("分类名称已存在");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }

        private void BtnDeactivate_Click(object? sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (!id.HasValue)
            {
                MessageBox.Show("请选择要停用的分类（双击行可进入编辑）");
                return;
            }

            if (MessageBox.Show("确认停用该分类？（任务仍可保留引用）", "停用确认", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            CategoryDAL.Deactivate(id.Value);
            LoadCategories();
            if (_editingId == id)
                ResetEditor();
        }

        private void ResetEditor()
        {
            _editingId = null;
            _txtName.Text = string.Empty;
            _txtDesc.Text = string.Empty;
            _txtColor.Text = string.Empty;
            _chkActive.Checked = true;
            _btnSave.Text = "保存";
        }
    }
}
