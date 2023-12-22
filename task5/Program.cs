using System;
using System.Linq;
;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 4, -1, -3 };
            int? result1 = FindClosestToZero(array1);
            Console.WriteLine(result1);

            int[] array2 = { 5, 2, -2 };
            int? result2 = FindClosestToZero(array2);
            Console.WriteLine(result2);

            int[] array3 = { 5, 2, 2 };
            int? result3 = FindClosestToZero(array3);
            Console.WriteLine(result3);

            int[] array4 = { 13, 0, -6 };
            int? result4 = FindClosestToZero(array4);
            Console.WriteLine(result4);
        }

        static int? FindClosestToZero(int[] array)
        {
            int closest = array[0];

            foreach (int num in array)
            {
                if (Math.Abs(num) < Math.Abs(closest) || (Math.Abs(num) == Math.Abs(closest) && num > closest))
                {
                    closest = num;
                }
            }

            if (array.Count(num => Math.Abs(num) == Math.Abs(closest)) > 1)
            {
                return null;
            }

            return closest;
        }
    }
}
