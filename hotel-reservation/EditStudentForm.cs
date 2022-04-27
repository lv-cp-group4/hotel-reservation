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
    public partial class EditStudentForm : Form
    {
        private readonly Students _parent;
        public string id, firstname, lastname, course, year_level, student_id, address, zip_code, city, email;

        public EditStudentForm(Students parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student first name is empty.");
                return;
            }
            if (txtLastname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student last name is empty.");
                return;
            }
            if (txtCourse.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student course is empty.");
                return;
            }
            if (txtYearlevel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student course is empty.");
                return;
            }
            if (txtStudentid.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student ID is empty.");
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student ID is empty.");
                return;
            }
            if (txtZipcode.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student ID is empty.");
                return;
            }
            if (txtCity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student ID is empty.");
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student ID is empty.");
                return;
            }

            Student std = new Student(txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtCourse.Text.Trim(), txtYearlevel.Text.Trim(), txtStudentid.Text.Trim(), txtAddress.Text.Trim(), txtZipcode.Text.Trim(), txtCity.Text.Trim(), txtEmail.Text.Trim());
            DbStudent.UpdateStudent(std, id);
            _parent.Display();

        }

        public void UpdateInfo()
        {
            txtFirstname.Text = firstname;
            txtLastname.Text = lastname;
            txtCourse.Text = course;
            txtYearlevel.Text = year_level;
            txtStudentid.Text = student_id;
            txtAddress.Text = address;
            txtZipcode.Text = zip_code;
            txtCity.Text = city;
            txtEmail.Text = email;
        }

        public void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtCourse.Text = txtYearlevel.Text = txtStudentid.Text = txtAddress.Text = txtZipcode.Text = txtCity.Text = txtEmail.Text = string.Empty;
        }

    }
}
