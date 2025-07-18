using ScholarshipManagement2.Entities;
using ScholarshipManagement2.Enums;
using ScholarshipManagement2.Factory;
using ScholarshipManagement2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2
{
    internal class Program
    {
        public static ScholarshipRepository repo = new ScholarshipRepository();
        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            Console.WriteLine("Batch:CS/SCSL-A/63/01");
            Console.WriteLine("ID:1286130");
            Console.WriteLine("Name:MST.Habiba Akter");
            Console.WriteLine("Project Name:ScholarshipManagement");
            Console.WriteLine("Module:C Sharp");
            Console.WriteLine("Submit to:Syed Zahidul Hassan");
            Console.WriteLine("\t\t\t\t\t\tScholarship Management");
            Console.WriteLine("\t\t\t\t\t\t----------------------");
            Console.WriteLine();
            int operation = 0;
            Console.WriteLine("How many operation do you want to perform");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\t\t\t\t---Select Operation\nHints: 1 -Read,2 -Create, 3 -Update, 4 -Delete, 5 -Single Info");
                operation = Convert.ToInt32(Console.ReadLine());
                operation = Convert.ToInt32(operation);
                switch (operation)
                {
                    case 1:
                        ShowStudent(null);
                        break;
                    case 2:
                        CreateStudent();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        ShowSingleStudent();
                        break;
                    default:
                        break;
                }
            }
           
        }

        private static void ShowSingleStudent()
        {
            Console.WriteLine("Enter student ID");
            int playerID=Convert.ToInt32(Console.ReadLine());
            Student student = repo.GetStudent(playerID);
            ShowStudent(student);
        }

        private static void DeleteStudent()
        {
            Console.WriteLine("Enter student Id that you want to Delete");
            int studentId=Convert.ToInt32(Console.ReadLine());
            Student student=repo.GetStudent(studentId);
        }

        private static void UpdateStudent()
        {
            Console.WriteLine("Enter Student ID you want to Update");
            int studentID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Student Name");
            string studentName = Console.ReadLine();
            Console.WriteLine("\nEnter Student Age");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Student Email");
            string Email = Console.ReadLine();
        Retry:
            Console.WriteLine("\nEnter student Model\nHints:\n\nHints \n1.NewStudent\n2.OldStudent");
            string model1 = Console.ReadLine();
            StudentModel model;
            try
            {
                model = (StudentModel)(Enum.Parse(typeof(StudentModel), model1));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                model = StudentModel.None;
                goto TryAgain;
            }

        TryAgain:
            Console.WriteLine("\nEnter Student Type\n\nHints:\n1.Scholarship\n2.NonScholarship");
            string scholarshipType = Console.ReadLine();
            ScholarshipType type;
            try
            {
                type = (ScholarshipType)(Enum.Parse(typeof(ScholarshipType), scholarshipType));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                type = ScholarshipType.None;
                goto Retry;
            }
            Console.WriteLine("\nwhat is the total payment of the Student?");
            decimal totalFee = Convert.ToDecimal(Console.ReadLine());
            Student student = new Student(studentID, studentAge, studentName, Email, model, type, totalFee);
            BaseStudentFactory studentFactory = new StudentManagerFactory().CreateFactory(student);
            studentFactory.ApplyFee();
            Student newStudent = repo.UpdateStudent(student);
            ShowStudent(newStudent);
        }

        private static void CreateStudent()
        {
            int id = 0;
            Console.WriteLine("\nEnter Student Name");
            string studentName = Console.ReadLine();
            Console.WriteLine("\nEnter Student Age");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Student Email");
            string Email = Console.ReadLine();
        Retry:
            Console.WriteLine("\nEnter student Model\nHints:\n\nHints \n1.NewStudent\n2.OldStudent");
            string model1 = Console.ReadLine();
            StudentModel model;
            try
            {
                model = (StudentModel)(Enum.Parse(typeof(StudentModel), model1));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                model = StudentModel.None;
                goto TryAgain;
            }

            TryAgain:
            Console.WriteLine("\nEnter Student Type\n\nHints:\n1.NonScholarship\n2.Scholarship");
            string scholarshipType = Console.ReadLine();
            ScholarshipType type;
            try
            {
                type = (ScholarshipType)(Enum.Parse(typeof(ScholarshipType), scholarshipType));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                type = ScholarshipType.None;
                goto Retry;
            }
            Console.WriteLine("\nwhat is the total payment of the Student?");
            decimal totalFee = Convert.ToDecimal(Console.ReadLine());
            Student student = new Student(id,studentAge,studentName,Email,model,type,totalFee);
            BaseStudentFactory studentFactory = new StudentManagerFactory().CreateFactory(student);
            studentFactory.ApplyFee();
            Student newStudent = repo.CreateNewStudent(student);
            ShowStudent(newStudent);
        }

        private static void ShowStudent(Student student)
        {
          List<Student> students = new List<Student>();
            Console.WriteLine(string.Format("|{0,-5}|{1,-10}|{2,-5}|{3,-10}|{4,-25}|{5,-15}|{6,-16}|{7,-15}| ", "ID","Name","Age","TotalFee","Email","Model", "Type","Net Fee"));
            Console.WriteLine(new string ('=',110));
            if (student == null) 
            {
                students=repo.GetStudents().ToList();
                foreach (Student s in students) 
                {
                    Console.WriteLine(string.Format("|{0,-5}|{1,-10}|{2,-5}|{3,-10}|{4,-25}|{5,-15}|{6,-16}|{7,-15}|", s.Id,s.Name,s.Age,s.TotalFee, s.Email, s.Model, s.Type,s.NetFee));
                }    
                
            }
            else
            {
                Console.WriteLine(string.Format("|{0,-5}|{1,-10}|{2,-5}|{3,-10}|{4,-25}|{5,-15}|{6,-16}|{7,-15}|", student.Id, student.Name, student.Age,student.TotalFee, student.Email, student.Model, student.Type,student.NetFee));

            }
            Console.WriteLine(new string('-', 110));
        }
    }
}
