using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiSQLVanierAECWk6cls2
{
    internal class student
    {
        // This class will give the structure of data we are going to read from the given database

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Term { get; set; }
    }
}
