using System;
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
            /*Arreglo unidimencional */
            int[] numero = new int[3];
            numero[0] = 10;
            numero[1] = 20;
            numero[2] = 30;

            Console.WriteLine("Recorriendo el vector ");
            foreach (int  i in numero)
            {
                Console.WriteLine("El elemento es : "+ i+Environment.NewLine);
            }

            /*Arreglo bidimencional o matrices*/
            int[,] matriz = new int[3, 3];
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Ingrese los numero : ");
                    matriz[fila, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            matriz[0, 1] = 20;
            Console.WriteLine("imprimiento la matriz  ");
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.Write(" " + matriz[fila,col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
