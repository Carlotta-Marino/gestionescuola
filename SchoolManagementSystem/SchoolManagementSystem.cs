using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public class SchoolManagementSystem
    {
        private List<Student> students;
        private List<Class> classes;

        public SchoolManagementSystem()
        {
            students = new List<Student>();
            classes = new List<Class>();
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm(this));
        }

        public void InsertStudent(string name, string className, int grade)
        {
            Student student = new Student(name, className, grade);
            students.Add(student);

            SaveData();
        }

        public void EditStudent(Student student, string name, string className, int grade)
        {
            student.Name = name;
            student.ClassName = className;
            student.Grade = grade;

            SaveData();
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);

            SaveData();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        private void SaveData()
        {
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.Name},{student.ClassName},{student.Grade}");
                }
            }
        }

        private void LoadData()
        {
            if (File.Exists("data.txt"))
            {
                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 3)
                        {
                            string name = parts[0];
                            string className = parts[1];
                            int grade = int.Parse(parts[2]);

                            Student student = new Student(name, className, grade);
                            students.Add(student);
                        }
                    }
                }
            }
        }
    }
}
