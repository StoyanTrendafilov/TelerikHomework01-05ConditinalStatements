using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter three numbers :"); // Това е единия от вариантите. Направил съм и втори, който е закоментиран по-долу.
        double a = double.Parse(Console.ReadLine());        // На мен вторият ми харесва повече.
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        bool isAPositive = true;
        bool isBPositive = true;
        bool isCPositive = true;
        bool isResultPositive = true;

        if (a < 0)
        {
            isAPositive = false;
        }
        else
        {
            isAPositive = true;
        }
        if (b < 0)
        {
            isBPositive = false;
        }
        else
        {
            isBPositive = true;
        }
        if (c < 0)
        {
            isCPositive = false;
        }
        else
        {
            isCPositive = true;
        }
        isResultPositive = isAPositive && isBPositive && isCPositive;
        if (isResultPositive)
            Console.WriteLine("The product will be positive.");
        else
            Console.WriteLine("The product will ne negative.");



        //if ((a < 0) || (b < 0) || (c < 0))
        //{
        //    Console.WriteLine("The product of your numbers will be negative!");
        //}
        //else // Не е точно по условието, но е по-коректно и праволно. В противен случай може да се наблюдават грешки, а и цикъла става по-сложен.
        //{ // а ако задълбаем, трябва да проверяваме дали поне едно от числата не е 0, но това го няма като изискване
        //    Console.WriteLine("The product of your numbers will be positive!");
        //}
    }
}

