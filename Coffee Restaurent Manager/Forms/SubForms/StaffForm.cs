using Coffee_Restaurent_Manager.Forms.DialogForms;
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

        private string tableSelect;
        public void UpdateDataTable(string sp)
        {
            tableSelect = "Staffs";
            this.dateTimePicker1.Visible = false;
            using (SqlService sqlService = new SqlService())
            {
                DataTable dt = sqlService.GetDataSPExecute(sp);
                this.dataView.DataSource = dt;
            }
        }
        
        private void btn_StaffListAll_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = false;
            UpdateDataTable("sp_ListAllStaff");

        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            tableSelect = "Salaries";
            using (SqlService sqlService = new SqlService())
            {
                this.dateTimePicker1.Visible = true;
                DataTable dt = sqlService.GetDataSPExecute("sp_SalaryListAll");
                this.dataView.DataSource = dt;
            }
        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
            if(addStaffForm.DialogResult == DialogResult.OK)
            {
                UpdateDataTable("sp_ListAllStaff");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            UpdateDataTable("sp_ListAllStaff");
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tableSelect == "Staffs")
            {
                int Id = int.Parse(dataView.SelectedCells[0].Value.ToString());
                UpdateStaffForm updateStaffForm = new UpdateStaffForm(Id, this);
                updateStaffForm.ShowDialog();
            }
            
        }

        private void dataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
