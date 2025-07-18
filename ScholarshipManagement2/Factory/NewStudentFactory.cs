using ScholarshipManagement2.Entities;
using ScholarshipManagement2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Factory
{
    public class NewStudentFactory : BaseStudentFactory
    {
        public NewStudentFactory(Student stu) : base(stu)
        {
        }

        public override IStudentManager create()
        {
            NewStudentManager manager = new NewStudentManager();
            decimal basic = _stu.TotalFee;
            return manager;
        }
    }
}
