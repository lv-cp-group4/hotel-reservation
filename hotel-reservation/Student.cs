using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation
{
    internal class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Course { get; set; }
        public string Year_level { get; set; }
        public string Student_id { get; set; }
        public string Address { get; set; }
        public string Zip_code { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public Student(string firstname, string lastname, string course, string year_level, string student_id, string address, string zip_code, string city, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Course = course;
            Year_level = year_level;
            Student_id = student_id;
            Address = address;
            Zip_code = zip_code;
            City = city;
            Email = email;
        }
    }
}
