using CourseCSharp3.ContractExec.Entities;


namespace CourseCSharp3.ContractExec.Services
{
    internal class Payment
    {


        private IOnlinePaymentService _onlinePaymentService;
    
        public Payment(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {


            double install = contract.ContractValue / months;


            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);

                double fee = install + _onlinePaymentService.Interest(install, i);
                double fullQuota = fee + _onlinePaymentService.PaymentFee(fee);

                contract.AddInstallmente(new Installment(date, fullQuota));

            }
        }
    }
}
