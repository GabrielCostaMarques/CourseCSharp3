using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Students
{
    internal class StudentUser
    {
        public void StudentShow()
        {

            HashSet<int> students = new();


            foreach (char course in new[] { 'A', 'B', 'C' })
            {
                Console.Write($"How many students for course {course}? ");
                int qtd = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtd; i++)
                {
                    int code = int.Parse(Console.ReadLine());
                    students.Add(code);
                }
            }



            Console.WriteLine("Total students: "+students.Count);




        }
    }
}
