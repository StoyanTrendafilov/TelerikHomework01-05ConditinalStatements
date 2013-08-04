using System;

class YouChoose
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert 1 for int, 2 for double or 3 for string!");
        Console.Write("What is your choice : ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("======================");

        switch (choice)
        {
            case 1 : 
                Console.WriteLine("You have chosen an integer number.");
                Console.Write("Please, insert your number : ");
                int choiceInt = int.Parse(Console.ReadLine());
                choiceInt = choiceInt + 1;
                Console.WriteLine("======================");
                Console.WriteLine("And we will show you your number plus 1 - {0} !", choiceInt);
                break;
            case 2 :
                Console.WriteLine("You have chosen a real number.");
                Console.Write("Please, insert your number : ");
                double choiceReal = double.Parse(Console.ReadLine());
                choiceReal = choiceReal + 1;
                Console.WriteLine("======================");
                Console.WriteLine("And we will show you your number plus 1 - {0} !", choiceReal);
                break;
            case 3:
                Console.WriteLine("You have chosen a string.");
                Console.Write("Please, insert your number : ");
                string choiceStr = Console.ReadLine();
                choiceStr = choiceStr + "*";
                Console.WriteLine("======================");
                Console.WriteLine("And we will add \"*\" to your string - {0} !", choiceStr);
                break;


            default: Console.WriteLine("Invalid input, try again !"); break;
        }

        //int intTest = 0; //- Алтернативен вариант, който преценява дали е въведено цяло, реално числи или стринг и казва какво сме въвели. 
        //double doubleTest; //  Не можах да го направя със switch - case. Не съм и добавял промените в стойностите, защото така и така е следвам условието,
        //Console.WriteLine("Plese, type somethin :) "); // не видях смисъл.
        //string fromConsole = Console.ReadLine();
        //if (int.TryParse(fromConsole, out intTest))
        //    Console.WriteLine("You have entered an integer.");
        //else if (double.TryParse(fromConsole, out doubleTest))
        //    Console.WriteLine("You have entered a real number.");
        //else
        //    Console.WriteLine("You have entered some kind of string ;)");
    }
}

