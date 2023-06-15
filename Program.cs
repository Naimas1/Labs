using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть початок діапазону: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Числа Фібоначчі у заданому діапазоні:");

        int fib1 = 0;
        int fib2 = 1;

        while (fib1 <= end)
        {
            if (fib1 >= start)
            {
                Console.Write(fib1 + ", ");
            }

            int nextFib = fib1 + fib2;
            fib1 = fib2;
            fib2 = nextFib;
        }

        Console.ReadLine();
    }
}
