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

            List<int> cantidad = new List<int>();
            cantidad.Add(22);
            cantidad.Add(33);
            cantidad.Add(44);
            cantidad.Add(55);
            cantidad.Add(66);

            List<string> productos = new List<string>();
            productos.Add("jugo");
            productos.Add("gaseosa");
            productos.Add("agua");
            productos.Add("snack");
            productos.Add("tomate");
            productos.Add("shampoo");
            productos.Add("pan");


            PreciosMenorA(precios);
            ListarPrecio(precios);
            SumarPrecio(precios);
            QuitarElementos(precios);
            UnirPrecioACantidad(precios, cantidad);

            

            //precios.ToList()
            //precios.
            Console.ReadKey();
        }

        private static void UnirPrecioACantidad(List<int> precios, List<int> cantidad)
        {
            foreach (var item in precios.Union(cantidad))
            {
                Console.WriteLine(item);
            }
        }

        private static void QuitarElementos(List<int> precios)
        {
            foreach (var item in precios.Skip(3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("fin SKIP precios | Elimina una cantidad de elementos especificados");
        }

        private static void SumarPrecio(List<int> precios)
        {
            Console.WriteLine(precios.Sum(precio => precio));
            Console.WriteLine("fin SUM precios");
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
            Console.WriteLine("fin foreach WHERE x=> x < 20");
        }
    }
}
