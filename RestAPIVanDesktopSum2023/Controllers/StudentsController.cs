using Microsoft.AspNetCore.Mvc;
using Npgsql;
using RestAPIVanDesktopSum2023.Models;

namespace RestAPIVanDesktopSum2023.Controllers
{/*
  * This is the scope for our API controller. We need to create the base api name for the
  * REST APIs we are going to create for this program.
  * 
  * we first need to give the route of the APIs and then we need to pass the controller 
  * we are going to create in this program
  */

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StudentsController(IConfiguration configuration)
        {
            /*
             * The IConfiguration in this constructor space is going to be invoked when
             * the class instance is created. This is going to to grab the connection from
             * the appsettings and then going to send it back the configuration object
             * or instance of this scope;
             */
            _configuration = configuration;
        }

        /*
         * Create a controller/method which will add information to your remote database
         * in other words, we can say we are going to add student to our remote database
         *
         * the remote database connection string should be provided in the appsettings.json file
         */

        [HttpPost]
        [Route("AddStudent")]
        public Response AddStudent(Students student)
        {
            // Create the Database Connection
            NpgsqlConnection con = new NpgsqlConnection(_configuration.GetConnectionString("studentConnection").ToString());
            Response response = new Response();
            // now we need to call the application interface over here
            Applications app = new Applications();
            response = app.AddStudent(con, student);
            return response;
        }

        // Reading all the students

        [HttpGet]
        [Route("GetAllStudents")]
        public Response GetStudent() { 
            Response response = new Response();
            NpgsqlConnection con = new NpgsqlConnection(_configuration.GetConnectionString("studentConnection").ToString());
            Applications app = new Applications();
            response=app.GetAllStudents(con);
            return response;
        }


    }
}
