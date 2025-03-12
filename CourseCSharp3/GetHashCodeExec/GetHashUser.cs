using CourseCSharp3.GetHashCodeExec.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.GetHashCodeExec
{
    internal class GetHashUser
    {

        public void GetHashShow()
        {
            Client a = new() { Name= "Maria", Email= "maria@gmail.com"};

            Client b = new() { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a==b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
