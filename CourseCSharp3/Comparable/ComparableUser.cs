using CourseCSharp3.Comparable.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Comparable
{
    internal class ComparableUser
    {
        public void ComparableShow()
        {
            string path = @"C:\Users\gabri\Desktop\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach (Employee s in list)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
