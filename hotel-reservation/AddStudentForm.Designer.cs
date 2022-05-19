namespace hotel_reservation
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.txtYearlevel = new System.Windows.Forms.ComboBox();
            this.txtCourse = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Student";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.addStudentBtn);
            this.panel1.Controls.Add(this.txtYearlevel);
            this.panel1.Controls.Add(this.txtCourse);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtZipcode);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtStudentid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(69, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 381);
            this.panel1.TabIndex = 3;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addStudentBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.addStudentBtn.FlatAppearance.BorderSize = 0;
            this.addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBtn.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentBtn.Location = new System.Drawing.Point(112, 300);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(96, 30);
            this.addStudentBtn.TabIndex = 25;
            this.addStudentBtn.Text = "SAVE";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // txtYearlevel
            // 
            this.txtYearlevel.FormattingEnabled = true;
            this.txtYearlevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.txtYearlevel.Location = new System.Drawing.Point(375, 105);
            this.txtYearlevel.Name = "txtYearlevel";
            this.txtYearlevel.Size = new System.Drawing.Size(75, 21);
            this.txtYearlevel.TabIndex = 24;
            // 
            // txtCourse
            // 
            this.txtCourse.FormattingEnabled = true;
            this.txtCourse.Items.AddRange(new object[] {
            "BSIS",
            "ACT",
            "BSAT",
            "BSAIS",
            "BAB",
            "BSSW"});
            this.txtCourse.Location = new System.Drawing.Point(178, 105);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(105, 21);
            this.txtCourse.TabIndex = 23;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(178, 216);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(108, 20);
            this.txtCity.TabIndex = 21;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(453, 178);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(178, 20);
            this.txtZipcode.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(178, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(178, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(178, 20);
            this.txtAddress.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Zip Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Email";
            // 
            // txtStudentid
            // 
            this.txtStudentid.Location = new System.Drawing.Point(540, 105);
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(178, 20);
            this.txtStudentid.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(453, 62);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(178, 20);
            this.txtLastname.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year Level";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(178, 63);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(178, 20);
            this.txtFirstname.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.ComboBox txtYearlevel;
        private System.Windows.Forms.ComboBox txtCourse;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStudentid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
    }
}