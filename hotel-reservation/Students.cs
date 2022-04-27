using MySql.Data.MySqlClient;
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
    public partial class Students : Form
    {
        EditStudentForm form;
        Bookings form2;
       

        public Students()
        {
            InitializeComponent();
            form = new EditStudentForm(this);
            form2 = new Bookings(this);
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT id, firstname, lastname, course, year_level, student_id, address, zip_code, city, email FROM students", dataGridStudents);
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.firstname = dataGridStudents.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.lastname = dataGridStudents.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.course = dataGridStudents.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.year_level = dataGridStudents.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.student_id = dataGridStudents.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.address = dataGridStudents.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.zip_code = dataGridStudents.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.city = dataGridStudents.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.email = dataGridStudents.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                form2.ShowDialog();
            }
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT id, firstname, lastname, course, year_level, student_id, address, zip_code, city, email FROM students WHERE firstname LIKE '%" + txtSearch.Text + "%'", dataGridStudents);
        }
    }
}
