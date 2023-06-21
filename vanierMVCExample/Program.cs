using vanierMVCExample.Controller;
using vanierMVCExample.View;

namespace vanierMVCExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //StudentController studentController = new StudentController();

            StudentView studentView = new StudentView();
            // through the controller, we are going to set the student information in the view
            studentView.setStudentInformation();
            // through the controller, we are going to get the student information in the view
            studentView.getStudentInformation();
            
        }
    }
}