using Learning_Tracker.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Learning_Tracker.DAL
{
    internal static class CategoryDAL
    {
        public static List<Category> GetAllActive()
        {
            string sql = @"
                SELECT id, name, description, color, is_active
                FROM category
                WHERE is_active = 1
                ORDER BY name";

            DataTable dt = DBHelper.ExecuteQuery(sql);

            List<Category> list = new();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Category
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["name"].ToString(),
                    Description = row["description"] == DBNull.Value ? null : row["description"].ToString(),
                    Color = row["color"] == DBNull.Value ? null : row["color"].ToString(),
                    IsActive = Convert.ToInt32(row["is_active"]) == 1
                });
            }

            return list;
        }

        public static List<Category> GetAll()
        {
            string sql = @"
                SELECT id, name, description, color, is_active
                FROM category
                ORDER BY is_active DESC, name";

            DataTable dt = DBHelper.ExecuteQuery(sql);

            List<Category> list = new();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Category
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["name"].ToString(),
                    Description = row["description"] == DBNull.Value ? null : row["description"].ToString(),
                    Color = row["color"] == DBNull.Value ? null : row["color"].ToString(),
                    IsActive = Convert.ToInt32(row["is_active"]) == 1
                });
            }

            return list;
        }

        public static int Add(Category category)
        {
            string sql = @"
                INSERT INTO category(name, description, color, is_active)
                VALUES(@name, @desc, @color, @active)";

            return DBHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@name", category.Name),
                new MySqlParameter("@desc", (object?)category.Description ?? DBNull.Value),
                new MySqlParameter("@color", (object?)category.Color ?? DBNull.Value),
                new MySqlParameter("@active", category.IsActive ? 1 : 0)
            );
        }

        public static int Update(Category category)
        {
            string sql = @"
                UPDATE category
                SET
                    name = @name,
                    description = @desc,
                    color = @color,
                    is_active = @active
                WHERE id = @id";

            return DBHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@name", category.Name),
                new MySqlParameter("@desc", (object?)category.Description ?? DBNull.Value),
                new MySqlParameter("@color", (object?)category.Color ?? DBNull.Value),
                new MySqlParameter("@active", category.IsActive ? 1 : 0),
                new MySqlParameter("@id", category.Id)
            );
        }

        public static int Deactivate(int id)
        {
            string sql = @"
                UPDATE category
                SET is_active = 0
                WHERE id = @id";

            return DBHelper.ExecuteNonQuery(
                sql,
                new MySqlParameter("@id", id)
            );
        }
    }
}
