using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.DirectoryExec
{
    internal class DirectoryUser
    {
        public void DirectoryShow()
        {
            string path = @"C:\\Users\\gabri\\OneDrive\\Área de Trabalho/ROSANA";

            try
            {
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path+"\\Newfolder");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
