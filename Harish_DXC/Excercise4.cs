using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Excercise4

    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, i, c, n, j;
            Console.Write("Enter the limit: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + " ");
                for (j = 1; j < i; j++)
                {
                    c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
                Console.Write("\n");
            }
        }
    }
}
