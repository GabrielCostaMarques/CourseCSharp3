namespace CourseCSharp3.Print
{
    internal class PrintUser
    {

        public void PrintShow()
        {
            PrintService<int> service = new();


            Console.Write("How many values? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                service.AddValue(x);
            }

            service.Prints();
            Console.WriteLine("First: "+ service.Firts()); 
        }

    }
}
