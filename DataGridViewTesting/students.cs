using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewTesting
{
    internal class students
    {
        /*
         * This class provides the structure for the whole list of the students. This class will read
         * the entry from the CSV file and will transfer them to the student class structure. Later
         * it will add all the entries together and will add them in our DataGridView structure
         * 
         * we are going to have a method in this class which will load all the students to the 
         * gridview structure. The method type is going to be static so that it can add the contents
         * to the class and subclasses without creating any instance
         */

        public static List<student> GetStudents()
        {
            // Read the file. We need a varibale which will capture the file path
            var file = "C:\\Users\\kawser\\source\\repos\\DataGridViewTesting\\students.csv";

            // Read the lines of the file. We need a varibale to capture all the lines inside a file
            var lines = File.ReadAllLines(file); // ReadAllines() helps to read the lines of the file
            // pass as argument over here

            // we need a varibale which will hold all the entries going to be read from the file, one
            // by one
            var studentList = new List<student>();

            // we need to go line by line of the data we captured from our csv file. We need a loop
            // which will go from first line to the last line with skipping the first line (header)

            for(int i=1; i < lines.Length; i++) // we need to skip the first line(the header line)
            {
                // here, as all the entries in the CSV file are in a line and each entry is seperated
                // by comma, we have to split the line in ',' character so that we can get each entry
                // as an Array entry

                

                var lineArray = lines[i].Split(','); // need to seperate each entry at comma.. all will
                // be inserted as an array in the lineArray Variable

                // now, we need to add the values to our student class parameters
                var student = new student()
                {
                    id = int.Parse(lineArray[0]),
                    Lname = lineArray[1],
                    FName = lineArray[2],
                    dataofBirth = lineArray[3],
                    ethnicity = lineArray[4]
                };
                studentList.Add(student);

            }

            // We already have the list of the students from the CSV file
            return studentList; // we are returning the list of the students which holds all entries
            // of the CSV file.

        }

    }
}
