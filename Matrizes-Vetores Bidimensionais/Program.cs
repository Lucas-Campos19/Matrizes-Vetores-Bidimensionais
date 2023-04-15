using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_Vetores_Bidimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3,5];

            n[0, 0] = 1;
            n[0, 1] = 2;
            n[0, 2] = 3;
            n[0, 3] = 4;
            n[0, 4] = 5;

            n[1, 0] = 10;
            n[1, 1] = 20;
            n[1, 2] = 30;
            n[1, 3] = 40;
            n[1, 4] = 50;

            n[2, 0] = 100;
            n[2, 1] = 200;
            n[2, 2] = 300;
            n[2, 3] = 400;
            n[2, 4] = 500;

            Console.WriteLine(n[0,2]);
            Console.WriteLine(n[1,3]);
            Console.WriteLine(n[2,3]);
            Console.ReadKey();

        }
    }
}
