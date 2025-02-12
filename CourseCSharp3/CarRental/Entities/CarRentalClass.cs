using System;


namespace CourseCSharp3.CarRental.Entities
{
    internal class CarRentalClass
    {
        public DateTime Start{ get; set; }
        public DateTime Finish{ get; set; }
        public Vehicle Vehicle{ get; set; }
        public Invoice Invoice { get; set; }



        public CarRentalClass(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
