using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Restaurent_Manager.Services;

namespace Coffee_Restaurent_Manager.Forms
{
    public partial class LoginForm : Form
    {
        SqlService sqlService;
        Coffee_Restaurent_Manager.MainForm mainForm;
        public bool IsLoggedIn { get; set; }
        public LoginForm()
        {
            mainForm = new MainForm();
            InitializeComponent();
            sqlService = new SqlService();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu Form2 đang được hiển thị thì hủy sự kiện đóng form
            
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextbox.Text;
            string password = this.passwordTextbox.Text;

            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Hãy điền username và password!","Lỗi");
            }
            else
            {
                string hashPassword = CustomeLib.GeneratorMD5(password);
                //MessageBox.Show(hashPassword);
                var res = sqlService.Login(username, hashPassword);
                if (res)
                {
                    this.Close();
                    IsLoggedIn = true;
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                }
            }
        }
    }
}
