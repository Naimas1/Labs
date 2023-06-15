using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть першу цифру:");
        int digit1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть другу цифру:");
        int digit2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть третю цифру:");
        int digit3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть четверту цифру:");
        int digit4 = Convert.ToInt32(Console.ReadLine());

        int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

        Console.WriteLine($"Створене число: {number}");
    }
}


