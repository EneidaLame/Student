using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDatabase db = new MyDatabase();  //Connection to Database

            PrintAllStudents(db.Students);
        }

            public static void PrintAllStudents(List<Student> students)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0,5}|{1,15}|{2,14}|{3,22}|{4,22}", "Id", "Name", "Age", "Project.Title", "Project.PassMark");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var item in students)
                {
                    item.Output();
                }
            }
        }
        public class MyDatabase
        {
            public List<Student> Students { get; set; } = new List<Student>();
            public MyDatabase()
            {
                Project p1 = new Project() { Id = 1, Title = "C#", PassMark = 50 };
                Project p2 = new Project() { Id = 2, Title = "Python", PassMark = 30 };
                Project p3 = new Project() { Id = 3, Title = "Java", PassMark = 40 };
                Project p4 = new Project() { Id = 4, Title = "HTML", PassMark = 60 };

                Student s1 = new Student() { Id = 1, Name = "Xristos", Age = 33, Project = p1 };
                Student s2 = new Student() { Id = 2, Name = "Marios", Age = 26, Project = p2 };
                Student s3 = new Student() { Id = 3, Name = "Sofia", Age = 43, Project = p2 };
                Student s4 = new Student() { Id = 4, Name = "Mixalis", Age = 35, Project = p3 };
                Student s5 = new Student() { Id = 5, Name = "Giorgos", Age = 32, Project = p4 };
                Student s6 = new Student() { Id = 6, Name = "Mixalis", Age = 35, Project = p1 };

                Students.Add(s1);
                Students.Add(s2);
                Students.Add(s3);
                Students.Add(s4);
                Students.Add(s5);
                Students.Add(s6);
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Project Project { get; set; }

            public void Output()
            {
                Console.WriteLine("{0,5}|{1,15}|{2,14}|{3,22}|{4,22}", Id, Name, Age, Project.Title, Project.PassMark);
            }

        }

        public class Project
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int PassMark { get; set; }

        }

}

