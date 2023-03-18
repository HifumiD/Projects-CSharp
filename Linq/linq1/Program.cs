using System;
using System.Collections.Generic;
using System.Linq;

namespace linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           UniversityManager um = new UniversityManager();


            um.AllStudentsFromBeijingTech();

            int[] someInt = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInt orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            um.StudentAndUniversityNameCollection();

            /*
            Console.WriteLine("Enter ID you wanna search for");

            string userInput = Console.ReadLine();
            int inputAsInt = int.Parse(userInput);

            um.AllStudentsFromThatUni(inputAsInt);
            */

        }

        
     
     
    }

    class University
    {

        public int Id { get; set; }
        public string Name { get; set; }


        public void Print() 
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class UniversityManager
    {

        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale"});
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name="Carla",Gender="female", Age = 17, UniversityId= 1 });
            students.Add(new Student { Id = 2, Name = "toni",Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "Trans-Gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });

        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male Students: ");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }

        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }

        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Stundets sorted by age");

            foreach(Student student in sortedStudents)
            {
                student.Print();
            }



        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId
                                               equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from beijing Tech");

            foreach(Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
          

            IEnumerable<Student> myStudents = from student in students
                                               join university in universities on student.UniversityId
                                               equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students from that Uni {0}", Id);

            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId
                                equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New collection ");

            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from university {1}", col.StudentName, col.UniversityName);
            }

        }
    }

    class Student
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} " +
                "from university with the ID {4}", Name, Id, Gender, Age, UniversityId);
        }



    }
}
