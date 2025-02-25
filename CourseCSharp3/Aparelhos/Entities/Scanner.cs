using CourseCSharp3.Aparelhos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Aparelhos.Entities
{
    internal class Scanner : Device,IScanner
    {
        public override void ProcessDocument(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
