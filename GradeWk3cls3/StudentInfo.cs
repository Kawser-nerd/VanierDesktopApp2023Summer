using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeWk3cls3
{
    class StudentInfo:TestScores // studentInfo is inheriting TestScores members
    {
        private static string studentName;
        private static int studentID;
        private static string term;
        // when we declare any member as static, that means that variable or method
        // value, member value might get updated or changed inside the program more
        // than once
        public static void setStudentName(string N)
        {
            studentName= N;
        }
        public static string getStuentName()
        {
            return studentName;
        }

        public static void setStudentID(int id)
        {
            studentID = id;
        }

        public static int getStudentID()
        {
            return studentID;
        }

        public static void setTerm(string T)
        {
            term = T;
        }

        public static string getTerm()
        {
            return term;
        }
    }
}
