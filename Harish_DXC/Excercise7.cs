using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        String name;
        String address;
        long phoneNumber;
        public void details(String n, String a, long p)
        {
            name = n;
            address = a;
            phoneNumber = p;

        }
    }
    class Student : Person
    {
        String name;
        String address;
        long phoneNumber;
        int Roll_number;
        String course;
        int marks;
        String college;

        public void details(String n, String a, long p, int r, String c, int m, String col)
        {
            name = n;
            address = a;
            phoneNumber = p;
            Roll_number = r;
            course = c;
            marks = m;
            college = col;


        }
     }
class Excercise7
{ 
    public static void Main(String[] args)
    {
        Student obj = new Student();
        obj.show();

    }
}

}