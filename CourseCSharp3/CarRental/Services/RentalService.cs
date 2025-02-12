using System;
using CourseCSharp3.CarRental.Entities;

namespace CourseCSharp3.CarRental.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //interface
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRentalClass carRentalClass)
        {
            TimeSpan duration = carRentalClass.Finish.Subtract(carRentalClass.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                //Math.Ceiling para arredondar para cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRentalClass.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
