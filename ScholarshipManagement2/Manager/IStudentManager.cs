using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Manager
{
    public interface IStudentManager
    {
        decimal GetlabFee();
        decimal GetrecurringCharges();
        decimal GetthesisFee();
        decimal GetlibraryFee();
        decimal GettotalFee();
    }
}
