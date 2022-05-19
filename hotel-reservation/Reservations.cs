using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_reservation
{
    public partial class Reservations : Form
    {
        private readonly Students _parent;

        public Reservations(Students parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void bookingsSearchBtn_Click(object sender, EventArgs e)
        {
            string theDateStart = startDate.Value.ToString("yyyy-mm-dd");
            string theDateEnd = endDate.Value.ToString("yyyy-mm-dd");
            /*DbStudent.DisplayAndSearch("SELECT room_id FROM reservations WHERE date_in <= "+ theDateStart +" AND date_out >="+theDateEnd , dataGridBookings);*/
            DbStudent.DisplayAndSearch("SELECT room, availability FROM fake_table WHERE availability = 'Available'", dataGridBookings);

        }

        private void dataGridBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Reservation res = new Reservation("1", "101", "Unavailable");
                DbStudent.BookStudent(res, "1");
            }
            
        }
    }
}
