using ASPNetCoreWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class StudentDAL
    {

        private SqlConnection sqlConnection;
        private void Connection()
        {
            string connectionString = @"Data Source= DESKTOP-HLM777P ;Initial Catalog= Samarth; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Student> GetStudents()
        {
            Connection();
            sqlConnection.Open();

            List<Student> student = new List<Student>();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand("DisplayStudent", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                student.Add(
                    new Student
                    {

                        StudentId = Convert.ToInt32(dataRow["StudentId"]),
                        StudentAge = Convert.ToInt32(dataRow["StudentAge"]),
                        StudentName = dataRow["StudentName"].ToString(),
                        TeacherId = Convert.ToInt32(dataRow["TeacherId"])

                    });
            }

            return student;

        }
        public bool AddStudent(Student student)
        {
            Connection();
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("AddStudent", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@StudentName", student.StudentName);
            sqlCommand.Parameters.AddWithValue("@Age", student.StudentAge);
            sqlCommand.Parameters.AddWithValue("@TeacherId", student.TeacherId);

            int i = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool UpdateStudent(Student student)
        {

            Connection();
            SqlCommand sqlCommand = new SqlCommand("UpdateStudent", sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", student.StudentId);
            sqlCommand.Parameters.AddWithValue("@Name", student.StudentName);
            sqlCommand.Parameters.AddWithValue("@Age", student.StudentAge);
            sqlCommand.Parameters.AddWithValue("@TeacherId", student.TeacherId);


            sqlConnection.Open();
            int i = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (i >= 1)
                return true;
            else
                return false;

        }

        public bool DeleteStudent(int Id)
        {

            Connection();
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("DeleteStudent", sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", Id);

            int i = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (i >= 1)
                return true;
            else
                return false;

        }


    }
    }
