using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Coffee_Restaurent_Manager.Services
{
    internal class SqlService : IDisposable
    {
        
        private SqlConnection conn;
        public SqlService()
        {
            var connection = ConfigurationManager.ConnectionStrings["CoffeeRestaurentDb"].ConnectionString;
            conn = new SqlConnection();
            
            conn.ConnectionString = connection;
            conn.Open();
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
            string[] arr = { };
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
