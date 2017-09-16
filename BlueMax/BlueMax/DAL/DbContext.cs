using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace BlueMax.DAL
{
    public class DbContext
    {
        private OleDbConnection Baglan()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BlueMaxDD.accdb");
            conn.Open();
            return (conn);
        }

        /// <summary>
        /// Sql Command
        /// </summary>
        /// <param name="sqlCommand">string sql command</param>
        /// <returns>int</returns>
        public virtual int Cmd(string sqlCommand)
        {
            using (OleDbConnection baglan = this.Baglan())
            {
                using (OleDbCommand sorgu = new OleDbCommand(sqlCommand, baglan))
                {
                    int sonuc = 0;
                    try
                    {
                        sonuc = sorgu.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        baglan.Close();
                        sorgu.Connection.Close();
                    }

                    return sonuc;
                }
            }
        }

        /// <summary>
        /// GetDataCell
        /// </summary>
        /// <param name="sql">string sql command</param>
        /// <returns></returns>
        public virtual string GetDataCell(string sql)
        {
            DataTable table = GetDataTable(sql);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return table.Rows[0][0].ToString();
        }

        /// <summary>
        /// GetDataRow
        /// </summary>
        /// <param name="sql">string sql command</param>
        /// <returns></returns>
        public virtual DataRow GetDataRow(string sql)
        {
            DataTable table = GetDataTable(sql);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return table.Rows[0];
        }

        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <param name="sql">string sql command</param>
        /// <returns>data table</returns>
        public virtual DataTable GetDataTable(string sql)
        {
            using (OleDbConnection baglan = this.Baglan())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, baglan))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                    }
                    catch (OleDbException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        baglan.Close();
                    }

                    return dt;
                }
            }
        }

        /// <summary>
        /// GetDataSet
        /// </summary>
        /// <param name="sql">string sql command</param>
        /// <returns>data set</returns>
        public virtual DataSet GetDataSet(string sql)
        {
            using (OleDbConnection baglan = this.Baglan())
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, baglan))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        adapter.Fill(ds);
                    }
                    catch (OleDbException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        baglan.Close();
                    }

                    return ds;
                }
            }
        }

        /// <summary>
        /// Login User
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="password">string</param>
        /// <returns>int</returns>
        public virtual int LookupUser(string username, string password)
        {
            string query = "Select * From Users Where uName=@user AND uPass=@pass";
            int result = 0;

            using (OleDbConnection baglan = this.Baglan())
            {
                using (OleDbCommand cmd = new OleDbCommand(query, baglan))
                {
                    cmd.Parameters.Add("@user", OleDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@pass", OleDbType.VarChar).Value = password;

                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        //using (DataSet ds = new DataSet())
                        //{
                        //    da.Fill(ds);
                            result = Convert.ToInt32(cmd.ExecuteScalar());
                        //}
                    }
                }
            }
            return result;
        }
    }
}
