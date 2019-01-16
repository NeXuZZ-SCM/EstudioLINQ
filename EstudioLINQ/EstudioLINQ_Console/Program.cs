using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EstudioLINQ_Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("LAB LINQ");

            List<int> precios = new List<int>();
            precios.Add(29);
            precios.Add(15);
            precios.Add(20);
            precios.Add(19);
            precios.Add(3);


            PreciosMenorA(precios);
            ListarPrecio(precios);


            //precios.ToList()
            //precios.
            Console.ReadKey();
        }

        private static void ListarPrecio(List<int> precios)
        {
            foreach (var item in precios.ToList())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("fin foreach ToList");
        }

        private static void PreciosMenorA(List<int> precios)
        {
            foreach (var item in precios.Where(x => x < 20))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("fin foreach WHERE");
        }
    }
}
