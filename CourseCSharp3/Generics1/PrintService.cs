namespace CourseCSharp3.Print
{
    internal class PrintService <T> //parametrização de classe, o "T" ele é o parametro dos valores das entidades, envés de string ou int, sera "T" serve para reuso e segurança quando eu for instanciar, eu posso colocar a unidade por exemplo:       PrintService<string> service = new();
    {
        //essa classe estava servindo apenas para inteiros, mesmo usando o "object" ainda seria uma má escolha porque ela nao tem o type safety e também pode ter problemas de performace

        private T[] _values=new T[10];

        private int _count=0;

        public void AddValue(T value)
        {
            _values[_count++] = value;
        }
        
        public T Firts()
        {
            return _values[0];
        }

        public void Prints()
        {

            Console.Write("[");
            for (int i = 0; i < _count-1; i++)
            {
                Console.Write(_values[i]+", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count-1]);
            }
            Console.Write("]");

        }
    }
}
