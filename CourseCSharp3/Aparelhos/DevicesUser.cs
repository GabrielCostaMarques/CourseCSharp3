using CourseCSharp3.Aparelhos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Aparelhos
{
    internal class DevicesUser
    {
        public void DeviceShow()
        {
            ComboDevice c =new ComboDevice() { SerialNumber = 3021 };

            c.ProcessDocument("My Dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan()) ;

            
        }
    }
}
