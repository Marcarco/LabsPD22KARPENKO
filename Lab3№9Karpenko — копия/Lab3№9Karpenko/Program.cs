using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число =");
            string num1 = Console.ReadLine();
            int sum = 0;
            foreach (int x in num1)
            {
                sum += x;
            }

            if (sum % 2 == 0) Console.WriteLine("Чет");
            else Console.WriteLine("Нечет");
            Console.ReadLine();
        }
    }
}




