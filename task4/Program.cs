using System;
using System.Text.RegularExpressions;


namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { ":)", ":D", ";-D", ":~)", ";(", ":>", ":}", ":]" };

            int result = CountSmileys(arr);

            Console.WriteLine("количество смайликов: " + result);
        }

        static int CountSmileys(string[] arr)
        {
            int count = 0;
            string pattern = @"[:;][-~]?[)D]";

            foreach (string str in arr)
            {
                if (Regex.IsMatch(str, pattern))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
