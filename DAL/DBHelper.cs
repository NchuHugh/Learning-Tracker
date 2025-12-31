using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Learning_Tracker.DAL
{
    public class DBHelper
    {
        private static readonly string connStr = "server=localhost;port=3306;database=learning_tracker;user=root;password=1234;";

        /// <summary>
        /// 获取数据库连接
        /// </summary>
       private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
        /// <summary>
        /// 执行增删改操作（INSERT / UPDATE / DELETE）
        /// </summary>
        public static int ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// 执行查询，返回 DataTable
        /// </summary>
        public static DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    if (parameters != null)
                        adapter.SelectCommand.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        /// <summary>
        /// 执行查询，返回单个值（如 count(*)）
        /// </summary>
        public static object ExecuteScalar(string sql, params MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
