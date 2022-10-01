using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] A = { 1, 3, 4, 5, 6 };///[1][3][4][5][6]  //inicializar un Vector






            ///Matriz Original
            int[,] A = { { 1, 0, 0, 0, 0, 0 }, 
                         { 3, 2, 0, 0, 3, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0,-4 },
                         { 1,-2, 0, 0, 0, 1 },
                         { 0, 0, 0, 0, 1, 0 }
                        };


            clsSpar m = new clsSpar();
            Console.WriteLine("--------Matriz Original-----------------");
            System.Console.WriteLine(m.MostrarMatriz(A));
            Console.WriteLine("-------------------------");
            m.Cargar(A);
            Console.WriteLine("-------Matriz Sparce------------------");

            System.Console.WriteLine(m.MostrarMatrizSparce());
            Console.ReadKey();

        }
    }
}
