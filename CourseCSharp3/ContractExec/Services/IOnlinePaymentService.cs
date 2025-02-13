using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.ContractExec.Services
{
    internal interface IOnlinePaymentService
    {
        public double Tax(double amount);
    }
}
