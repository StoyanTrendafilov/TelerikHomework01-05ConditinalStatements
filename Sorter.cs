using System;

class Sorter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter three numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("---------------------");

        if ((a > b) && (a > c))
        {
            if (b > c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        else// Може и без този else, въпрос на виждане. Оставил съм го заради условието на задачата, иначе бих го изтрил с удовослтвие.
        {
            if ((c > a) && (c > b))
            {
                if (b > a)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
            if ((b > c) && (b > a))
            {
                if (a > c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }

            }
        }
    }
}

