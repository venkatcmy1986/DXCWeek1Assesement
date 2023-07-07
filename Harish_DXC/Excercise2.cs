using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Excercise2
{
    public static void Main()
    {
        int[] nums1 = { 1, 5,45,81,102,0,15,15,22,34,154, 1 };
        int[] nums2 = { 1, 45,1,24,25,315, 5 };
        Console.WriteLine("The given arrays are starting and ending with the same number or ending with the same number?:");

        if((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

