using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.ContractExec.Services
{
    internal class TaxPaymentPayPal : IOnlinePaymentService
    {
        
        public double PaymentFee(double amount) {

            return amount * 0.02;
        }

        public double Interest(double amount,int month)
        {

            return amount * 0.01 * month;
        }
    }
}
