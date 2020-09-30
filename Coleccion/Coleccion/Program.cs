using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*Arreglo unidimencional */
            //int[] numero = new int[3];
            //numero[0] = 10;
            //numero[1] = 20;
            //numero[2] = 30;

            //Console.WriteLine("Recorriendo el vector ");
            //foreach (int  i in numero)
            //{
            //    Console.WriteLine("El elemento es : "+ i+Environment.NewLine);
            //}

            ///*Arreglo bidimencional o matrices*/
            //int[,] matriz = new int[3, 3];
            //for (int fila = 0; fila < 3; fila++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Console.WriteLine("Ingrese los numero : ");
            //        matriz[fila, col] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.Clear();
            //matriz[0, 1] = 20;
            //Console.WriteLine("imprimiento la matriz  ");
            //for (int fila = 0; fila < matriz.GetLength(0); fila++)
            //{
            //    for (int col = 0; col < matriz.GetLength(1); col++)
            //    {
            //        Console.Write(" " + matriz[fila,col]);
            //    }
            //    Console.WriteLine();
            //}

            //Stack pila = new Stack();
            //pila.Push("Hola1");
            //pila.Push("Hola2");
            //pila.Push("Hola3");
            //pila.Push("Hola4");
            //Console.WriteLine("Datos de la pila :");
            //imprimirPila(pila);
            //Console.WriteLine("Datos eliminar un dato de la pila :");
            //pila.Pop();
            //imprimirPila(pila);
            //Console.WriteLine("Datos siguiente a salir de la pila :");
            //Console.WriteLine( pila.Peek());

            //Console.WriteLine("Existe elemento  :");

            //Console.WriteLine(pila.Contains("Hola1"));


            //Dictionary<int, string> alumnos = new Dictionary<int, string>();
            //alumnos.Add(1, "Andres");
            //alumnos.Add(2, "Juan");
            //alumnos.Add(3, "Pedro");
            //alumnos.Add(4, "Ana");
            //alumnos.Add(5, "Kathia");

            //foreach  (KeyValuePair<int, string> e in alumnos)
            //{
            //    Console.WriteLine("Clave" + e.Key+ " Valor  "+e.Value );
            //}
            //Console.WriteLine("Recorriendo con foreach con var"+Environment.NewLine);
            //foreach (var item in alumnos)
            //{
            //    Console.WriteLine("Clave" + item.Key + " Valor  " + item.Value);
            //}
            //alumnos.Remove(2);

            //Console.WriteLine("Recorriendo con un elemento eliminado" + Environment.NewLine);
            //foreach (var item in alumnos)
            //{
            //    Console.WriteLine("Clave" + item.Key + " Valor  " + item.Value);
            //}

            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(4);
            numeros.Add(4);
            numeros.Add(4);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);

            foreach (var i in numeros)
            {
                Console.WriteLine("Dato "+ i+ " Posicion "+numeros.IndexOf(i));
            }

            Console.WriteLine("Con un for basico "+Environment.NewLine);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("Dato " + i + " Posicion " + numeros[i]);
            }
            
            Console.WriteLine("Imprimir inverso la lista ");
            Console.WriteLine();
            numeros.Reverse();

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine("Dato " + i + " Posicion " + numeros[i]);
            }

            Console.WriteLine("Uso del contains");
            if (true)
            {
                Console.WriteLine(numeros.Contains(5));
            }

            Console.WriteLine("Filtrado de datos con expresion lambda");

            List<int> datos = numeros.FindAll(x => x == 1);
            foreach (var item in datos)
            {
                Console.WriteLine("Elementos filtrados "+item);
            }

            List<Persona> per = new List<Persona>();
            Persona p1 = new Persona("10", "Roberto");
            Persona p2 = new Persona("15", "Pedro");
            Persona p3 = new Persona("20", "Juan");

            per.AddRange(new Persona[]{ p1, p2, p3 });
            
            Console.ReadKey();


            /*Investigar   sobre expresiones delegados y predicados  expresiones lamda
             10 ejemplos de cada uno de ellos 
            Jueves 08/10/2020
             */


        }
        public static void imprimirPila(IEnumerable coleccion) {
            foreach (Object item in coleccion)
            {
                Console.Write(" {0} ",item);
                Console.WriteLine();
            }
        }

    }
}
