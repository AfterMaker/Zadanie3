using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[15];
        Random random = new Random();

        Console.WriteLine("Сгенерирован новый масив из 15 случайных чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 101);
            Console.Write(numbers[i] + " ");
        }

        int sum = 0;
        Console.WriteLine("\n\nРезультаты:");
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            if (numbers[i] <= -1)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        Console.WriteLine("Сумма всех чисел: " + sum);
        Console.WriteLine("Числа до 45: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] <= 45)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}