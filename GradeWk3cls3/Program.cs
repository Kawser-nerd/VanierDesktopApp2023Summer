using System;

namespace GradeWk3cls3
{// namespace works as a package in comparison with java. If you have multiple
   // classes under same namespace, you can call them and can access the class
   // members with class instances.

    /*
     * if you are trying to access a class, which is declared as internal to
     * a namespace, if you are under the same namespace, you can access the class.
     * if you are out of the namespace, you cannot access the internal declared 
     * class without the namespace. But if you make the class public, then you
     * can access it from out of the namespace.
     */
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Here, I am going to use List to add each student one after another
            // We will ask the user to add the information as long as they want
            // 
            List<StudentInfo> studentInfos= new List<StudentInfo>();
            
            // TestScores instance Creation
            List<TestScores> testScores = new List<TestScores>();
            string Choice = "Y"; // local variable, so no static
            
            // This whole do while loop will help us to take the information for the
            // class members
            do
            {
                // create local instance for studentInfo Class
                StudentInfo studentInfo = new StudentInfo();
                Console.WriteLine("Enter the name of the student");
                studentInfo.setStudentName(Console.ReadLine());

                Console.WriteLine("Enter the ID of the student");
                studentInfo.setStudentID(int.Parse(Console.ReadLine()));

                Console.WriteLine("Enter the Term of the student");
                studentInfo.setTerm(Console.ReadLine());

                // create local instance of TestScores Class
                TestScores testScore = new TestScores();
                Console.WriteLine("Enter the Course Marks, One by one");
                testScore.setCourseMarks();

                studentInfos.Add(studentInfo); // we are going to add the 
                // studentInfo class members to the studentInfos List
                testScores.Add(testScore);

                Console.WriteLine("Do you want to add more?? Y/y for yes, N/n for no");
                Choice = Console.ReadLine();
            } while ( Choice.ToLower() != "n");
            
            // to print all the students information and the scores we have added
            // in the program

            int studentNums = 0; 

            while(studentNums < studentInfos.Count)
            { // this will get the total student numbers
                // and will help us to iterate over the list variables
                Console.WriteLine("The student Name " + studentInfos[studentNums].getStuentName()
                    + " ID " + studentInfos[studentNums].getStudentID()
                    + " Term " + studentInfos[studentNums].getTerm()
                    + " get an average score of " + testScores[studentNums].getTermAverage()
                    + " that in Grade Letter is " + testScores[studentNums].getGrade());

                studentNums++;

            }

            Console.ReadKey();
        }
    }
}