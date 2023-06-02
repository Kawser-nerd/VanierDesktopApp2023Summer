using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeWk3cls3
{
   internal class CourseList
    { 
        private string courseName;
        private double courseMarks;

        public void setCourseName(string N)
        {
            this.courseName = N;
            // this keyword: it always point to the same class variables itself.
        }

        /*
         * The regular syntax of any method creation:
         * 
         * access-modifier return_type method_name()
         * 
         * access-modifier: private method of the class.. only class can see
         *  public: the method could be visible to outside of the class
         *  means, we can access them using class instance/object
         *  protected: Outside the class, you can access it, but can not update
         *  the values or anything of that method.
         *  
         *  return_type: this refers to the datatype the method is going to
         *  return. If a method is returning String datatype, the return_type
         *  will be String, otherwise, its void, means the method is not
         *  going to return any value
         *  
         */
        public string getCourseName() // return-type: string
        {
            return this.courseName;// string datatype
        }

        public void setCourseMarks(double M)
        {
            this.courseMarks = M;
        }

        public double getCourseMarks()// return-type: double
        {
            return this.courseMarks; // double datatype
        }
    }
}
