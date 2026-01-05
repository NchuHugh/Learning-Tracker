using Learning_Tracker.DAL;
using Learning_Tracker.Models;
using MySql.Data.MySqlClient;
using System.Data;

public static class StudyRecordDAL
{
    public static List<StudyRecord> GetByUserId(int userId)
    {
        string sql = @"SELECT id, subject, content, study_time,
                              study_date, create_time
                       FROM study_record
                       WHERE user_id = @userId
                       ORDER BY study_date DESC";

        DataTable dt = DBHelper.ExecuteQuery(
            sql,
            new MySqlParameter("@userId", userId)
        );

        List<StudyRecord> list = new List<StudyRecord>();

        foreach (DataRow row in dt.Rows)
        {
            list.Add(new StudyRecord
            {
                Id = Convert.ToInt32(row["id"]),
                Subject = row["subject"].ToString(),
                Content = row["content"].ToString(),
                StudyTime = Convert.ToInt32(row["study_time"]),
                StudyDate = Convert.ToDateTime(row["study_date"]),
                CreateTime = Convert.ToDateTime(row["create_time"])
            });
        }

        return list;
    }
    /// <summary>
    /// 新增学习记录
    /// </summary>
    public static int Add(StudyRecord record)
    {
        string sql = @"
                INSERT INTO study_record
                    (user_id, subject, content, study_time, study_date)
                VALUES
                    (@userId, @subject, @content, @studyTime, @studyDate)";

        return DBHelper.ExecuteNonQuery(
            sql,
            new MySqlParameter("@userId", record.UserId),
            new MySqlParameter("@subject", record.Subject),
            new MySqlParameter("@content", record.Content),
            new MySqlParameter("@studyTime", record.StudyTime),
            new MySqlParameter("@studyDate", record.StudyDate)
        );
    }

    /// <summary>
    /// 修改学习记录
    /// </summary>
  public static int Update(StudyRecord record)
    {
        string sql = @"
                UPDATE study_record
                SET
                    subject = @subject,
                    content = @content,
                    study_time = @studyTime,
                    study_date = @studyDate
                WHERE id = @id
                  AND user_id = @userId";

        return DBHelper.ExecuteNonQuery(
            sql,
            new MySqlParameter("@subject", record.Subject),
            new MySqlParameter("@content", record.Content),
            new MySqlParameter("@studyTime", record.StudyTime),
            new MySqlParameter("@studyDate", record.StudyDate),
            new MySqlParameter("@id", record.Id),
            new MySqlParameter("@userId", record.UserId)
        );
    }
    /// <summary>
    /// 删除学习记录
    /// </summary>
    public static int Delete(int id, int userId)
    {
        string sql = @"
                DELETE FROM study_record
                WHERE id = @id
                  AND user_id = @userId";

        return DBHelper.ExecuteNonQuery(
            sql,
            new MySqlParameter("@id", id),
            new MySqlParameter("@userId", userId)
        );
    }

    public static bool Exists(int userId, DateTime studyDate)
    {
        string sql = @"
        SELECT COUNT(1)
        FROM study_record
        WHERE user_id = @userId
          AND study_date = @studyDate";

        object result = DBHelper.ExecuteScalar(
            sql,
            new MySqlParameter("@userId", userId),
            new MySqlParameter("@studyDate", studyDate.Date)
        );

        return Convert.ToInt32(result) > 0;
    }


}
