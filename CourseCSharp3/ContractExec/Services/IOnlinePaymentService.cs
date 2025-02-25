namespace CourseCSharp3.ContractExec.Services
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int month);
    }
}
