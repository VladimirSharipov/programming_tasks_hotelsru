using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        MultiplicationTable(number);
    }

    static void MultiplicationTable(int number)
    {
        int lenMaxNum = number.ToString().Length + (number * number).ToString().Length;
        for (int row = 0; row <= number; row++)
        {
            for (int column = 0; column <= number; column++)
            {
                if (row == 0 || column == 0)
                    Console.Write((row + column).ToString().PadLeft(lenMaxNum));
                else
                    Console.Write((row * column).ToString().PadLeft(lenMaxNum));
            }
            Console.WriteLine();
        }
    }
}
