using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите размер ромба: ");
            if (int.TryParse(Console.ReadLine(), out int size))
            {
                string diamond = PrintDiamond(size);

                if (diamond != null)
                {
                    Console.WriteLine(diamond);
                }
                else
                {
                    Console.WriteLine("нельзя использовать четные и отрицательные числа");
                }
            }
            else
            {
                Console.WriteLine("введите целое число");
            }
            Console.ReadKey();
        }

        static string PrintDiamond(int size)
        {
            if (size <= 0 || size % 2 == 0)
            {
                return null;
            }

            string result = "";

            for (int i = 0; i < size; i++)
            {
                int spaces = Math.Abs(size / 2 - i);
                int stars = size - 2 * spaces;

                result += new string(' ', spaces) + new string('*', stars) + "\n";
            }

            return result;
        }
    }
}
