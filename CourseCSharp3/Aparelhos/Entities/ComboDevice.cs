using CourseCSharp3.Aparelhos.Interfaces;

namespace CourseCSharp3.Aparelhos.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {

        public override void ProcessDocument(string document)
        {
            Console.WriteLine("Combo Device processing "+document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Combo Device Print "+document);
            
        }

        public string Scan()
        {
            return "Scanner result";
        }
    }
}
