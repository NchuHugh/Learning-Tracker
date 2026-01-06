# Learning Tracker

一个基于 **WinForms + MySQL** 的桌面学习时间管理系统，用于练习「桌面应用分层架构 + 数据库建模 + CRUD 业务落地」。

核心能力：

- **学习记录**：新增/编辑/查询
- **学习任务**：新增/编辑/删除/状态管理/结束日期（可选）

---

## 功能清单

### 用户

- 登录
- 注册

### 学习记录（study_record）

- 新增学习记录（每天一条：由数据库 `UNIQUE(user_id, study_date)` 约束）
- 编辑学习记录（编辑模式不允许修改日期）
- 主界面列表展示（DataGridView）

### 任务（task）

- 新增任务
- 编辑任务
- 删除任务（如果已有学习记录关联该任务，会阻止删除）
- 任务状态：进行中/已完成/放弃
- 结束日期：可选（DateTimePicker 勾选控制）

### 分类（category）

- 分类管理页面：新增/编辑/停用
- Task 页面可从“分类管理”入口打开，并刷新任务编辑区分类下拉框

---

## 技术栈

- UI：WinForms (.NET Windows Desktop)
- 数据库：MySQL
- 数据访问：`MySql.Data`
- 项目类型：`net10.0-windows`

---

## 项目结构

```
Learning Tracker/
  DAL/                 # 数据访问层（DBHelper + 各实体 DAL）
  Models/              # 数据模型
  Forms/               # WinForms UI
  Program.cs           # 程序入口
  SQL.txt              # 建表脚本
  README.md
```

---

## 环境要求

- Windows
- .NET SDK（能编译本项目目标框架）
- MySQL 8.x（或兼容版本）

---

## 数据库初始化

1. 打开 `SQL.txt`，执行建库建表脚本。
2. 确认包含以下表：

- `user`
- `category`
- `task`
- `study_record`

---

## 配置数据库连接

数据库连接串在：

- `DAL/DBHelper.cs` 的 `connStr`

默认示例：

```
server=localhost;port=3306;database=learning_tracker;user=root;password=1234;
```

请根据你的本机 MySQL 配置修改：`server / port / user / password`。

---

## 运行方式

1. 启动 MySQL，并确认数据库 `learning_tracker` 可访问。
2. 打开解决方案并运行，或命令行构建：

```bash
dotnet build "Learning Tracker.csproj"
```

3. 程序入口：`Program.cs` -> `LoginForm`。

## 常见问题

### 1) 生成失败：exe 被占用/锁定

如果看到类似“无法复制 apphost.exe / Learning Tracker.exe，被某进程锁定”，请先关闭正在运行的程序后再 build。

### 2) 登录失败/无法连接数据库

- 检查 MySQL 是否启动
- 检查 `DBHelper.connStr` 是否正确
- 检查数据库是否执行过 `SQL.txt`

---

## 许可

个人学习与课程/作业实践用途。