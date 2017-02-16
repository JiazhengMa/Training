
+using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClassSystem.db
{
    public class SqlHelper
    {
        static public string address = "server=.;uid=sa;pwd=123;database=CurriculumDB";

        static public int ExecuteSql(string StrSql)
        {
            int count = -1;
            SqlConnection conn = new SqlConnection(address);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(StrSql, conn);
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        static public object ExecScalar(string selectSQL)
        {
            SqlConnection conn = new SqlConnection(address);
            SqlCommand command = new SqlCommand(selectSQL, conn);
            try
            {
                conn.Open();
                return command.ExecuteScalar();
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        static public void FillList(DataTable tb, ref WindowsFormsAero.ListView list)
        {
            list.Items.Clear();
            if (tb != null)
            {
                foreach (DataRow item in tb.Rows)
                {
                    ListViewItem Listitem = new ListViewItem(item[tb.Columns[0]].ToString());
                    for (int i = 1; i < tb.Columns.Count; i++)
                    {
                        Listitem.SubItems.Add(item[tb.Columns[i]].ToString());
                    }
                    list.Items.Add(Listitem);
                }
            }
        }

        static public DataTable ExecuteDt(String StrSql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(address))
            {
                SqlDataAdapter da = new SqlDataAdapter(StrSql, conn);

                try
                {
                    conn.Open();
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    dt = null;
                }
                finally
                {
                    conn.Close();
                }
                return dt;
            }
        }
    }
}
