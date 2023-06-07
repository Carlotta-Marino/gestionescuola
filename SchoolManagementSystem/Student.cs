using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Student
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public int Grade { get; set; }

        public Student(string name, string className, int grade)
        {
            Name = name;
            ClassName = className;
            Grade = grade;
        }
    }
}
