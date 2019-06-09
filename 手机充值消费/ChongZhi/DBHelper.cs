using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChongZhi
{
    class DBHelper
    {
        //数据库连接字符串
        public static string connstring = "Data Source=.;Initial Catalog=GameBoxDB;Integrated Security=True";
        //数据库连接对象
        public static SqlConnection conn = null;
        //初始化数据库连接
        public static void InitConnection()
        {
            //若连接对象不存在，则创建连接
            if (conn == null)
                conn = new SqlConnection(connstring);
            //若连接对象关闭，则打开连接
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //若连接中断，则重启连接
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }

        }
        //增删改
        public static bool ExecuteNonQuery(string sql)
        {
            InitConnection();
            SqlCommand command = new SqlCommand(sql, conn);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //查询（聚合函数）
        public static object ExecuteScalar(string sql)
        {
            InitConnection();
            SqlCommand command = new SqlCommand(sql, conn);
            object result = command.ExecuteScalar();
            conn.Close();
            return result;
        }
        //查询（表）
        public static DataTable GetDataTable(string sql)
        {
            InitConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //查询,获取DataReader
        public static SqlDataReader GetDataReader(string sql)
        {
            InitConnection();
            SqlCommand command = new SqlCommand(sql, conn);
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
