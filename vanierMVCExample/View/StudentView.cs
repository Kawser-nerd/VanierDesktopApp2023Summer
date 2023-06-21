using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vanierMVCExample.Controller;

namespace vanierMVCExample.View
{
    internal class StudentView
    {
        /*
         * The functionality of the view is to communicate with the controller, take the information of
         * the model and then interact with the model
         */
        private StudentController studentController = new StudentController();
        public void setStudentInformation()
        {
            Console.WriteLine("Enter the ID of the Student");
            // the following line is going to access the model through the controller, not directly
            // going to work with the model class itself
            studentController.Student.setID(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the First name of the Student");
            studentController.Student.setFirstName(Console.ReadLine());

            Console.WriteLine("Enter the Last name of the Student");
            studentController.Student.setLastName(Console.ReadLine());

            Console.WriteLine("Enter the email address of the Student");
            studentController.Student.setEmail(Console.ReadLine());

            Console.WriteLine("Enter the term of the Student");
            studentController.Student.setTerm(Console.ReadLine());
        }

        public void getStudentInformation()
        {
            Console.WriteLine("The First name of the student is: " + studentController.Student.getFirstName());
            Console.WriteLine("The Last name of the student is: " + studentController.Student.getLastName());
            Console.WriteLine("The Id of the student is "+ studentController.Student.getId());
            Console.WriteLine("The Email of the student is "+ studentController.Student.getEmail());
            Console.WriteLine("The Term of the student registered is "+ studentController.Student.getTerm());
        }
    }
}
