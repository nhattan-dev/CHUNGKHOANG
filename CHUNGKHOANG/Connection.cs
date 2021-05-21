using CHUNGKHOANG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOANG
{
    class Connection
    {
        public static string sqlcon;
        public static SqlConnection Getconnection()
        {
            sqlcon = "server =" + THONGTIN._datasource + "; uid= " + THONGTIN._username + "; pwd= " + THONGTIN._password + "; database = " + THONGTIN._database;
            SqlConnection con = new SqlConnection(sqlcon);
            return con;
        }
        public static int RequestStatus(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {

            SqlConnection conn = null;
            int RequestStatus = -1;
            try
            {
                conn = Getconnection();
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = strQuery;
                sqlcmd.Connection = conn;
                sqlcmd.CommandType = cmdtype;

                SqlParameter sqlpara;
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];
                    sqlcmd.Parameters.Add(sqlpara);
                }
                sqlpara = new SqlParameter("@RequestStatus", SqlDbType.Int);
                sqlpara.Direction = ParameterDirection.ReturnValue;
                sqlcmd.Parameters.Add(sqlpara);
                sqlcmd.ExecuteNonQuery();
                RequestStatus = (int)sqlcmd.Parameters["@RequestStatus"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return RequestStatus;

        }
    }
}
