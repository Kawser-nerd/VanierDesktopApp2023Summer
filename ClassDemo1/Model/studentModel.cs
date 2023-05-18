using ClassDemo1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo1.Model
{
    internal class studentModel
    {
        private student std = new student(); // private instance
        public void setStudent(string studentName, int studentID, double[] studentMarks)
        {
            
            std.setStudent(studentName, studentID, studentMarks);
            Console.WriteLine("Student information is added");
        }

        public student getStudent()
        {
            return std.GetStudent(); // this method is going to return the values
                                                // of student class
        }

        public string getStudentName()
        {
            return std.StudentName;
        }
        public int getStudentID()
        {
            return std.StudentID;
        }

        public double[] getStudentMarks()
        {
            return std.StudentMarks;
        }
    }
}
