using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeWk3cls3
{
    internal class StudentInfo
    {
        private string studentName;
        private int studentID;
        private string term;

        public void setStudentName(string N)
        {
            this.studentName= N;
        }
        public string getStuentName()
        {
            return this.studentName;
        }

        public void setStudentID(int id)
        {
            this.studentID = id;
        }

        public int getStudentID()
        {
            return this.studentID;
        }

        public void setTerm(string T)
        {
            this.term = T;
        }

        public string getTerm()
        {
            return this.term;
        }
    }
}
