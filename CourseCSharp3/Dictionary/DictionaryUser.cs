using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Dictonary
{
    internal class DictionaryUser
    {
        public void DictionaryShow()
        {
            Dictionary<string, string> cookies = new();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "816515651";


            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");


            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There'isnt email");
            }

            Console.WriteLine("Size: "+cookies.Count);



            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key+ " "+ item.Value);
            }

        }
    }
}
