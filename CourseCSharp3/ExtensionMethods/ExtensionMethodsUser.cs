

namespace CourseCSharp3.ExtensionMethods
{
    internal class ExtensionMethodsUser
    {

        public void ExtensionMethodsShow()
        {
            DateTime dateTime = new(2025, 03, 17, 8, 10, 45);

            Console.WriteLine(dateTime.ElapsedTime());

            string s1 = "Good morning dear students!";

            Console.WriteLine(s1.Cut(10));

            

        }
    }
}
