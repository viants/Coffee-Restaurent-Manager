using Coffee_Restaurent_Manager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Restaurent_Manager.Forms.SubForms
{
    public partial class StaffForm : UserControl
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void btn_StaffListAll_Click(object sender, EventArgs e)
        {
            using(SqlService sqlService = new SqlService())
            {
                DataTable dt = sqlService.GetDataSPExecute("sp_ListAllStaff");
                this.dataView.DataSource = dt;
            }
        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            using (SqlService sqlService = new SqlService())
            {
                DataTable dt = sqlService.GetDataSPExecute("sp_SalaryListAll");
                this.dataView.DataSource = dt;
            }
        }
    }
}
