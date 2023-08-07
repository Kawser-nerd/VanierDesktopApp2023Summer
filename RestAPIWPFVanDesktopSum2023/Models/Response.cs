using System.Collections.Generic;

namespace RestAPIWPFVanDesktopSum2023.Models
{
    public class Response
    {
        /*
         * the purpose of this class is to have a structure of the response we are going to get from the remote server
         */

        public int statusCode { get; set; }
        public string message { get; set; }
        public Students student { get; set; } // this is for a single student
        public List<Students> students { get; set; } // this is for multiple students/a list of students
    }
}
