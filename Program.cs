using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap vao mot chuoi:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Nhap vao ky tu can dem:");
        char targetChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = CountOccurrences(inputString, targetChar);

        Console.WriteLine($"So lan xuat hien cua ky tu '{targetChar}' trong chuoi la: {count}");
    }

    static int CountOccurrences(string inputString, char targetChar)
    {
        int count = 0;
        foreach (char c in inputString)
        {
            if (c == targetChar)
            {
                count++;
            }
        }
        return count;
    }
}