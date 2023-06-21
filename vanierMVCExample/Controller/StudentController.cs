using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vanierMVCExample.Model;
using vanierMVCExample.View;

namespace vanierMVCExample.Controller
{
    internal class StudentController
    {
        /*
         * The basic functionality of the controller is to make a bridge/connection in between
         * view and Model section
         */

        // create an instance of the Model

        public StudentModel Student = new StudentModel();
    }
}
