namespace CourseCSharp3.CarRental.Services
{
    //no caso abaixo o BrazilTaxService está realizando a interface, ele é uma subcategoria da interface ITaxService (tem que ter o mesmo nome da função da interface, no caso Tax)
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
