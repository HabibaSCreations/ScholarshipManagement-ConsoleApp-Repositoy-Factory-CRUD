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
    public abstract class BaseStudentFactory
    {
        public abstract IStudentManager create();
        protected Student _stu;
        protected BaseStudentFactory(Student stu)
        {
            _stu = stu;
        }
        public Student ApplyFee()
        {
            IStudentManager manager = this.create();
            _stu.LabFee = manager.GetlabFee() / 100 * _stu.TotalFee;
            _stu.CourseMaterialFee = manager.GetrecurringCharges() / 100 * _stu.TotalFee;
            _stu.LibraryFee = manager.GetlibraryFee() / 100 * _stu.TotalFee;
            _stu.ThesisFee = manager.GetthesisFee() / 100 * _stu.TotalFee;
            _stu.NetFee = _stu.TotalFee - (_stu.LabFee + _stu.CourseMaterialFee + _stu.LibraryFee + _stu.ThesisFee);

            if (_stu.Type == ScholarshipType.Scholarship)
            {
                _stu.NetFee = _stu.TotalFee - (_stu.LabFee + _stu.CourseMaterialFee + _stu.LibraryFee + _stu.ThesisFee);

            }
            else
            {
                _stu.NetFee = _stu.TotalFee;
            }
            
            return _stu;
        }
    }
}
