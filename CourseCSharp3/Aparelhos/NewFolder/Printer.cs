using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Aparelhos.NewFolder
{
    public class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing" + document);
        }


        public void Print(string document)
        {
            Console.WriteLine("Printer print" + document);
        }
    }


}
