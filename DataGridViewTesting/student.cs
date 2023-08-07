using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewTesting
{
    internal class student
    {
        /*
         * this class is the class which will provide the structure of the Student csv file
         * 
         * this class ensure a single entry of the student present in our csv file.
         */
        public int id { get; set; }
        public string Lname { get; set; }
        public string FName { get; set; }
        public string dataofBirth { get; set; }
        public string ethnicity { get; set; }

    }
}
