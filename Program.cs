using System;

class Program
{
    static void Main(string[] args)
    {
        // Введення першого числа
        Console.WriteLine("Введіть перше число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Введення другого числа
        Console.WriteLine("Введіть друге число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Розрахунок суми
        int sum = num1 + num2;

        // Виведення результату
        Console.WriteLine("Сума двох чисел: " + sum);
    }
}
