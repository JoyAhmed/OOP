using System;
using System.Collections.Generic;

namespace SAF_01_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var UProgram1 = new UProgram("Information Technology");

            var Student1 = new Student();

            Student1.StudentName = "A";
            Student1.Age = 19;
            Student1.Address = "159/1, Sultanganj Road, Dhaka.";

            var Student2 = new Student();

            Student2.StudentName = "B";
            Student2.Age = 20;
            Student2.Address = "Dhanmondi";

            var Student3 = new Student("C", 21, "Rampura");
            var Student4 = new Student("D", 22, "Adabor");


            int studentCount = Student.CountStudents();

            var course = new Courses("Programming with C#")
            {

            };


            Console.WriteLine($"There are {studentCount} students currently.");
        }
    }
}
