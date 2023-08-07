using Npgsql;
using System.Data;

namespace RestAPIVanDesktopSum2023.Models
{
    public class Applications
    {
        /*
         * This class will hold all the CRUD related operations we are going to apply
         * in our database/ remote server.
         * 
         * This will generate the requests, get the Response and then send that response
         * back to the controller whenever called
         */
        // Insertion/ Add student operation

        public Response AddStudent(NpgsqlConnection con, Students student)
        {
            Response response = new Response();
            try
            {
                /*
                 * in each of the methods under Application section/class, we are going to 
                 * send the student value from the controller page and then going to add those
                 * student information in the server/ database. To do that, we need to 
                 * connection string of the remote database as well as the student information
                 * itself.
                 */
                
                // generate the query
                string Query = "Insert into students values(@name, @id, @email, @term)";
                NpgsqlCommand cmd = new NpgsqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@name", student.name);
                cmd.Parameters.AddWithValue("@id", student.id);
                cmd.Parameters.AddWithValue("@email", student.email);
                cmd.Parameters.AddWithValue("@term", student.term);
                con.Open();

                int i = cmd.ExecuteNonQuery();

                if(i> 0) {
                    response.statusCode = 200; // it is successful
                    response.message = "Student is added successfully";
                    response.student = student;
                    response.students =null;
                }
                else
                {
                    response.statusCode = 100; // its is failed
                    response.message = "Nothing is added";
                    response.student = null;
                    response.students = null;
                }

            }catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return response;
        }

        public Response GetAllStudents(NpgsqlConnection con)
        {
            Response response= new Response();
            try
            {
                // generate the query
                string Query = "Select * from students";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                List<Students> _students = new List<Students>();

                if (dt.Rows.Count > 0)
                {
                    for(int i = 0; i<dt.Rows.Count; i++)
                    {
                        Students student = new Students(); // this is for each of the student individually
                        student.name = (string)dt.Rows[i]["name"]; // we need to use typecasting for each
                        // of the variable or value as the datatable doesn't know the inner datatype of the value

                        student.id = (int)dt.Rows[i]["id"];
                        student.email = (string)dt.Rows[i]["email"];
                        student.term = (string)dt.Rows[i]["term"];

                        _students.Add(student); // adding the student to the list
                    }
                }

                if (_students.Count > 0)// this means we have retrieved the information from the table
                {
                    response.statusCode = 200;
                    response.message = "Students are retrieved successfully";
                    response.student = null;
                    response.students= _students;
                }
                else
                {
                    response.statusCode = 100;
                    response.message = "No students are retrieved properly";
                    response.student = null;
                    response.students = null;
                }
            }catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);  
            }


            return response;
        }

        public Response GetStudentById(NpgsqlConnection con, int id)
        {
            Response response = new Response();
            try
            {
                // perform query
                //string Query = "select * from students where id='" + id + "'";
                string Query = "select * from students where id=@ID";
                NpgsqlCommand cmd = new NpgsqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                // data adapter
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); // data table will get the structure/entries of the datatable over here
                Students student = new Students(); // this will create instance for only one student
                if(dt.Rows.Count > 0) // this means we get at least one match, which is required
                {
                    student.name = (string)dt.Rows[0]["name"]; // here, we used 0 because we need only the first entry to be retrieved
                    // from remote database
                    student.id = (int)dt.Rows[0]["id"];
                    student.email = (string)dt.Rows[0]["email"];
                    student.term = (string)dt.Rows[0]["term"];

                    // Create the response for our server as well

                    response.statusCode = 200;
                    response.message = "Student found and retrieved";
                    response.student = student;
                    response.students = null; // because we are not searching for a list of students

                }
                else
                {
                    student = null;
                    response.statusCode = 100;
                    response.message = "Couldn't find student... might not present in database";
                    response.student = null;
                    response.students = null;
                }

            }
            catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return response;
        }

        public Response UpdateStudent(NpgsqlConnection con, Students student, int id)
        {
            Response response = new Response();
            try
            {
                con.Open();
                string Query = "update students set name=@name, email=@email, term=@term where id=@id";
                NpgsqlCommand cmd = new NpgsqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@name", student.name);
                cmd.Parameters.AddWithValue("@email", student.email);
                cmd.Parameters.AddWithValue("@term", student.term);
                cmd.Parameters.AddWithValue("@id", id);

                int i = cmd.ExecuteNonQuery();
                con.Close();
                if(i > 0)
                {
                    response.statusCode = 200;
                    response.message = "Student information is perfectly updated";
                    response.student = student;
                    response.students = null;
                }
                else
                {
                    response.statusCode = 100; // it fails to update the remote server student
                    response.message = "student failed to update";
                    response.student = null;
                    response.students = null;
                }

            }catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return response;
        }
    
        public Response DeleteStudentById(NpgsqlConnection con, int id)
        {
            Response response = new Response();
            try {
                con.Open();
                string Query = "Delete from students where id='"+ id +"'";
                NpgsqlCommand cmd = new NpgsqlCommand(Query, con);
                int i = cmd.ExecuteNonQuery();

                if(i > 0)
                {
                    response.statusCode = 200;
                    response.message = "Student deleted from the database";
                    response.student = null;
                    response.students = null;
                }
                else
                {
                    response.statusCode = 100;
                    response.message = "Student couldn't be searched and deleted";
                    response.student = null;
                    response.students = null;
                }

            }catch(NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return response;
        }
    }
}
