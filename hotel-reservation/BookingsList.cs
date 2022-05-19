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
    public partial class BookingsList : Form
    {
        public BookingsList()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT student_id, room, availability FROM fake_table", dataGridBookings);
        }

        private void formBookingsInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
