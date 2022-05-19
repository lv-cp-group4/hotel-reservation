using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation
{
    internal class Reservation
    {
        public string StudentId { get; set; }
        public string Room { get; set; }
        public string Availability { get; set; }


        public Reservation(string student_id, string room, string availability)
        {
            StudentId = student_id;
            Room = room;
            Availability = availability;
        }
    }
}
