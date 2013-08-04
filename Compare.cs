using System;

class Compare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter three digits:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The first number is the greatest!");
            }
            else
            {
                Console.WriteLine("The third number is the greatest!");
            }
        }

        else
        {
            if (b > c)
            {
                Console.WriteLine("The second number is the greatest!");
            }
            else
            {
                Console.WriteLine("The third number is the greatest!");
            }
        }
    }
}

