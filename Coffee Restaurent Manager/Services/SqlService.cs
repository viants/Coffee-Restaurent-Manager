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
using System.Net;
using System.Xml.Linq;

namespace Coffee_Restaurent_Manager.Services
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

        public bool AddStaff(
            int id,
            int roleId,
            bool gender,
            string name = null,
            string phoneNumber = null,
            string address = null,
            string email = null,
            string avatar = null
            )
        {
            bool result = false;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_add_staff";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@roleId", SqlDbType.Int).Value = roleId;
            cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phoneNumber; 
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@avatar", SqlDbType.NVarChar).Value = avatar;
            cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
            try
            {
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public int UpdateStaff(
            int id,
            int roleId,
            bool gender,
            string name = null,
            string phoneNumber = null,
            string address = null,
            string email = null,
            string avatar = null)
        {
            int res = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_staff";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@roleId", SqlDbType.Int).Value = roleId;
            cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phoneNumber; 
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@avatar", SqlDbType.NVarChar).Value = avatar;
            cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = gender;
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
