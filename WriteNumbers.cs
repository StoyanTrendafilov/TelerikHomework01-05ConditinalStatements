using System;

class WriteNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert a number in range form 0 to 999 : ");
        int number = int.Parse(Console.ReadLine());
        string chisloto = Convert.ToString(number, 10).PadLeft(3, '0');

        char[] chislo = chisloto.ToCharArray();


        int byHundred = Convert.ToInt32(new string(chislo[0], 1));
        int byTen = Convert.ToInt32(new string(chislo[1], 1));
        int byOne = Convert.ToInt32(new string(chislo[2], 1));






        string resultByHundred = null, resultByTen = null, resultByOne = null;

        switch (byHundred)
        {
            case 0: resultByHundred = ""; break;
            case 1: resultByHundred = " One hundred"; break;
            case 2: resultByHundred = " Two hundred"; break;
            case 3: resultByHundred = " Three hundred"; break;
            case 4: resultByHundred = " Four hundred"; break;
            case 5: resultByHundred = " Five hundred"; break;
            case 6: resultByHundred = " Six hundred"; break;
            case 7: resultByHundred = " Seven hundred"; break;
            case 8: resultByHundred = " Eight hundred"; break;
            case 9: resultByHundred = " Nine hundred"; break;

            default: break;
        }

        switch (byTen)
        {
            case 0: resultByTen = ""; break;
            case 1:
                switch (byOne)
                {
                    case 0: resultByTen = " and ten"; break;
                    case 1: resultByTen = " and eleven"; break;
                    case 2: resultByTen = " and twelwe"; break;
                    case 3: resultByTen = " and thirteen"; break;
                    case 4: resultByTen = " and fourteen"; break;
                    case 5: resultByTen = " and fifteen"; break;
                    case 6: resultByTen = " and sixteen"; break;
                    case 7: resultByTen = " and seventeen"; break;
                    case 8: resultByTen = " and eighteen"; break;
                    case 9: resultByTen = " and nineteen"; break;

                    default: break;
                }
                break;
            case 2: resultByTen = " twenty"; break;
            case 3: resultByTen = " thirty"; break;
            case 4: resultByTen = " fourty"; break;
            case 5: resultByTen = " fifty"; break;
            case 6: resultByTen = " sixty"; break;
            case 7: resultByTen = " seventy"; break;
            case 8: resultByTen = " eighty"; break;
            case 9: resultByTen = " ninety"; break;

            default: break;
        }
        switch (byOne)
        {
            case 0: resultByOne = ""; break;
            case 1: resultByOne = " and one "; break;
            case 2: resultByOne = " and two "; break;
            case 3: resultByOne = " and three"; break;
            case 4: resultByOne = " and four "; break;
            case 5: resultByOne = " and five"; break;
            case 6: resultByOne = " and six"; break;
            case 7: resultByOne = " and seven"; break;
            case 8: resultByOne = " and eight "; break;
            case 9: resultByOne = " and nine"; break;
            default: break;
        }
        if (byTen == 1)
            Console.WriteLine("You have entered{0}{1}", resultByHundred, resultByTen);
        else
            Console.WriteLine("You have entered{0}{1}{2}", resultByHundred, resultByTen, resultByOne);
    }
}

