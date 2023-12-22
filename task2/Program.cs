using System;
using System.Linq;


namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "яблоко", "эпилепсия", "крот", "пацан" };

            string[] sortedArray = SortByLength(inputArray);

            Console.WriteLine("сортировка");
            foreach (string item in sortedArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static string[] SortByLength(string[] inputArray)
        {
            string[] sortedArray = inputArray.OrderBy(s => s.Length).ToArray();

            return sortedArray;
        }
    }
}
