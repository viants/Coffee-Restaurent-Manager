using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace CoffeeRestaurentTeleBot.Services
{
    internal class SqlService : IDisposable
    {
        
        private SqlConnection conn = new SqlConnection();
        public SqlService()
        {
            string connection = ConfigurationManager.ConnectionStrings["CoffeeRestaurentDb"].ConnectionString;
            conn.ConnectionString = connection;
            conn.Open();
        }

        
        public int ExcuseScalarQuery(string sql)
        {
            int res = -1;
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                //MessageBox.Show(cmd.ExecuteScalar().ToString());
                res = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return res;
        }

        public bool PutDataQuery(string query)
        {
            bool res = false;
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                //MessageBox.Show(cmd.ExecuteScalar().ToString());
                res = Convert.ToBoolean(cmd.ExecuteScalar());
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return res;
        }

        public DataTable GetDataQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

            return dt;
        }

        public int ExcureNonQuery(string query)
        {
            int res = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                res = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return res;
        }

        public DataTable GetDataSPExecute(string spName, string[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spName;
                if (parameter != null)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        // Tạo tham số và thêm vào SqlCommand.Parameters
                        SqlParameter param = new SqlParameter($"@param{i}", SqlDbType.NVarChar);
                        param.Value = parameter[i];
                        cmd.Parameters.Add(param);
                    }
                }
                SqlDataReader dataReader = cmd.ExecuteReader();
                cmd.Dispose();
                dataTable.Load(dataReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                throw new Exception();
            }
            return dataTable;
        }

        public bool Login(string userName, string password)
        {
            bool res = false;
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_login";
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = userName;
                cmd.Parameters.Add("@hashKey", SqlDbType.NVarChar).Value = password;
                res = Convert.ToBoolean( cmd.ExecuteScalar());
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                throw new Exception();
            }
            return res;
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }

    }
}
