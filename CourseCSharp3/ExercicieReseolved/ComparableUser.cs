using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.ExercicieReseolved
{
    internal class ComparableUser
    {
        public void ComparableShow()
        {
            string path = @"C:\Users\gabri\Desktop\in.txt";

            Console.WriteLine(path);

            string[] enters = path.Split(' ');
           

            string name = enters[0];
            string hours = enters[1];
            
            foreach (string n in enters)
            {
                Console.WriteLine(n);
            }

        }
    }
}
