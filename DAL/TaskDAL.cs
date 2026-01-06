using Learning_Tracker.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Learning_Tracker.DAL
{
    internal class TaskDAL
    {
        public static void Add(Models.Task task)
        {
            string sql = @"INSERT INTO task
                   (user_id, category_id, title, target_minutes,
                    start_date, end_date, status)
                   VALUES
                   (@userId, @categoryId, @title, @minutes,
                    @startDate, @endDate, @status)";

            DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@userId", task.UserId),
                new MySqlParameter("@categoryId", task.CategoryId),
                new MySqlParameter("@title", task.Title),
                new MySqlParameter("@minutes", task.TargetMinutes),
                new MySqlParameter("@startDate", task.StartDate),
                new MySqlParameter("@endDate", task.EndDate),
                new MySqlParameter("@status", task.Status)
            );
        }
        public static List<TaskViewModel> GetByUserId(int userId)
        {
            string sql = @"
        SELECT
            t.id,
            t.title,
            t.category_id,
            c.name AS category_name,
            t.target_minutes,
            t.status,
            t.start_date,
            t.end_date
        FROM task t
        JOIN category c ON t.category_id = c.id
        WHERE t.user_id = @userId
        ORDER BY t.create_time DESC
    ";

            DataTable dt = DBHelper.ExecuteQuery(
                sql,
                new MySqlParameter("@userId", userId)
            );

            List<TaskViewModel> list = new();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TaskViewModel
                {
                    Id = Convert.ToInt32(row["id"]),
                    Title = row["title"].ToString(),
                    CategoryId = Convert.ToInt32(row["category_id"]),
                    CategoryName = row["category_name"].ToString(),
                    TargetMinutes = Convert.ToInt32(row["target_minutes"]),
                    Status = row["status"].ToString(),
                    StartDate = Convert.ToDateTime(row["start_date"]),
                    EndDate = row["end_date"] == DBNull.Value
                        ? null
                        : Convert.ToDateTime(row["end_date"])
                });
            }

            return list;
        }



        public static Models.Task? GetById(int id, int userId)
        {
            string sql = @"
                SELECT id, user_id, category_id, title, target_minutes, start_date, end_date, status, create_time
                FROM task
                WHERE id = @id AND user_id = @userId";

            DataTable dt = DBHelper.ExecuteQuery(
                sql,
                new MySqlParameter("@id", id),
                new MySqlParameter("@userId", userId)
            );

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Models.Task
            {
                Id = Convert.ToInt32(row["id"]),
                UserId = Convert.ToInt32(row["user_id"]),
                CategoryId = Convert.ToInt32(row["category_id"]),
                Title = row["title"].ToString(),
                TargetMinutes = Convert.ToInt32(row["target_minutes"]),
                StartDate = Convert.ToDateTime(row["start_date"]),
                EndDate = row["end_date"] == DBNull.Value ? null : Convert.ToDateTime(row["end_date"]),
                Status = row["status"].ToString(),
                CreateTime = Convert.ToDateTime(row["create_time"])
            };
        }

        public static int Update(Models.Task task)
        {
            string sql = @"
                UPDATE task
                SET
                    category_id = @categoryId,
                    title = @title,
                    target_minutes = @minutes,
                    start_date = @startDate,
                    end_date = @endDate,
                    status = @status
                WHERE id = @id
                  AND user_id = @userId";

            return DBHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@categoryId", task.CategoryId),
                new MySqlParameter("@title", task.Title),
                new MySqlParameter("@minutes", task.TargetMinutes),
                new MySqlParameter("@startDate", task.StartDate),
                new MySqlParameter("@endDate", (object?)task.EndDate ?? DBNull.Value),
                new MySqlParameter("@status", task.Status),
                new MySqlParameter("@id", task.Id),
                new MySqlParameter("@userId", task.UserId)
            );
        }

        public static int Delete(int id, int userId)
        {
            string sql = @"
                DELETE FROM task
                WHERE id = @id
                  AND user_id = @userId";

            return DBHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@id", id),
                new MySqlParameter("@userId", userId)
            );
        }


    }
}
