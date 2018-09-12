using System;
using System.Collections.Generic;
using System.Text;

namespace SAF_01_Classes
{
    public class Courses
    {
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teacher { get; set; }
        public Degree Degree { get; set; }

        private Student[] students = new Student[3];

        public Courses(string coursename)
        {
            this.CourseName = coursename;
            //this.Students = new List<Student>();
        }
    }
}
