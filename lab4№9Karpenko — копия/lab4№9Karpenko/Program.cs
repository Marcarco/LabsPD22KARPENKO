using System;

public static class Program
{
    public static void Main()
    {
        const int N = 5, MIN = 0, MAX = 11;

        var randomizer = new Random();
        var array = new int[N];

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = randomizer.Next(MIN, MAX);
        }

        Console.Write("Начальный массив: ");
        Console.WriteLine(string.Join(", ", array));

        int temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;

        Console.Write("Результирующий массив: ");
        Console.WriteLine(string.Join(", ", array));
    }
}