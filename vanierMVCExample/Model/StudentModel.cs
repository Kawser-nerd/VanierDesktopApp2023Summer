using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanierMVCExample.Model
{ 
    /*
     * the logical implementation of the program are going to be implemented in teh StudentModel Class
     */
    internal class StudentModel
    {
        
        private Student student = new Student();

        public void setID(int id)
        {
            this.student.Id = id;
        }

        public int getId()
        {
            return this.student.Id;
        }
        public void setFirstName(string firstName)
        {
            this.student.FirstName = firstName;
        }
        public string getFirstName()
        {
            return this.student.FirstName;
        }
        public void setLastName(string lastName)
        {
            this.student.LastName = lastName;
        }
        public string getLastName()
        {
            return this.student.LastName;
        }
        public void setEmail(string email)
        {
            this.student.Email = email;
        }
        public string getEmail()
        {
            return this.student.Email;
        }
        public void setTerm(string term)
        {
            this.student.Term = term;
        }
        public string getTerm()
        {
            return this.student.Term;
        }
    }
}
