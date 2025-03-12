using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseCSharp3.Aparelhos.NewFolder;

namespace CourseCSharp3.Aparelhos
{
    public class DeviceUser
    {
        public void DeviceShow()
        {
            Printer printer = new() { SerialNumber = 1080 };
            printer.ProcessDoc("My Letter");
            printer.Print("My Letter");


            Scanner scanner = new() { SerialNumber = 2003 };
            scanner.ProcessDoc("My letter");
            Console.WriteLine(scanner.Scan()) ;

        }
    };
}







