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

namespace Coffee_Restaurent_Manager
{
    public partial class MainForm : Form
    {
        private Point lastLocation;
        private bool isDragging = false;
        private List<UserControl> userControls = new List<UserControl>();
        public MainForm()
        {
            InitializeComponent();
            DrawingWindows();
            userControls.Add(this.dashboard1);
            userControls.Add(this.staffForm1);
            userControls.Add(this.order1);
        }
        private void HideAllUserControls()
        {
            foreach (var userControl in userControls)
            {
                userControl.Visible = false;
            }
        }
        private void ShowUserControl(UserControl userControl)
        {
            HideAllUserControls();
            userControl.Visible = true;
        }

        private void DrawingWindows()
        {
            if(!this.MaximizeBox)
            {
                customeControlBox.MouseDown += (sender, e) =>
                {
                    isDragging = true;
                    lastLocation = e.Location;
                };

                customeControlBox.MouseMove += (sender, e) =>
                {
                    if (isDragging && !this.MaximizeBox)
                    {
                        Location = new Point(
                            Location.X - lastLocation.X + e.X,
                            Location.Y - lastLocation.Y + e.Y);
                    }
                };

                customeControlBox.MouseUp += (sender, e) =>
                {
                    isDragging = false;
                };
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            ShowUserControl(this.dashboard1);
        }

        private void btn_ClosedWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MaxWindows_Click(object sender, EventArgs e)
        {
            
            if(!this.MaximizeBox)
            {
                this.MaximizeBox = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.MaximizeBox = false;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Normal;
                
            }
            
        }

        private void btn_MinWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            ShowUserControl(this.dashboard1);
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            ShowUserControl(this.staffForm1);
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            ShowUserControl(this.order1);
        }
    }
}
