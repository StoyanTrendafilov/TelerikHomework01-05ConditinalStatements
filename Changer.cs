using System;

class Changer
{
    static void Main(string[] args)
    {
        Console.Write("Enter two numbers : ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("The two nubers have exchanged their places ! {0}, {1}", a, b);
        }
        else
        {
            Console.WriteLine("The two numbers will not exchange their places ! {0}, {1} ", a, b);
        }
    }
}

