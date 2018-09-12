using System;
using System.Collections.Generic;
using System.Text;

namespace SAF_01_Classes
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public Courses Course { get; set; }

        public Teacher(string teachername)
        {
            this.TeacherName = teachername;
        }
    }
}
