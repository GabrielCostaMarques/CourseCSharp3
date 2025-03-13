using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.Group
{
    internal class GroupUser
    {

        public void GroupShow()
        {

            //usando HashSet, método de busca rapido mas nao ordenado (prioridade 1)
            HashSet<string> set = new();

            set.Add("TV");
            set.Add("Note");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Note"));
            Console.WriteLine(set.Count);


            foreach (string p in set)
            {
                Console.WriteLine(p);
            }


            //Usando SortedSet, busca logarítimica
            SortedSet<int> a = new() {4,7,8,9,10,30 };
            SortedSet<int> b = new() {2,3,4,5,13,35 };

            PrintCollection(a);

            //UNION
            //acrescentando elementos que ainda nao contém, pois nao aceita repetição
            SortedSet<int> c = new(a);
            c.UnionWith(b);
            PrintCollection(c);


            //INTERSECTION
            //retorna elementos que contem em ambas listas
            SortedSet <int>d = new(a);
            d.IntersectWith(b);
            PrintCollection(d);


            //DIFFERENCE
            //Remove os itens iguais
            SortedSet <int> e = new(a);
            e.ExceptWith(b);
            PrintCollection(e); 

        }


        //função para imprimir coleções, usando o IEnumerable para buscar os valores das coleções
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj+" ");
            }
            Console.WriteLine();
        }
        
    }
}
