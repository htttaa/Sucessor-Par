using System;

class DIO
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y;
        if (x % 2 == 0)
        {
            y = x + 2;
        }
        else
        {
            y = x + 1;
        }
        Console.WriteLine(y);
    }
}