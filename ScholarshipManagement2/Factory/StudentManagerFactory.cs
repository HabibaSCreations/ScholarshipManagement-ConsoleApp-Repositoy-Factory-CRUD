using ScholarshipManagement2.Entities;
using ScholarshipManagement2.Enums;
using ScholarshipManagement2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Factory
{
    public class StudentManagerFactory
    {
        public BaseStudentFactory CreateFactory(Student stu)
        {
            BaseStudentFactory returnValue = null;
            if (stu.Type == ScholarshipType.Scholarship)
            {
                returnValue = new NewStudentFactory(stu);
            }
            else if (stu.Type == ScholarshipType.NonScholarship)
            {
                returnValue = new OldStudentFactory(stu);
            }
            return returnValue;
        }
    }
}
