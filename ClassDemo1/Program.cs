using ClassDemo1.Controller;
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

namespace ClassDemo1
{
    internal class Program
    {
        private static studentControl stdcntrl= new studentControl();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter student id");
            int studentID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter students 4 courses percentage: ");
            double[] marks = new double[4];
            for(int i=0; i<marks.Length; i++)
            {
                Console.WriteLine("Enter marks for subject: " + i);
                marks[i] = double.Parse(Console.ReadLine());
            }

            stdcntrl.passStudentInfo(studentName, studentID, marks);
            Console.WriteLine("the information you passed are here: ");
            Console.WriteLine("student name: " + stdcntrl.getStudentName());
            Console.WriteLine("student id " + stdcntrl.getStudentID());
            int l = stdcntrl.getStudentMarks().Length;
            for(int i=0; i < l; i++)
            {
                Console.WriteLine("Percentage for subject " + i + " is: " + stdcntrl.getStudentMarks()[i]);
            }
            Console.ReadKey();
        }
    }
}
