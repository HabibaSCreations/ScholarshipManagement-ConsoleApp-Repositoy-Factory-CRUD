using ScholarshipManagement2.Entities;
using ScholarshipManagement2.Enums;
using ScholarshipManagement2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Repository
{
    public class ScholarshipRepository: IstudentScholarship
    {
        private readonly List<Student> studentList;
        public ScholarshipRepository()
        {
            studentList=new List<Student>()
            {
                new Student() { Id = 1,Age=22,Name= "Habiba", Email="Habiba@gmail.com", Model=StudentModel.OldStudent,Type=ScholarshipType.NonScholarship,   TotalFee=25000 },
                new Student() { Id = 2, Age = 23, Name = "Sonia",Email="sonia@gmail.com", Model = StudentModel.NewStudent,Type = ScholarshipType.Scholarship, TotalFee = 30000 },
                new Student() { Id = 3, Age = 21, Name = "Rifah",Email="rifah@gmail.com", Model = StudentModel.NewStudent, Type = ScholarshipType.Scholarship, TotalFee = 22000 },
                new Student() { Id = 4, Age = 23, Name = "Nusrat",Email="nusrat@gmail.com",Model = StudentModel.OldStudent, Type = ScholarshipType.Scholarship, TotalFee = 25000 },
                new Student() { Id = 5, Age = 22, Name = "mahia",Email="mahia@gmail.com",Model = StudentModel.OldStudent, Type = ScholarshipType.Scholarship, TotalFee = 25000 },
                new Student() { Id = 6, Age =22, Name= "Anjum", Email="anjum@gmail.com", Model= StudentModel.OldStudent,  Type=ScholarshipType.Scholarship,   TotalFee=21000 },
                new Student() { Id = 7, Age =22, Name= "Tonni", Email="Hatonnibiba@gmail.com",Model= StudentModel.OldStudent,  Type=ScholarshipType.Scholarship,   TotalFee=24000 },
                new Student() { Id = 8, Age =22, Name= "Pihu",  Email="pihu@gmail.com", Model= StudentModel.OldStudent,  Type=ScholarshipType.Scholarship,   TotalFee=25000 },
                new Student() { Id = 9, Age =22 ,Name= "Miral", Email="miral@gmail.com",Model= StudentModel.OldStudent,  Type=ScholarshipType.Scholarship,   TotalFee=25000 },
            };
        }

        public Student CreateNewStudent(Student student)
        {
            Student existingStudent = (from e in studentList orderby e.Id descending select e).FirstOrDefault();
            student.Id = existingStudent.Id + 1;
            studentList.Add(student);
            return student;
        }

        public Student DeleteStudent(int id)
        {
            var student = GetStudent(id);
            if (student != null)
            {
                studentList.Remove(student);
            }
            return student;
        }

        public Student GetStudent(int id)
        {
            var stu = (from row in studentList where row.Id == id select row).FirstOrDefault();
            return stu;
        }

        public IEnumerable<Student> GetStudents()
        {
            return from rows in studentList select rows;
        }

        public Student UpdateStudent(Student upStu)
        {
            Student stu = GetStudent(upStu.Id);
            if (stu != null)
            {

                stu.Name = upStu.Name;
                stu.Email = upStu.Email;
                stu.Age= upStu.Age;
                stu.Model = upStu.Model;
                stu.Type = upStu.Type;
                stu.TotalFee = upStu.TotalFee;

            }
            return stu;
        }
    }
}
