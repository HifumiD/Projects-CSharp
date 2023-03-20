using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using LinqToSql.HifumiDBDataSetTableAdapters;

namespace LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext datacontext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.HifumiDBConnectionString"].ConnectionString;
            datacontext = new LinqToSqlDataClassesDataContext(connectionString);



            InsertStudent();


        }


        public void InsertUniversities()
        {
            datacontext.ExecuteCommand("delete from University");


            University yale = new University();
            yale.Name = "Yale";
            datacontext.Universities.InsertOnSubmit(yale);

            University beijing = new University();
            beijing.Name = "Beijing";
            datacontext.Universities.InsertOnSubmit(beijing);


            datacontext.SubmitChanges();

            MainDataGrid.ItemsSource = datacontext.Universities;




        }

        public void InsertStudent()
        {
            University yale = datacontext.Universities.First(un => un.Name.Equals("Yale"));
            University beijing = datacontext.Universities.First(un => un.Name.Equals("Beijing"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tonie", Gender = "Male", UniversityId = yale.Id });
            students.Add(new Student { Name = "James", Gender = "Trans", UniversityId = beijing.Id });

            datacontext.Students.InsertAllOnSubmit(students);
            datacontext.SubmitChanges();

            MainDataGrid.ItemsSource = datacontext.Students;


        }


        public void InsertLectures()
        {
            datacontext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            datacontext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            datacontext.SubmitChanges();
            MainDataGrid.ItemsSource = datacontext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = datacontext.Students.First(st => st.Name.Equals("Carla"));
            Student Tonie = datacontext.Students.First(st => st.Name.Equals("Tonie"));
            Student James = datacontext.Students.First(st => st.Name.Equals("James"));

            Lecture Math = datacontext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = datacontext.Lectures.First(lc => lc.Name.Equals("History"));

            datacontext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            datacontext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tonie, Lecture = History });
            datacontext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = James, Lecture = History });

            StudentLecture slTonie = new StudentLecture();
            slTonie.Student = Tonie;
            slTonie.LectureId = History.Id;
            datacontext.StudentLectures.InsertOnSubmit(slTonie);

            datacontext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = James, Lecture = History });

            datacontext.SubmitChanges();

            MainDataGrid.ItemsSource = datacontext.StudentLectures;
        }

        public void GetUniversityOfTonie()
        {
            Student Tonie = datacontext.Students.First(st => st.Name.Equals("Tonie"));
            University ToniesUniversity = Tonie.University;

            List<University> universities = new List<University>();
            universities.Add(ToniesUniversity);

            MainDataGrid.ItemsSource = universities;



        }

        public void GetLecturesFromTonie()
        {
            try
            {

                Student Tonie = datacontext.Students.First(st => st.Name.Equals("Tonie"));

                var toniesLectures = from sl in Tonie.StudentLectures select sl.Lecture;

                MainDataGrid.ItemsSource = toniesLectures;
            }
            catch {
            }
            {
                throw new Exception();
            }
        }


        public void GetallStudentsFromYale()
        {
            var StudentsFromYale = from student in datacontext.Students
                                   where student.University.Name == "Yale"
                                   select student;


            MainDataGrid.ItemsSource = StudentsFromYale;

        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgenderUniversities = from student in datacontext.Students
                                          join university in datacontext.Universities
                                          on student.University equals university
                                          where student.Gender == "Trans"
                                          select university;

            MainDataGrid.ItemsSource = transgenderUniversities;


        }

        public void GetAllLecturesInBeijing()
        {
            var lecturesFromBeijing = from sl in datacontext.StudentLectures
                                      join student in datacontext.Students
                                      on sl.StudentId equals student.Id
                                      where student.University.Name == "beijing"
                                      select sl.Lecture; ;


            MainDataGrid.ItemsSource = lecturesFromBeijing;

        }

        public void UpdateTonie()
        {
            Student Tonie = datacontext.Students.FirstOrDefault(st => st.Name == "Tonie");

            Tonie.Name = "Antonio";

            datacontext.SubmitChanges();

            MainDataGrid.ItemsSource = datacontext.Students;


        }


        public void DeleteJames()
        {
            Student Jame = datacontext.Students.FirstOrDefault(st => st.Name == "James");
            datacontext.Students.DeleteOnSubmit(Jame);
            datacontext.SubmitChanges();

            MainDataGrid.ItemsSource= datacontext.Students;

        }


    }
}
