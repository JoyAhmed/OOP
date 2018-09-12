using System;
using System.Collections.Generic;
using System.Text;

namespace SAF_01_Classes
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Courses Courses { get; set; }

        public Student(string name, int age, string address)
        {
            this.StudentName = name;
            this.Age = Age;
            this.Address = address;
            instances++;
        }

        private static int instances = 0;

        public Student()
        {
            instances++;
        }

        public static int CountStudents()
        {
            return instances++;
        }
    }
}
