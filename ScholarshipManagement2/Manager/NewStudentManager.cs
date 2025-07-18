using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Manager
{
    public class NewStudentManager : IStudentManager
    {
        public decimal GetlabFee()
        {
            return 5;
        }

        public decimal GetlibraryFee()
        {
            return 5;
        }

        public decimal GetrecurringCharges()
        {
            return 0;
        }

        public decimal GetthesisFee()
        {
            return 10;
        }

        public decimal GettotalFee()
        {
            throw new NotImplementedException();
        }
    }
}
