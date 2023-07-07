using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Excercise1
    {
        public static void Main()
        {

            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());


            for (int row = 0; row <= width; row++)
            {
                for (int column = 0; column < row; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();

            }
        }
    }
}