namespace Coffee_Restaurent_Manager.Forms.DialogForms
{
    partial class AddStaffForm
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
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.roleSelect = new System.Windows.Forms.ComboBox();
            this.labe_ = new System.Windows.Forms.Label();
            this.avatarPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_uploadPic = new CustomControls.RJControls.RJButton();
            this.btn_cancel = new CustomControls.RJControls.RJButton();
            this.btn_create = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Id.Location = new System.Drawing.Point(46, 37);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(257, 22);
            this.textBox_Id.TabIndex = 1;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff identity:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Name.Location = new System.Drawing.Point(46, 81);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(257, 22);
            this.textBox_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(51, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(51, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Address.Location = new System.Drawing.Point(46, 260);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(257, 58);
            this.textBox_Address.TabIndex = 3;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Phone.Location = new System.Drawing.Point(46, 172);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(139, 22);
            this.textBox_Phone.TabIndex = 4;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_Gender.Location = new System.Drawing.Point(204, 173);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(99, 21);
            this.comboBox_Gender.TabIndex = 7;
            this.comboBox_Gender.SelectedIndexChanged += new System.EventHandler(this.comboBox_Gender_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(216, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(51, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_Email.Location = new System.Drawing.Point(46, 216);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(257, 22);
            this.textBox_Email.TabIndex = 8;
            // 
            // roleSelect
            // 
            this.roleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roleSelect.FormattingEnabled = true;
            this.roleSelect.Location = new System.Drawing.Point(46, 126);
            this.roleSelect.Name = "roleSelect";
            this.roleSelect.Size = new System.Drawing.Size(257, 24);
            this.roleSelect.TabIndex = 10;
            // 
            // labe_
            // 
            this.labe_.AutoSize = true;
            this.labe_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labe_.Location = new System.Drawing.Point(51, 106);
            this.labe_.Name = "labe_";
            this.labe_.Size = new System.Drawing.Size(39, 16);
            this.labe_.TabIndex = 2;
            this.labe_.Text = "Role:";
            // 
            // avatarPic
            // 
            this.avatarPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarPic.Image = global::Coffee_Restaurent_Manager.Properties.Resources.cup;
            this.avatarPic.Location = new System.Drawing.Point(358, 45);
            this.avatarPic.Name = "avatarPic";
            this.avatarPic.Size = new System.Drawing.Size(143, 149);
            this.avatarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPic.TabIndex = 11;
            this.avatarPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(135, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Required";
            // 
            // btn_uploadPic
            // 
            this.btn_uploadPic.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_uploadPic.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_uploadPic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_uploadPic.BorderRadius = 0;
            this.btn_uploadPic.BorderSize = 0;
            this.btn_uploadPic.FlatAppearance.BorderSize = 0;
            this.btn_uploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uploadPic.ForeColor = System.Drawing.Color.White;
            this.btn_uploadPic.Location = new System.Drawing.Point(358, 200);
            this.btn_uploadPic.Name = "btn_uploadPic";
            this.btn_uploadPic.Size = new System.Drawing.Size(143, 21);
            this.btn_uploadPic.TabIndex = 12;
            this.btn_uploadPic.Text = "Upload image";
            this.btn_uploadPic.TextColor = System.Drawing.Color.White;
            this.btn_uploadPic.UseVisualStyleBackColor = false;
            this.btn_uploadPic.Click += new System.EventHandler(this.btn_uploadPic_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.BorderRadius = 0;
            this.btn_cancel.BorderSize = 2;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.Location = new System.Drawing.Point(434, 278);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_create.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_create.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_create.BorderRadius = 0;
            this.btn_create.BorderSize = 0;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(328, 278);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(100, 40);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.TextColor = System.Drawing.Color.White;
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // AddStaffForm
            // 
            this.AcceptButton = this.btn_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(578, 358);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_uploadPic);
            this.Controls.Add(this.avatarPic);
            this.Controls.Add(this.roleSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.labe_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStaffForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new staff";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btn_create;
        private CustomControls.RJControls.RJButton btn_cancel;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.ComboBox roleSelect;
        private System.Windows.Forms.Label labe_;
        private System.Windows.Forms.PictureBox avatarPic;
        private CustomControls.RJControls.RJButton btn_uploadPic;
        private System.Windows.Forms.Label label7;
    }
}