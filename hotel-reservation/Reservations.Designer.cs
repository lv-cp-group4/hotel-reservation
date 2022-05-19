namespace hotel_reservation
{
    partial class Reservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.bookingsSearchBtn = new System.Windows.Forms.Button();
            this.dataGridBookings = new System.Windows.Forms.DataGridView();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students/Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BOOKING FOR: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deilon Cutamora, BSIS 1st Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "FROM:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(110, 132);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TO:";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(374, 132);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 4;
            // 
            // bookingsSearchBtn
            // 
            this.bookingsSearchBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bookingsSearchBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookingsSearchBtn.FlatAppearance.BorderSize = 0;
            this.bookingsSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsSearchBtn.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsSearchBtn.ForeColor = System.Drawing.Color.White;
            this.bookingsSearchBtn.Location = new System.Drawing.Point(610, 122);
            this.bookingsSearchBtn.Name = "bookingsSearchBtn";
            this.bookingsSearchBtn.Size = new System.Drawing.Size(96, 30);
            this.bookingsSearchBtn.TabIndex = 5;
            this.bookingsSearchBtn.Text = "SEARCH";
            this.bookingsSearchBtn.UseVisualStyleBackColor = false;
            this.bookingsSearchBtn.Click += new System.EventHandler(this.bookingsSearchBtn_Click);
            // 
            // dataGridBookings
            // 
            this.dataGridBookings.AllowUserToAddRows = false;
            this.dataGridBookings.AllowUserToDeleteRows = false;
            this.dataGridBookings.AllowUserToResizeColumns = false;
            this.dataGridBookings.AllowUserToResizeRows = false;
            this.dataGridBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBookings.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room,
            this.availability,
            this.action});
            this.dataGridBookings.Location = new System.Drawing.Point(56, 188);
            this.dataGridBookings.Name = "dataGridBookings";
            this.dataGridBookings.ReadOnly = true;
            this.dataGridBookings.RowHeadersVisible = false;
            this.dataGridBookings.Size = new System.Drawing.Size(773, 289);
            this.dataGridBookings.TabIndex = 0;
            this.dataGridBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooking_CellClick);
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
            // action
            // 
            this.action.DataPropertyName = "bookNow";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.DefaultCellStyle = dataGridViewCellStyle2;
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action.HeaderText = "";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Text = "Book Now";
            this.action.UseColumnTextForButtonValue = true;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 519);
            this.Controls.Add(this.dataGridBookings);
            this.Controls.Add(this.bookingsSearchBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button bookingsSearchBtn;
        private System.Windows.Forms.DataGridView dataGridBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}