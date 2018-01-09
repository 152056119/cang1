using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace 登陆界面
{
    public class SQLHelper
    {
        private static int n;
        //错误次数
        private static int errorTimes;

        //连接字符串
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        #region 更新
        public static void ExecuteNonQuery(string sql, params SqlParameter[] pams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(pams);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 读取
        public static int ExecuteReader(string sql, params SqlParameter[] pams)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(pams);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    errorTimes = (int)reader["ErrorTimes"];
                }
                reader.Close();
                conn.Close();
                return errorTimes;   
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region ExecuteScalar
        public static int ExecuteScalar(string sql, params SqlParameter[] pams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(pams);
                    n = (int)cmd.ExecuteScalar();
                }
            }
            return n;
        }
        #endregion
    }
}
