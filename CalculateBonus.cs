using System;

class CalculateBonus
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter your digit, different by zero :) ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine("Your bonus is {0} !", (10 * number)); break;
            case 4:
            case 5:
            case 6: Console.WriteLine("Your bonus is {0} !", (100 * number)); break;
            case 7:
            case 8:
            case 9: Console.WriteLine("Your bonus is {0} !", (1000 * number)); break;

            default: Console.WriteLine("Wrong input, please try again :) "); break;

        }       
    }
}

