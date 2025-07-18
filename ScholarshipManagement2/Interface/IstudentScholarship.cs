using ScholarshipManagement2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Interface
{
    public interface IstudentScholarship
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        Student CreateNewStudent(Student student);
        Student UpdateStudent(Student student);
        Student DeleteStudent(int id);
    }
}
