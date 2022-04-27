using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel_reservation
{
    internal class DbStudent
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=reservation_system";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;

        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }


        public static void UpdateStudent(Student std, string id)
        {
            string sql = "UPDATE students SET firstname = @StudentFirstName, lastname = @StudentLastName, course = @StudentCourse, year_level = @StudentYearLevel, student_id = @Student_id, address = @StudentAddress, zip_code = @StudentZipCode, city = @StudentCity, email = @StudentEmail WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudentFirstName", MySqlDbType.VarChar).Value = std.Firstname;
            cmd.Parameters.Add("@StudentLastName", MySqlDbType.VarChar).Value = std.Lastname;
            cmd.Parameters.Add("@StudentCourse", MySqlDbType.VarChar).Value = std.Course;
            cmd.Parameters.Add("@StudentYearLevel", MySqlDbType.VarChar).Value = std.Year_level;
            cmd.Parameters.Add("@Student_id", MySqlDbType.VarChar).Value = std.Student_id;
            cmd.Parameters.Add("@StudentAddress", MySqlDbType.VarChar).Value = std.Address;
            cmd.Parameters.Add("@StudentZipCode", MySqlDbType.VarChar).Value = std.Zip_code;
            cmd.Parameters.Add("@StudentCity", MySqlDbType.VarChar).Value = std.City;
            cmd.Parameters.Add("@StudentEmail", MySqlDbType.VarChar).Value = std.Email;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfuly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void AddStudent(Student std)
        {
            string sql = "INSERT INTO students VALUES (NULL, @StudentFirstName, @StudentLastName, @StudentCourse, @StudentYearLevel, @Student_id, @StudentAddress, @StudentZipCode, @StudentCity, @StudentEmail)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentFirstName", MySqlDbType.VarChar).Value = std.Firstname;
            cmd.Parameters.Add("@StudentLastName", MySqlDbType.VarChar).Value = std.Lastname;
            cmd.Parameters.Add("@StudentCourse", MySqlDbType.VarChar).Value = std.Course;
            cmd.Parameters.Add("@StudentYearLevel", MySqlDbType.VarChar).Value = std.Year_level;
            cmd.Parameters.Add("@Student_id", MySqlDbType.VarChar).Value = std.Student_id;
            cmd.Parameters.Add("@StudentAddress", MySqlDbType.VarChar).Value = std.Address;
            cmd.Parameters.Add("@StudentZipCode", MySqlDbType.VarChar).Value = std.Zip_code;
            cmd.Parameters.Add("@StudentCity", MySqlDbType.VarChar).Value = std.City;
            cmd.Parameters.Add("@StudentEmail", MySqlDbType.VarChar).Value = std.Email;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfuly.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

    }
}
