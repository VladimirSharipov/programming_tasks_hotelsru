using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите числа через запятую: ");
        string[] inputs = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(inputs, int.Parse);
        int[] commonDivisors = FindCommonDivisors(numbers);
        Console.WriteLine("НОД: " + String.Join(", ", commonDivisors));
    }

    static int[] FindCommonDivisors(int[] numbers)
    {
        List<int> divisors = new();
        int minNumber = Int32.MaxValue;
        foreach (int number in numbers)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        for (int divisor = 2; divisor <= minNumber; divisor++)
        {
            bool isCommon = true;
            foreach (int number in numbers)
            {
                if (number % divisor != 0)
                {
                    isCommon = false;
                    break;
                }
            }
            if (isCommon)
            {
                divisors.Add(divisor);
            }
        }

        return divisors.ToArray();
    }
}
