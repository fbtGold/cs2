using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[]{ 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Avg(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Avg(nums2));
        }

        static int Sum(IEnumerable num)
        {
            int sum = 0;
            foreach (int item in num)
            {
                sum += item;
            }
            return sum;
        }

        static double Avg(IEnumerable num)
        {
            int sum = 0;
            double count = 0;
            foreach (int item in num)
            {
                sum += item;
                count++;
            }
            return sum / count;
        }

        
    }
}
