using CourseCSharp3.ExercicieReselved.Entities;

namespace CourseCSharp3.ExercicieReselved
{
    internal class ExercicieUser
    {
        public void ExercicieShow()
        {
            string path = @"C:\Users\gabri\Desktop\data.txt";

            HashSet<Register> set = new();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        
                        string name = line[0];
                        DateTime date = DateTime.Parse(line[1]);

                        Register register = new(name, date);
                        set.Add(register);
                    }

                    Console.WriteLine(set.Count);
                }

            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }




        }
    }
}
