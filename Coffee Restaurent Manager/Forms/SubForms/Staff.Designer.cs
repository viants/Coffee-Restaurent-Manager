namespace Coffee_Restaurent_Manager.Forms.SubForms
{
    partial class Staff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btn_Sign = new CustomControls.RJControls.RJButton();
            this.btn_AddStaff = new CustomControls.RJControls.RJButton();
            this.btn_Salary = new CustomControls.RJControls.RJButton();
            this.btn_StaffListAll = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(11, 118);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(686, 320);
            this.dataView.TabIndex = 2;
            // 
            // btn_Sign
            // 
            this.btn_Sign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sign.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sign.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sign.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sign.BorderRadius = 0;
            this.btn_Sign.BorderSize = 0;
            this.btn_Sign.FlatAppearance.BorderSize = 0;
            this.btn_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign.ForeColor = System.Drawing.Color.White;
            this.btn_Sign.Location = new System.Drawing.Point(606, 31);
            this.btn_Sign.Name = "btn_Sign";
            this.btn_Sign.Size = new System.Drawing.Size(91, 43);
            this.btn_Sign.TabIndex = 1;
            this.btn_Sign.Text = "Sign";
            this.btn_Sign.TextColor = System.Drawing.Color.White;
            this.btn_Sign.UseVisualStyleBackColor = false;
            this.btn_Sign.Click += new System.EventHandler(this.btn_Sign_Click);
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AddStaff.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AddStaff.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AddStaff.BorderRadius = 0;
            this.btn_AddStaff.BorderSize = 0;
            this.btn_AddStaff.FlatAppearance.BorderSize = 0;
            this.btn_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStaff.ForeColor = System.Drawing.Color.White;
            this.btn_AddStaff.Location = new System.Drawing.Point(209, 72);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Size = new System.Drawing.Size(93, 40);
            this.btn_AddStaff.TabIndex = 1;
            this.btn_AddStaff.Text = "New staff";
            this.btn_AddStaff.TextColor = System.Drawing.Color.White;
            this.btn_AddStaff.UseVisualStyleBackColor = false;
            // 
            // btn_Salary
            // 
            this.btn_Salary.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Salary.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Salary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Salary.BorderRadius = 0;
            this.btn_Salary.BorderSize = 0;
            this.btn_Salary.FlatAppearance.BorderSize = 0;
            this.btn_Salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salary.ForeColor = System.Drawing.Color.White;
            this.btn_Salary.Location = new System.Drawing.Point(110, 72);
            this.btn_Salary.Name = "btn_Salary";
            this.btn_Salary.Size = new System.Drawing.Size(93, 40);
            this.btn_Salary.TabIndex = 1;
            this.btn_Salary.Text = "Salary";
            this.btn_Salary.TextColor = System.Drawing.Color.White;
            this.btn_Salary.UseVisualStyleBackColor = false;
            // 
            // btn_StaffListAll
            // 
            this.btn_StaffListAll.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_StaffListAll.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_StaffListAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_StaffListAll.BorderRadius = 0;
            this.btn_StaffListAll.BorderSize = 0;
            this.btn_StaffListAll.FlatAppearance.BorderSize = 0;
            this.btn_StaffListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StaffListAll.ForeColor = System.Drawing.Color.White;
            this.btn_StaffListAll.Location = new System.Drawing.Point(11, 72);
            this.btn_StaffListAll.Name = "btn_StaffListAll";
            this.btn_StaffListAll.Size = new System.Drawing.Size(93, 40);
            this.btn_StaffListAll.TabIndex = 1;
            this.btn_StaffListAll.Text = "Staff list";
            this.btn_StaffListAll.TextColor = System.Drawing.Color.White;
            this.btn_StaffListAll.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btn_Sign);
            this.Controls.Add(this.btn_AddStaff);
            this.Controls.Add(this.btn_Salary);
            this.Controls.Add(this.btn_StaffListAll);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.Size = new System.Drawing.Size(714, 449);
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btn_StaffListAll;
        private System.Windows.Forms.DataGridView dataView;
        private CustomControls.RJControls.RJButton btn_Salary;
        private CustomControls.RJControls.RJButton btn_AddStaff;
        private CustomControls.RJControls.RJButton btn_Sign;
    }
}
