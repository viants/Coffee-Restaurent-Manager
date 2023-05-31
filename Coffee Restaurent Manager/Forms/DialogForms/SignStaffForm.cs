using Coffee_Restaurent_Manager.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Coffee_Restaurent_Manager.Forms.DialogForms
{
    public partial class SignStaffForm : Form
    {
        DateTime time=DateTime.Now;
        public SignStaffForm()
        {
            InitializeComponent();
        }

        void Update(string date)
        {
            string query = $@"SELECT ts.StaffId as [Mã nhân viên], 
                            s.Name as [Họ tên],
                            ts.Date as [Ngày],
                            CASE WHEN ts.IsPresent = 1 THEN N'Có mặt' ELSE N'Nghỉ' END AS [Trạng thái],
                            ts.DayReceivedAmount AS [Lương]
                            FROM Timesheets ts LEFT JOIN Staffs s ON ts.StaffId =s.Id 
                            WHERE ts.Date = '{date}'";
            string sql_1 = $@"SELECT COUNT(*) AS Result FROM Timesheets WHERE Date = '{date}' AND Timesheets.IsPresent = 1";
            string sql_2 = $@"SELECT COUNT(*) AS Result FROM Staffs";
            int staffsOnWork = 0, staffsTotal = 0, staffsAbsent = 0;
            using (SqlService sql = new SqlService())
            {
                DataTable dt = sql.GetDataQuery(query);
                this.dataGridView1.DataSource = dt;
                staffsOnWork = sql.ExcuseScalarQuery(sql_1);
                staffsTotal = sql.ExcuseScalarQuery(sql_2);
                staffsAbsent = staffsTotal - staffsOnWork;
            }
            this.label_onwork.Text = staffsOnWork.ToString() + " (Staff)";
            this.label_absent.Text = staffsAbsent.ToString() + " (Staff)";
        }

        private void SignStaffForm_Load(object sender, EventArgs e)
        {
            var date = time.Date.ToString("yyyy/MM/dd");
            this.label_Date.Text = time.Date.ToString("dd/MM/yyyy");
            //MessageBox.Show(date);
            Update(date);
        }

        //Add
        private void rjButton1_Click(object sender, EventArgs e)
        {
            var date = time.Date.ToString("yyyy/MM/dd");
            using (SqlService sql = new SqlService())
            {
                int id;
                bool res = int.TryParse(this.textBox_id.Text,out id);
                if(res)
                {
                    string query = $@"exec sp_signin_timesheet @id = {id}";
                    bool result = sql.PutDataQuery(query);
                    if(result)
                    {
                        Update(date);
                        MessageBox.Show("Done 😊", "Notication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong id, please try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
            }
        }

        //Remove
        private void rjButton2_Click(object sender, EventArgs e)
        {
            var id = this.dataGridView1.SelectedCells[0].Value.ToString();
            var date = time.Date.ToString("yyyy/MM/dd");

            using (SqlService sql = new SqlService())
            {
                string query = $@"DELETE FROM Timesheets WHERE Timesheets.StaffId = {id} AND Timesheets.Date = '{date}'";
                int res = sql.ExcureNonQuery(query);
                if (res > 0)
                {
                    Update(date);
                    MessageBox.Show("Record was removed", "Notication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
