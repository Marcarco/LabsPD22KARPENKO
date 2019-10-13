using static System.Console;
using System.Collections.Generic;
class test
{
    static void Show(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Write("{0,4}", m[i, j]);
            WriteLine();
        }
    }
    static void Main()
    {
        Write("N = "); int n = int.Parse(ReadLine());
        Write("M = "); int m = int.Parse(ReadLine());
        var inds = new List<int>();
        int[,] a = new int[n, m];
        for (int i = 0; i < m; i++)
        {
            bool b = true;
            for (int j = 0; j < n; j++)
            {
                Write("A[" + j + "," + i + "] = ");
                a[j, i] = int.Parse(ReadLine());
                if (a[j, i] % 2 != 0) b = false;
            }
            if (b) inds.Add(i);
        }
        WriteLine();
        Show(a);
        WriteLine();
        WriteLine(inds.Count == 0 ? "нету таких столбцов" : "номер столбца : " + string.Join(", ", inds));
        ReadKey(true);
    }
}