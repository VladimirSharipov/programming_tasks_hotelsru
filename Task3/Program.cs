using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите минимальное число: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите максимальное число: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] primeNumbers = GetPrimeNumbersInRange(min, max);
        Console.WriteLine("Простые числа в диапазоне: " + String.Join(", ", primeNumbers));
    }

    static int[] GetPrimeNumbersInRange(int min, int max)
    {
        List<int> primeNumbers = new List<int>();
        for (int num = min; num <= max; num++)
        {
            if (IsPrime(num))
            {
                primeNumbers.Add(num);
            }
        }
        return primeNumbers.ToArray();
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
