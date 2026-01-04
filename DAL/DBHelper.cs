using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace Learning_Tracker.DAL
{
    public class DBHelper
    {
        private static readonly string connStr =
            "server=localhost;port=3306;database=learning_tracker;user=root;password=1234;";

        private static MySqlConnection CreateConnection()
        {
            Debug.WriteLine("[DB] CreateConnection()");
            return new MySqlConnection(connStr);
        }

        public static int ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            Debug.WriteLine("[DB] ExecuteNonQuery");
            Debug.WriteLine("[SQL] " + sql);

            using (MySqlConnection conn = CreateConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        Debug.WriteLine($"[PARAM] {p.ParameterName} = {p.Value}");

                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                Debug.WriteLine("[DB] Affected rows = " + rows);
                return rows;
            }
        }

        public static DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters)
        {
            Debug.WriteLine("[DB] ExecuteQuery");
            Debug.WriteLine("[SQL] " + sql);

            using (MySqlConnection conn = CreateConnection())
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        Debug.WriteLine($"[PARAM] {p.ParameterName} = {p.Value}");

                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Debug.WriteLine("[DB] Rows returned = " + dt.Rows.Count);
                return dt;
            }
        }

        public static object ExecuteScalar(string sql, params MySqlParameter[] parameters)
        {
            Debug.WriteLine("[DB] ExecuteScalar");
            Debug.WriteLine("[SQL] " + sql);

            using (MySqlConnection conn = CreateConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        Debug.WriteLine($"[PARAM] {p.ParameterName} = {p.Value}");

                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                object result = cmd.ExecuteScalar();
                Debug.WriteLine("[DB] Scalar result = " + (result ?? "null"));
                return result;
            }
        }
    }
}
