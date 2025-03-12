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
            string a = "Alex";
            string b = "Maria";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
