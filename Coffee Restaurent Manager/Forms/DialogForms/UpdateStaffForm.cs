using Coffee_Restaurent_Manager.Forms.SubForms;
using Coffee_Restaurent_Manager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Restaurent_Manager.Forms.DialogForms
{
    public partial class UpdateStaffForm : Form
    {
        private int Id;
        private DataTable staffTb;
        private DataTable rolesTb;
        private StaffForm staffForm;
        private string selectedFileName = "";
        public UpdateStaffForm(int Id, StaffForm staffForm)
        {
            InitializeComponent();
            this.Id = Id;
            this.staffTb = new DataTable();
            SqlService sqlService = new SqlService();
            this.staffTb = sqlService.GetDataQuery($"SELECT * FROM Staffs WHERE Id = {Id}");
            this.rolesTb = sqlService.GetDataQuery($"SELECT * FROM Roles");
            this.staffForm = staffForm;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
        private void btn_create_Click(object sender, EventArgs e)
        {
            int id = 0;
            int res = -1;
            if (!int.TryParse(this.textBox_Id.Text, out id))
            {
                MessageBox.Show("Staff identity should be a integer number and not null", "Error");
                return;
            }
            string Name = this.textBox_Name.Text;
            string Email = this.textBox_Email.Text;
            string Address = this.textBox_Address.Text;
            string Avatar = this.selectedFileName;
            string PhoneNumber = this.textBox_Phone.Text;
            bool Gender;
            if (this.comboBox_Gender.SelectedIndex == 0)
                Gender = true;
            else
                Gender = false;
            int RoleId = Convert.ToInt32(roleSelect.SelectedValue);
            using(SqlService sqlService = new SqlService())
            {
                res = sqlService.UpdateStaff(id,
                    RoleId,
                    Gender,
                    Name,
                    PhoneNumber,
                    Address,
                    Email,
                    Avatar);
            }
            
            if(res == 1)
            {
                staffForm.UpdateDataTable("sp_ListAllStaff");
                MessageBox.Show("Success", "Notication");
            }
        }

        private void UpdateStaffForm_Load(object sender, EventArgs e)
        {
            if(staffTb.Rows.Count > 0)
            {
                DataRow row = staffTb.Rows[0];
                this.textBox_Id.Text = row["Id"].ToString();
                this.textBox_Name.Text = row["Name"].ToString();
                this.textBox_Email.Text = row["Email"].ToString();
                this.textBox_Address.Text = row["Address"].ToString();
                this.textBox_Phone.Text = row["NumberPhone"].ToString();
                if(bool.Parse(row["Gender"].ToString()) == true)
                    this.comboBox_Gender.SelectedIndex = 0;
                else
                    this.comboBox_Gender.SelectedIndex = 1;
                this.roleSelect.DataSource = rolesTb;
                this.roleSelect.ValueMember = "Id";
                this.roleSelect.DisplayMember = "Name";
                this.roleSelect.SelectedValue = int.Parse(row["RoleId"].ToString());
                if( !String.IsNullOrEmpty(row["AvatarUri"].ToString()))
                {
                    string avtPath = row["AvatarUri"].ToString();
                    if (File.Exists(avtPath))
                    {
                        this.avatarPic.Image = Image.FromFile(avtPath);
                    }
                }
                
                
            }
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_Id.Text))
            {
                label7.Text = "It's empty!";
                label7.Visible = true;
            }
            else
            {
                int value;
                bool res = int.TryParse(textBox_Id.Text, out value);
                if (!res)
                {
                    label7.Text = "It's not a number!";
                    label7.Visible = true;
                }
                else
                {
                    label7.Visible = false;
                }
            }
            
        }

        private void btn_uploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Chose an image (*.jpeg, *.jpg, *.png)|*.png; *.jpg; *.jpeg;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog1.FileName;
                //...
                //MessageBox.Show(selectedFileName);
                avatarPic.Image = Image.FromFile(selectedFileName);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to do that?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes) 
            {
                int res = 0;
                using (SqlService sql = new SqlService())
                {
                    res = sql.ExcureNonQuery($"DELETE FROM Staffs WHERE Id = {this.Id}");
                    
                }
                if  (res == 1)
                {
                    MessageBox.Show($"Deleted staff id: {this.Id}", "Notication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.staffForm.UpdateDataTable("sp_ListAllStaff");
                    this.Dispose();
                }
            }
            
        }
    }
}
