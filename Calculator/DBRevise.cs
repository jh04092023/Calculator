using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;

namespace DBReviseTool
{
    class DBRevise
    {
        private const string sqlStr = "server=.;database=db_Test;user=sa;password=1234.com;";
        private SqlConnection con;
        private SqlCommand cmd;

        public DBRevise()
        {
            con = new SqlConnection(sqlStr);
            con.Open();
        }
        /// <summary>
        /// 查询数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet QueryDatabase(string sql)
        {
            DataSet ds = new DataSet();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd = new SqlCommand(sql, con);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = cmd;
            data.Fill(ds);
            return ds;
        }
        /// <summary>
        /// 清除数据库
        /// </summary>
        /// <param name="sql"></param>
        public void ClearDatabase(string sql)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string strSQL = sql;
            cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private static void BulkToDB(DataTable dt)
        {
            Stopwatch sw = new Stopwatch();
            SqlConnection sqlconn = new SqlConnection(sqlStr);
            SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlconn);
            bulkCopy.DestinationTableName = "CalculatorData_Table";
            bulkCopy.BatchSize = dt.Rows.Count;
            try
            {
                sqlconn.Open();

                if (dt != null && dt.Rows.Count != 0)

                {
                    bulkCopy.WriteToServer(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();

                if (bulkCopy != null)
                {
                    bulkCopy.Close();
                }
            }
        }
        private static DataTable GetTableSchema()

        {

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[] {

                 new DataColumn("时间",typeof(string)),

                 new DataColumn("表达式",typeof(string)),

                 new DataColumn("运算结果",typeof(string)),});

            return dt;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="_expression"></param>
        /// <param name="_outcome"></param>
        public static void BulkInsert(string _expression, string _outcome)

        {
            DataTable dt = GetTableSchema();

            DataRow r = dt.NewRow();

            r[0] = string.Format($"{System.DateTime.Now.ToString("F")}");

            r[1] = string.Format($"{_expression + _outcome}");

            r[2] = string.Format($"{_outcome}");

            dt.Rows.Add(r);

            BulkToDB(dt);
        }
        /// <summary>
        /// 释放数据库资源
        /// </summary>
        public void ReleaseDatabase()
        {
            con.Close();
        }
    }
 }
