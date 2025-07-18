using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Manager
{
    public class OldStudentManager : IStudentManager
    {
        public decimal GetlabFee()
        {
            return 15;
        }

        public decimal GetlibraryFee()
        {
            return 20;
        }

        public decimal GetrecurringCharges()
        {
            return 15;
        }

        public decimal GetthesisFee()
        {
            return 15;
        }

        public decimal GettotalFee()
        {
            throw new NotImplementedException();
        }
    }
}
