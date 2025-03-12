using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.ContractExec.Entities
{
    internal class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;

            Installments = new List<Installment>();
        }

        public void AddInstallmente(Installment installment)
        {
            Installments.Add(installment);

        }
    }
}
