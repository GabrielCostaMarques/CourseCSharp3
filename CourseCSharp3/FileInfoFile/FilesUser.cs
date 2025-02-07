using System.IO;

namespace CourseCSharp3.FileInfoFile
{
    internal class FilesUser
    {
        public void FilesShow()
        {
            string sourcePath = @"C:\Users\gabri\OneDrive\Área de Trabalho\file1.txt";
            string targetPath = @"C:\Users\gabri\OneDrive\Área de Trabalho\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }


    }
}
