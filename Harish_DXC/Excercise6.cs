using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicle
    {

        String brand="";
        String color="";
        int price=0;
        int year=0;

        public Vehicle(String b, String c, int p, int y)
        {
            year = y;
            brand = b;
            price = p;
            color = c;
        }
        public void Display()
        {
            Console.WriteLine($"{brand} car of {color} color and a year of make of {year} is available for {price}");
        }
    }
}
    public class Excercise6
    {
        static void Main(String[] args)
        {
        Vehicle obj = new Vehicle("Mahindra", "Red", 1500000, 2023);
        obj.Display();

        }
    }
