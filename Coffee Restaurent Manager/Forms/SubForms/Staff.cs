using Coffee_Restaurent_Manager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Restaurent_Manager.Forms.SubForms
{
    public partial class Staff : UserControl
    {
        
        public Staff()
        {
            InitializeComponent();
            
        }


        private void btn_StaffListAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            /*using (SqlService sqlService = new SqlService())
            {
                DataTable dt = new DataTable();
                dt = sqlService.GetDataSPExecute("sp_ListAllStaff");
                dataView.DataSource = dt;
            }*/
        }

        private void btn_Sign_Click(object sender, EventArgs e)
        {

        }
    }
}
