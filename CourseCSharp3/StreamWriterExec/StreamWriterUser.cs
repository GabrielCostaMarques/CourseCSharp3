using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseCSharp3.StreamWriterExec
{
    internal class StreamWriterUser
    {
       public void StreamWriterShow()
        {
            string sourcePath = @"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\file1.txt";
            
            string targetPath = @"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\file2.txt";


            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
