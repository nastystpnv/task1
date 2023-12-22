using System;
using System.Linq;

public static class ArrayExtensions // я не знаю, что с этим стеком делать я уже все испробовала все оверфлоат
{
    public static int[] Square(this int[] array)
    {
        return array.Select(x => x * x).ToArray();
    }

    public static int[] Cube(this int[] array)
    {
        return array.Select(x => x * x * x).ToArray();
    }

    public static double Average(this int[] array)
    {
        if (array.Length == 0)
            return double.NaN;

        return array.Average();
    }

    public static int Sum(this int[] array)
    {
        return Enumerable.Sum(array);
    }

    public static int[] Even(this int[] array)
    {
        return array.Where(x => x % 2 == 0).ToArray();
    }

    public static int[] Odd(this int[] array)
    {
        return array.Where(x => x % 2 != 0).ToArray();
    }
}

