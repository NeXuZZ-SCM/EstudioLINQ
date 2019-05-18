using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioLINQ_Console
{
    public class LabX0LINQ
    {

        public static void Demostracion()
        {
            List<int> precios = new List<int>();
            List<int> cantidad = new List<int>();
            List<string> productos = new List<string>();

            #region Listado INT Precios  

            precios.Add(29);
            precios.Add(15);
            precios.Add(20);
            precios.Add(19);
            precios.Add(3);
            #endregion

            #region Listado INT Cantidad

            cantidad.Add(22);
            cantidad.Add(33);
            cantidad.Add(44);
            cantidad.Add(55);
            cantidad.Add(66);
            #endregion

            #region Listado STRING Productos

            productos.Add("jugo");
            productos.Add("gaseosa");
            productos.Add("agua");
            productos.Add("snack");
            productos.Add("tomate");
            productos.Add("shampoo");
            productos.Add("pan");
            #endregion


            PreciosMenorA(precios);
            ListarPrecio(precios);
            SumarPrecio(precios);
            QuitarElementos(precios);
            UnirPrecioACantidad(precios, cantidad);
            QueContenganLaLetra(productos); //Proceso de filtrado
        }

        #region VER METODOS LINQ LAMBDA 

        private static void PreciosMenorA(List<int> precios)
        {
            foreach (var item in precios.Where(x => x < 20))
            {
                Console.Write("[" + item + "]  ");
            }
            Console.WriteLine("\nfin foreach WHERE x=> x < 20");
        }

        private static void ListarPrecio(List<int> precios)
        {
            foreach (var item in precios.ToList())
            {
                Console.Write("[" + item + "]  ");
            }
            Console.WriteLine("\nfin foreach ToList");
        }

        private static void SumarPrecio(List<int> precios)
        {
            Console.WriteLine("[" + precios.Sum(precio => precio) + "]  ");
            Console.WriteLine("fin SUM precios");
        }

        private static void QuitarElementos(List<int> precios)
        {
            foreach (var item in precios.Skip(3))
            {
                Console.Write("[" + item + "]  ");
            }
            Console.WriteLine("\nfin SKIP precios | Elimina una cantidad de elementos especificados");
        }

        private static void UnirPrecioACantidad(List<int> precios, List<int> cantidad)
        {
            foreach (var item in precios.Union(cantidad))
            {
                Console.Write("[" + item + "]  ");
            }
            Console.WriteLine("\nFIN Unir Precio a Cantidad");
        }

        private static void QueContenganLaLetra(List<string> productos)
        {
            foreach (var item in productos.Where(e => e.Contains("a")).ToList())
            {
                Console.Write("[" + item + "]  ");
            }
        }

        #endregion 
    }
}
