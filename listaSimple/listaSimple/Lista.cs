using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaSimple
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertaNodo() {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el numero : ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero==null)
            {
                primero = nuevo;
                primero.Siguiente = null;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
            }
            ultimo = nuevo;
            Console.WriteLine("Nuevo elemento ingresado correctamente  ");
        }

        public void imprimirLista() {
            Nodo actual = new Nodo();
            actual = primero;
            if (primero!=null)
            {
                while (actual!=null)
                {
                    Console.WriteLine("  {0}   ", actual.Dato);
                    actual = actual.Siguiente;
                   
                }
            }
            else
            {
                Console.WriteLine("La lista se encuentra vacia ");
            }
        
        }             


    }
}
