﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ConsoleApp1
{
            
public class Exercise3
    {
        public static void Main()
        {
            int p, c, m;

            Console.Write("Marks obtained in Physics :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marks obtained in Chemistry :");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marks obtained in Mathematics :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
            Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

            if ((m >= 65) && (p>=55)&&(c>=50))
                if ((m + p + c) >= 180 || (m + p) >= 140||(m+c) >=140)
                            Console.Write("The  candidate is eligible for admission.\n");
                        
                else
                    Console.Write("The candidate is not eligible.\n\n");
            else
                Console.Write("The candidate is not eligible.\n\n");
        }
    }
}
