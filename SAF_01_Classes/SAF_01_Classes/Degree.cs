using System;
using System.Collections.Generic;
using System.Text;

namespace SAF_01_Classes
{
    public class Degree
    {
        public string DegreeName { get; set; }
        public List<Courses> Course { get; set; }
        public UProgram UProgram { get; set; }

        public Degree(string degreename)
        {
            this.DegreeName = degreename;
        }
    }
}
