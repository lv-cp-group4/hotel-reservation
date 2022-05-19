namespace hotel_reservation
{
    partial class BookingsList
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
            this.dataGridBookings = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Rooms and Bookings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridBookings);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 415);
            this.panel1.TabIndex = 1;
            // 
            // dataGridBookings
            // 
            this.dataGridBookings.AllowUserToAddRows = false;
            this.dataGridBookings.AllowUserToDeleteRows = false;
            this.dataGridBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBookings.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.room,
            this.availability});
            this.dataGridBookings.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridBookings.Location = new System.Drawing.Point(21, 71);
            this.dataGridBookings.Name = "dataGridBookings";
            this.dataGridBookings.ReadOnly = true;
            this.dataGridBookings.RowHeadersVisible = false;
            this.dataGridBookings.Size = new System.Drawing.Size(827, 325);
            this.dataGridBookings.TabIndex = 1;
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "Student ID ( Database )";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "Room";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // availability
            // 
            this.availability.DataPropertyName = "availability";
            this.availability.HeaderText = "Availability";
            this.availability.Name = "availability";
            this.availability.ReadOnly = true;
            // 
            // BookingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 482);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingsList";
            this.Text = "BookingsList";
            this.Shown += new System.EventHandler(this.formBookingsInfo_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
    }
}