using ClassDemo1.Model;
using ClassDemo1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo1.Controller
{
    internal class studentControl
    {
        private studentModel model = new studentModel();
        public void passStudentInfo(string studentName, int studentID, double[] studentMarks)
        {
            
            model.setStudent(studentName, studentID, studentMarks);
            //student student
        }
        public student getStudentInfo() // this method directly accessing the view class members
        {
            return model.getStudent();
        }
        public string getStudentName() // this methid is interacting with controller
        {
            return model.getStudentName();
        }
        public int getStudentID() // this methid is interacting with controller
        {
            return model.getStudentID();
        }
        public double[] getStudentMarks()
        {
            return model.getStudentMarks();
        }

        


    }
}
