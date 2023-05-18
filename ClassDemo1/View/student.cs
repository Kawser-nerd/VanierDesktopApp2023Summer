using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Lets create a program which will take input the name of the student, 
 * the id of the student and
 * his four subjects accquired percentage individually
 * 
 */

namespace ClassDemo1.View
{
    internal class student
    {
        public string StudentName { set; get; } // variable with default set and get method
        public int StudentID { set; get; }
        public double[] StudentMarks { set; get; }

        public void setStudent(string studentName, int studentID, double[] studentMarks)
        {
            this.StudentName = studentName;
            this.StudentID = studentID;
            this.StudentMarks = studentMarks; // you can use default array copy method or
            // you can use any loop structure
            
        }
        public student GetStudent() // this method is returning the instance of student class
        {
            return new student();
        }
    }
}
