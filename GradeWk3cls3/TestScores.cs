using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GradeWk3cls3
{
    internal class TestScores
    {
        // to create an array of instances
        // in other word, we are going to create a Class type array

        private CourseList[] courseLists = new CourseList[4];
        // the upper line means, we are going to create four instances
        // of the CourseList class.
        // if we want to create a Class Type array, we need to use the 
        // class name as the datetype of the array.

        private double termAverage=0;

        public void setCourseMarks()
        {
            // we need to provide values for four courses from the users
            for(int i = 0; i < courseLists.Length; i++)
            {
                courseLists[i] = new CourseList(); // we need to dynamically allocation the class instance
                Console.WriteLine("Enter Course Name for course "+ i);
                // courseLists are holding the instances of CourseList class
                // courseLists[0] means the first instance
                // each of the instance helps us to access the public members
                // of a class. So, courseList[0] will work as instance and
                // with the following . we can access the public members
                // of the CourseList class
                string courseName = Console.ReadLine();
                courseLists[i].setCourseName(courseName);
                Console.WriteLine("Enter Course Marks for course " + i);

                double courseMarks = double.Parse(Console.ReadLine());
                courseLists[i].setCourseMarks(courseMarks); 
                // setCourseMarks is taking double value, whether Console.ReadLine()
                // will get String values, so we need to parse it.

            }
        }

        public double getTermAverage() 
        {
            double tempTotal = 0;

            for(int i = 0; i< courseLists.Length; i++)
            
                tempTotal += courseLists[i].getCourseMarks();
                // we are going to access each of the course marks of the student
                // and we are going to sum them up to get the total scores of
                // four courses

                // tempTotal += M means tempTotal = tempTotal + M 
            
            termAverage = tempTotal/ courseLists.Length;
            
            return termAverage; 
        }

        public string getGrade()
        {
            termAverage = getTermAverage(); // this line will help us
            // to call the inner method and get the termAverage by calculating
            // inside the method in upper block

            /*
             * if the if else structure or even in loop structure like for
             * loop, while loop or any other loop:
             * 
             * you need to use curly braces everytime to define the scope.
             * 
             * but let's say, you have only one statement to execute after 
             * if-else block or loop block. If it is positioned relatively
             * to the structure or the block, you don't need to use curly
             * braces.
             */
            if (termAverage <= 100 && termAverage >= 90)
                return "A";
            
            else if (termAverage < 90 && termAverage >= 80)
                return "B";
            else if (termAverage < 80 && termAverage >= 70)
                return "C";
            else if (termAverage < 70 && termAverage >= 60)
                return "D";
            else
                return "F";
        }
    }
}
