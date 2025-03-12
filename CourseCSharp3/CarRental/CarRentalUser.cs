using System;
using System.Globalization;
using CourseCSharp3.CarRental.Entities;
using CourseCSharp3.CarRental.Services;

namespace CourseCSharp3.CarRental
{
    public class CarRentalUser
    {
    //    public void CarRenta()
    //    {
    //        Console.WriteLine("Enter rental Data");
    //        Console.WriteLine("Car Model");
    //        string model = Console.ReadLine();

    //        Console.WriteLine("Pickup (dd/MM/yyyy/ hh:ss): ");
    //        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

    //        Console.WriteLine("Return (dd/MM/yyyy/ hh:ss): ");
    //        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

    //        CarRentalClass carRentalClass = new CarRentalClass(start, finish, new Vehicle(model));


    //        Console.WriteLine("Enter price per hour: ");
    //        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //        Console.WriteLine("Enter price per day: ");
    //        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //        RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

    //        rentalService.ProcessInvoice(carRentalClass);

    //        Console.WriteLine("Invoice: ");
    //        Console.WriteLine(carRentalClass.Invoice);
    //    }
    //}
}
