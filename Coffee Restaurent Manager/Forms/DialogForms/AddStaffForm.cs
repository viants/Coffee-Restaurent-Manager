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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Restaurent_Manager.Forms.DialogForms
{


    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            using (SqlService sqlService = new SqlService())
            {
                rolesTable = sqlService.GetDataQuery("SELECT Id, Name FROM Roles");
            }
            roleSelect.DataSource = rolesTable;
            roleSelect.ValueMember = "Id";
            roleSelect.DisplayMember = "Name";
        }
        DataTable rolesTable = new DataTable();
        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            this.comboBox_Gender.SelectedIndex = 0;
            
            DataRow[] rows = rolesTable.Select("Name = 'Nhân viên'");
            if (rows.Length > 0)
            {
                int roleId = Convert.ToInt32(rows[0]["Id"]);
                roleSelect.SelectedValue = roleId;
            }
        }
        string selectedFileName = "";
        private void btn_create_Click(object sender, EventArgs e)
        {

            int id = 0;
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
            //MessageBox.Show($"{roleSelect.SelectedValue}");

            using (SqlService sqlService = new SqlService())
            {
                bool res = sqlService.AddStaff(
                    id,
                    RoleId,
                    Gender,
                    Name,
                    PhoneNumber,
                    Address,
                    Email,
                    Avatar);
                if (res)
                {
                    MessageBox.Show("Add successful");
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void comboBox_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Id.Text))
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
    }
}
