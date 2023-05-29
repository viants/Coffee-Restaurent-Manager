using System.Drawing;

namespace Coffee_Restaurent_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customeControlBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_MinWindows = new CustomControls.RJControls.RJButton();
            this.btn_MaxWindows = new CustomControls.RJControls.RJButton();
            this.btn_ClosedWindows = new CustomControls.RJControls.RJButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_Setting = new CustomControls.RJControls.RJButton();
            this.btn_Delivery = new CustomControls.RJControls.RJButton();
            this.btn_Store = new CustomControls.RJControls.RJButton();
            this.btn_Staff = new CustomControls.RJControls.RJButton();
            this.btn_Order = new CustomControls.RJControls.RJButton();
            this.btn_DashBoard = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search = new CustomControls.RJControls.RJButton();
            this.staffForm1 = new Coffee_Restaurent_Manager.Forms.SubForms.StaffForm();
            this.dashboard1 = new Coffee_Restaurent_Manager.Forms.SubForms.Dashboard();
            this.customeControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customeControlBox
            // 
            this.customeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customeControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.customeControlBox.Controls.Add(this.pictureBox1);
            this.customeControlBox.Controls.Add(this.btn_MinWindows);
            this.customeControlBox.Controls.Add(this.btn_MaxWindows);
            this.customeControlBox.Controls.Add(this.btn_ClosedWindows);
            this.customeControlBox.Location = new System.Drawing.Point(0, 0);
            this.customeControlBox.Name = "customeControlBox";
            this.customeControlBox.Size = new System.Drawing.Size(931, 35);
            this.customeControlBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee_Restaurent_Manager.Properties.Resources.cup;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_MinWindows
            // 
            this.btn_MinWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.btn_MinWindows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.btn_MinWindows.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_MinWindows.BorderRadius = 10;
            this.btn_MinWindows.BorderSize = 0;
            this.btn_MinWindows.FlatAppearance.BorderSize = 0;
            this.btn_MinWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_MinWindows.ForeColor = System.Drawing.Color.White;
            this.btn_MinWindows.Location = new System.Drawing.Point(815, 7);
            this.btn_MinWindows.Name = "btn_MinWindows";
            this.btn_MinWindows.Size = new System.Drawing.Size(22, 22);
            this.btn_MinWindows.TabIndex = 5;
            this.btn_MinWindows.Text = "_";
            this.btn_MinWindows.TextColor = System.Drawing.Color.White;
            this.btn_MinWindows.UseVisualStyleBackColor = false;
            this.btn_MinWindows.Click += new System.EventHandler(this.btn_MinWindows_Click);
            // 
            // btn_MaxWindows
            // 
            this.btn_MaxWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaxWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.btn_MaxWindows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.btn_MaxWindows.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_MaxWindows.BorderRadius = 10;
            this.btn_MaxWindows.BorderSize = 0;
            this.btn_MaxWindows.FlatAppearance.BorderSize = 0;
            this.btn_MaxWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaxWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_MaxWindows.ForeColor = System.Drawing.Color.White;
            this.btn_MaxWindows.Location = new System.Drawing.Point(853, 7);
            this.btn_MaxWindows.Name = "btn_MaxWindows";
            this.btn_MaxWindows.Size = new System.Drawing.Size(22, 22);
            this.btn_MaxWindows.TabIndex = 4;
            this.btn_MaxWindows.Text = "▢";
            this.btn_MaxWindows.TextColor = System.Drawing.Color.White;
            this.btn_MaxWindows.UseVisualStyleBackColor = false;
            this.btn_MaxWindows.Click += new System.EventHandler(this.btn_MaxWindows_Click);
            // 
            // btn_ClosedWindows
            // 
            this.btn_ClosedWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClosedWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.btn_ClosedWindows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.btn_ClosedWindows.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ClosedWindows.BorderRadius = 10;
            this.btn_ClosedWindows.BorderSize = 0;
            this.btn_ClosedWindows.FlatAppearance.BorderSize = 0;
            this.btn_ClosedWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClosedWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ClosedWindows.ForeColor = System.Drawing.Color.White;
            this.btn_ClosedWindows.Location = new System.Drawing.Point(888, 7);
            this.btn_ClosedWindows.Name = "btn_ClosedWindows";
            this.btn_ClosedWindows.Size = new System.Drawing.Size(22, 22);
            this.btn_ClosedWindows.TabIndex = 4;
            this.btn_ClosedWindows.Text = "X";
            this.btn_ClosedWindows.TextColor = System.Drawing.Color.White;
            this.btn_ClosedWindows.UseVisualStyleBackColor = false;
            this.btn_ClosedWindows.Click += new System.EventHandler(this.btn_ClosedWindows_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.btn_Setting);
            this.leftPanel.Controls.Add(this.btn_Delivery);
            this.leftPanel.Controls.Add(this.btn_Store);
            this.leftPanel.Controls.Add(this.btn_Staff);
            this.leftPanel.Controls.Add(this.btn_Order);
            this.leftPanel.Controls.Add(this.btn_DashBoard);
            this.leftPanel.Location = new System.Drawing.Point(0, 35);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(185, 545);
            this.leftPanel.TabIndex = 4;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Setting.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Setting.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Setting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Setting.BorderRadius = 0;
            this.btn_Setting.BorderSize = 0;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Location = new System.Drawing.Point(-1, 457);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(185, 54);
            this.btn_Setting.TabIndex = 9;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.TextColor = System.Drawing.Color.White;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Delivery
            // 
            this.btn_Delivery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Delivery.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Delivery.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Delivery.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Delivery.BorderRadius = 0;
            this.btn_Delivery.BorderSize = 0;
            this.btn_Delivery.FlatAppearance.BorderSize = 0;
            this.btn_Delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delivery.ForeColor = System.Drawing.Color.White;
            this.btn_Delivery.Location = new System.Drawing.Point(0, 315);
            this.btn_Delivery.Name = "btn_Delivery";
            this.btn_Delivery.Size = new System.Drawing.Size(185, 58);
            this.btn_Delivery.TabIndex = 6;
            this.btn_Delivery.Text = "Delivery";
            this.btn_Delivery.TextColor = System.Drawing.Color.White;
            this.btn_Delivery.UseVisualStyleBackColor = false;
            // 
            // btn_Store
            // 
            this.btn_Store.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Store.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Store.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Store.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Store.BorderRadius = 0;
            this.btn_Store.BorderSize = 0;
            this.btn_Store.FlatAppearance.BorderSize = 0;
            this.btn_Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Store.ForeColor = System.Drawing.Color.White;
            this.btn_Store.Location = new System.Drawing.Point(0, 374);
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(185, 58);
            this.btn_Store.TabIndex = 8;
            this.btn_Store.Text = "Store";
            this.btn_Store.TextColor = System.Drawing.Color.White;
            this.btn_Store.UseVisualStyleBackColor = false;
            // 
            // btn_Staff
            // 
            this.btn_Staff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Staff.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Staff.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Staff.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Staff.BorderRadius = 0;
            this.btn_Staff.BorderSize = 0;
            this.btn_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Location = new System.Drawing.Point(0, 256);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(185, 58);
            this.btn_Staff.TabIndex = 6;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.TextColor = System.Drawing.Color.White;
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Order.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Order.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Order.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Order.BorderRadius = 0;
            this.btn_Order.BorderSize = 0;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(0, 197);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(185, 58);
            this.btn_Order.TabIndex = 6;
            this.btn_Order.Text = "Order";
            this.btn_Order.TextColor = System.Drawing.Color.White;
            this.btn_Order.UseVisualStyleBackColor = false;
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_DashBoard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DashBoard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DashBoard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DashBoard.BorderRadius = 0;
            this.btn_DashBoard.BorderSize = 0;
            this.btn_DashBoard.FlatAppearance.BorderSize = 0;
            this.btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DashBoard.ForeColor = System.Drawing.Color.White;
            this.btn_DashBoard.Location = new System.Drawing.Point(0, 138);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Size = new System.Drawing.Size(185, 58);
            this.btn_DashBoard.TabIndex = 6;
            this.btn_DashBoard.Text = "Dashboard";
            this.btn_DashBoard.TextColor = System.Drawing.Color.White;
            this.btn_DashBoard.UseVisualStyleBackColor = false;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 69);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(650, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_search.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btn_search.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btn_search.BorderRadius = 5;
            this.btn_search.BorderSize = 1;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(827, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(69, 26);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.TextColor = System.Drawing.Color.White;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // staffForm1
            // 
            this.staffForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffForm1.Location = new System.Drawing.Point(185, 104);
            this.staffForm1.Name = "staffForm1";
            this.staffForm1.Size = new System.Drawing.Size(725, 446);
            this.staffForm1.TabIndex = 7;
            // 
            // dashboard1
            // 
            this.dashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard1.BackColor = System.Drawing.SystemColors.Control;
            this.dashboard1.Location = new System.Drawing.Point(185, 104);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(748, 452);
            this.dashboard1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 546);
            this.ControlBox = false;
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customeControlBox);
            this.Controls.Add(this.staffForm1);
            this.Controls.Add(this.dashboard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.customeControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel customeControlBox;
        private CustomControls.RJControls.RJButton btn_MaxWindows;
        private CustomControls.RJControls.RJButton btn_ClosedWindows;
        private CustomControls.RJControls.RJButton btn_MinWindows;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private CustomControls.RJControls.RJButton btn_search;
        private CustomControls.RJControls.RJButton btn_Delivery;
        private CustomControls.RJControls.RJButton btn_Store;
        private CustomControls.RJControls.RJButton btn_Staff;
        private CustomControls.RJControls.RJButton btn_Order;
        private CustomControls.RJControls.RJButton btn_DashBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Forms.SubForms.Dashboard dashboard1;
        private CustomControls.RJControls.RJButton btn_Setting;
        private Forms.SubForms.StaffForm staffForm1;
    }
}

