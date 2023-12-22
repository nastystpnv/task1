using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] squaredArray = originalArray.Square();
            int[] cubedArray = originalArray.Cube();
            double averageValue = originalArray.Average();
            int sumValue = originalArray.Sum();
            int[] evenArray = originalArray.Even();
            int[] oddArray = originalArray.Odd();

            Console.WriteLine("original: " + string.Join(", ", originalArray));
            Console.WriteLine("squared: " + string.Join(", ", squaredArray));
            Console.WriteLine("cubed: " + string.Join(", ", cubedArray));
            Console.WriteLine("average: " + averageValue);
            Console.WriteLine("sum: " + sumValue);
            Console.WriteLine("even: " + string.Join(", ", evenArray));
            Console.WriteLine("odd: " + string.Join(", ", oddArray));

        }
    }
    
}
