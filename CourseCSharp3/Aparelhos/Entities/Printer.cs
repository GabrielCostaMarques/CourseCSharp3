using CourseCSharp3.Aparelhos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Aparelhos.Entities
{
    internal class Printer : Device,IPrinter
    {
        public override void ProcessDocument(string document)
        {
            Console.WriteLine("Printer processing " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
