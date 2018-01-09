using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace 登陆界面
{
    public class SQLHelper
    {
        private static int n;
        //错误次数
        private static int errorTimes;
        private static List<String> list = new List<string>();

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

        #region DataReader
        public static DataTable DataReader(string sql, params SqlParameter[] pams)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                DataTable table = new DataTable();
                cmd.CommandText = sql;
                if (pams != null)
                {
                    cmd.Parameters.AddRange(pams);
                }
                IDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                conn.Close();
                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region DataSet
        public static DataTable DataSet(string sql, params SqlParameter[] pams)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter apter = new SqlDataAdapter();
                apter.SelectCommand = cmd;
                DataSet dataset = new DataSet();
                DataTable table = new DataTable();
                
                cmd.CommandText = sql;
                if (pams != null)
                {
                    cmd.Parameters.AddRange(pams);
                }
                apter.Fill(dataset, "T_Student");
                table = dataset.Tables["T_Student"];
                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}
