using Learning_Tracker.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Learning_Tracker.DAL
{
    public class UserDAL
    {
        public User Login(string username, string password)
        {
            Debug.WriteLine("[UserDAL] Login()");
            Debug.WriteLine($"[Input] username={username}, password={password}");

            string sql = "SELECT * FROM user WHERE username=@u AND password=@p";

            DataTable dt = DBHelper.ExecuteQuery(sql,
                new MySqlParameter("@u", username),
                new MySqlParameter("@p", password)
            );

            Debug.WriteLine("[UserDAL] Result count = " + dt.Rows.Count);

            if (dt.Rows.Count == 0)
            {
                Debug.WriteLine("[UserDAL] Login failed");
                return null;
            }

            DataRow row = dt.Rows[0];
            Debug.WriteLine("[UserDAL] Login success");

            return new User
            {
                Id = Convert.ToInt32(row["id"]),
                Username = row["username"].ToString(),
                Password = row["password"].ToString(),
                CreateTime = Convert.ToDateTime(row["create_time"])
            };
        }

        public bool Register(string username, string password)
        {
            Debug.WriteLine("[UserDAL] Register()");
            Debug.WriteLine($"[Input] username={username}");

            string checkSql = "SELECT COUNT(*) FROM user WHERE username=@u";
            int count = Convert.ToInt32(DBHelper.ExecuteScalar(checkSql,
                new MySqlParameter("@u", username)));

            Debug.WriteLine("[UserDAL] Username count = " + count);

            if (count > 0)
            {
                Debug.WriteLine("[UserDAL] Username exists");
                return false;
            }

            string insertSql = "INSERT INTO user(username, password) VALUES(@u, @p)";
            int rows = DBHelper.ExecuteNonQuery(insertSql,
                new MySqlParameter("@u", username),
                new MySqlParameter("@p", password)
            );

            Debug.WriteLine("[UserDAL] Insert rows = " + rows);
            return rows > 0;
        }
    }
}
