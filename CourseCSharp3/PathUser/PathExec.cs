using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseCSharp3.PathUser
{
    internal class PathExec
    {
        public void PathUser()
        {
            string path = @"C:\Users\gabri\OneDrive\Área de Trabalho";
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            Console.WriteLine("DirectorySeparatorChar: "+Path.DirectorySeparatorChar);

            Console.WriteLine("GetDirectoryName: "+Path.GetDirectoryName(path));

            Console.WriteLine("GetFileNameWithoutExtension: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: "+Path.GetExtension(path));

            Console.WriteLine("GetFullPath: "+Path.GetFullPath(path));

            Console.WriteLine("GetTempPath: "+Path.GetTempPath());
        }
    }
}
