using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace lab8.Models
{
    internal class StudentModel
    {
        private string connection = "Data Source=KAZUMARI\\SQLEXPRESS;Initial Catalog=students;Persist Security Info=True;User ID=sa;Password=qwe;Trust Server Certificate=True";

        public void createStudent(int record_book, string name_student, string department,
            string specification, DateTime date_of_admission, string group)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "insert into students (record_book, name_student, department, specification, date_of_admission, groupp) " +
                    "values (@record_book, @name_student, @department, @specification, @date_of_admission, @group);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@record_book", record_book);
                cmd.Parameters.AddWithValue("@name_student", name_student);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@specification", specification);
                cmd.Parameters.AddWithValue("@date_of_admission", date_of_admission);
                cmd.Parameters.AddWithValue("@group", group);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable readStudents()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "select * from students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for(int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Columns[i].ColumnName = $"Column{i+1}";
                }
                return dt;
            }
        }

        public void updateStudent(int old_record_book, int record_book, string name_student, string department,
            string specification, DateTime date_of_admission, string group)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "update students set record_book = @record_book, name_student = @name_student, department = @department, " +
                    "specification = @specification, date_of_admission = @date_of_admission, " +
                    "groupp = @group where record_book = @old_record_book;";
                SqlCommand cmd = new SqlCommand (query, conn);
                cmd.Parameters.AddWithValue("@record_book", record_book);
                cmd.Parameters.AddWithValue("@name_student", name_student);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@specification", specification);
                cmd.Parameters.AddWithValue("@date_of_admission", date_of_admission);
                cmd.Parameters.AddWithValue("@group", group);
                cmd.Parameters.AddWithValue("@old_record_book", old_record_book);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteStudent(int record_book)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "delete from students where record_book = @record_book";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@record_book", record_book);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
