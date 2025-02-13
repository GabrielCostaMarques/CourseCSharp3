using CourseCSharp3.ContractExec.Entities;
using CourseCSharp3.ContractExec.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.ContractExec
{
    internal class ContractUser
    {
        public void ContractShow()
        {

            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine());


            Console.Write("Enter number of installments: ");
            int ins = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, value);

            Payment payment = new Payment(new TaxPaymentPayPal());
            payment.ProcessContract(contract,ins);



            Console.WriteLine("Installments");


            foreach (var item in contract.Installments)
            {
                Console.WriteLine(item);
            }



        }
    }
}
