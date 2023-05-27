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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        DateTime date = DateTime.Now;
        private void Update()
        {
            string query = $@"SELECT ts.StaffId as [Mã nhân viên], 
                            s.Name as [Họ tên],
                            ts.Date as [Ngày],
                            CASE WHEN ts.IsPresent = 1 THEN N'Có mặt' ELSE N'Nghỉ' END AS [Trạng thái],
                            ts.DayReceivedAmount AS [Lương]
                            FROM Timesheets ts LEFT JOIN Staffs s ON ts.StaffId =s.Id 
                            WHERE ts.Date = '{date.ToString("yyyy/MM/dd")}'";
            string sql_1 = $@"SELECT COUNT(*) AS Result FROM Timesheets WHERE Date = '{date.ToString("yyyy/MM/dd")}' AND Timesheets.IsPresent = 1";
            string sql_2 = $@"SELECT COUNT(*) AS Result FROM Staffs";
            string sql_3 = $@"SELECT COUNT(*) AS Result FROM Products";
            int staffsOnWork = 0, staffsTotal = 0, staffsAbsent = 0, productCount = 0;
            using (SqlService sql = new SqlService())
            {
                DataTable dt = sql.GetDataQuery(query);
                staffsOnWork = sql.ExcuseScalarQuery(sql_1);
                staffsTotal = sql.ExcuseScalarQuery(sql_2);
                productCount = sql.ExcuseScalarQuery(sql_3);
                staffsAbsent = staffsTotal - staffsOnWork;
            }
            this.label_absent.Text = staffsAbsent.ToString() ;
            this.label_onwork.Text = staffsOnWork.ToString();
            this.label_product.Text = productCount.ToString() ;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Update();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
