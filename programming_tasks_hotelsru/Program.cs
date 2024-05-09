using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{number} {GetComputerWord(number)}");
    }
    static string GetComputerWord(int number)
    {
        int lastDigit = number % 10;
        int secondLastDigit = (number / 10) % 10;
        if (secondLastDigit == 1)
        {
            return "Компьютеров";
        }
        else
        {
            switch (lastDigit)
            {
                case 1:
                    return "Компьютер";
                case 2:
                case 3:
                case 4:
                    return "Компьютера";
                default:
                    return "Компьютеров";
            }
        }
    }
}