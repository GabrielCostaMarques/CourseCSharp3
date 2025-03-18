using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.ExercicieDictionary
{
    internal class Eleiction
    {

        public void EleictionShow()
        {
            SortedDictionary<string, int> votes = new();


            string path = @"C:\Users\gmarques\Desktop\votos.txt";

            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');

                    string name = line[0];
                    int votos = int.Parse(line[1]);

                    if (votes.ContainsKey(name))
                    {
                        votes[name] += votos;
                    }
                    else
                    {

                        votes[name] = votos;
                    }
                }
            }


            foreach (var item in votes)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }



        }
    }
}
