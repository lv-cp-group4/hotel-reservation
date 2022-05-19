namespace hotel_reservation
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.bookingsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bookingsBtn);
            this.panel1.Controls.Add(this.addStudent);
            this.panel1.Controls.Add(this.students);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 555);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dorm Reservation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_reservation.Properties.Resources.la_verdad_christian_college_logo;
            this.pictureBox1.Location = new System.Drawing.Point(72, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.SystemColors.Control;
            this.addStudent.FlatAppearance.BorderSize = 0;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.Location = new System.Drawing.Point(32, 347);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(210, 41);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // students
            // 
            this.students.BackColor = System.Drawing.SystemColors.Control;
            this.students.FlatAppearance.BorderSize = 0;
            this.students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.students.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students.Location = new System.Drawing.Point(32, 286);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(210, 41);
            this.students.TabIndex = 0;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = false;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.home_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(275, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(976, 555);
            this.mainpanel.TabIndex = 1;
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.bookingsBtn.FlatAppearance.BorderSize = 0;
            this.bookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsBtn.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.Location = new System.Drawing.Point(32, 406);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Size = new System.Drawing.Size(210, 41);
            this.bookingsBtn.TabIndex = 0;
            this.bookingsBtn.Text = "Bookings";
            this.bookingsBtn.UseVisualStyleBackColor = false;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 555);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LVCC Dorm Reservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button bookingsBtn;
    }
}

