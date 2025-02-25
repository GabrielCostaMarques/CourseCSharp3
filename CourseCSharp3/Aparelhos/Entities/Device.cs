using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Aparelhos.Entities
{
    public abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDocument(string document);
    }
}
