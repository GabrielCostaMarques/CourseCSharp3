

namespace CourseCSharp3.FilesStream
{
    internal class FilesStreamUser
    {
        public void FileStreamShow()
        {
            string path = @"C:\Users\gabri\OneDrive\Área de Trabalho\file1.txt";




            try
            {
                //tudo que estiver dentro do bloco "using" será fechado automaticamente sem precisar do finally fs.Close()
                    //instancia o filestream ja com o streamreader
                using (StreamReader sr = File.OpenText(path))
                {
                    //verificando se o arquivo nao acabou
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
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
