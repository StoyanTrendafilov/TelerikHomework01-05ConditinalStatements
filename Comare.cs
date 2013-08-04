using System;

class Comare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, insert five different numbers : "); // Вариант 1

        int[] number = new int[5]; // Създаваме масив, в който да запазваме стойността на променливите. Избрал съм инт, защото най-много ми харесва
        int greatestNumber = 0; // Създаваме променлива, в която да пазим стойността на най-голямото число.

        for (int i = 0; i < 5; i++) // С този цикъл парсваме стойносттите на променливите в променливите от масива.
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 4; i++)
        {
            if (number[i + 1] > number[i])
            {
                greatestNumber = number[i+1];
            }

        }
        Console.WriteLine("The greatest number is {0} !", greatestNumber);

        //int a = int.Parse(Console.ReadLine());  Това е вариант 2, в който ако числа 2 и 4 имат една и съща стойност, ще изпише само две, заради if-else
        //int b = int.Parse(Console.ReadLine());  конструкцията. Ако манем else преди всеки следващ if ще изписва и за двата. На мен некоментираният
        //int c = int.Parse(Console.ReadLine());  вариант ми харесва повече.
        //int d = int.Parse(Console.ReadLine());
        //int e = int.Parse(Console.ReadLine());
        
        //if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        //    Console.WriteLine("Your first number is the greatest ! : " + a);

        //else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
        //    Console.WriteLine("Your second number is the greatest ! : " + b);

        //else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))           // MAI TOWA E NAI-PRAWILNIQ WARINAT - S ELSE IF.
        //    Console.WriteLine("Your third number is the greatest ! : " + c);

        //else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        //    Console.WriteLine("Your fourth number is the greatest ! : " + d);

        //else if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
        //    Console.WriteLine("Your fifth number is the greatest ! : " + e);
        
    }
}

