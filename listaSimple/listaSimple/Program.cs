using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            Lista elementos = new Lista();

            do
            {
                Console.WriteLine("1 : Agregar elemento nuevo ");
                Console.WriteLine("2 : Imprimir la lista de elementos");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        elementos.insertaNodo();
                        break;
                    case 2:
                        elementos.imprimirLista();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                       
                }
                Console.WriteLine("Otra accion s/n");
                string respuesta = Console.ReadLine();

                if (respuesta=="n")
                {
                    continuar = false;
                }

            } while (continuar);

        }
    }
}
