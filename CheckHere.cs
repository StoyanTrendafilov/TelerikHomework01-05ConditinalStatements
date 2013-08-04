using System;

class CheckHere
{
    static void Main(string[] args)
    {
        int sum = 0, count = 0; 
        int[] number = new int[5];
        Console.WriteLine("Please, enter five numbers : ");
        for (int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                sum = number[i] + number[j];
                Console.WriteLine("The sum of elements {0} and {1} = {2}", i, j, sum);
                if (sum == 0)
                {
                    Console.WriteLine("The sum of these elements is zero.");
                    count++;
                }
                for (int k = j + 1; k < 5; k++)
                {
                    sum = number[i] + number[j] + number[k];
                    Console.WriteLine("The sum of elements {0}, {1} and {2} = {3}", i, j, k, sum);
                    if (sum == 0)
                    {
                        Console.WriteLine("The sum of these elements is zero.");
                        count++;
                    }
                    for (int m = k + 1; m < 5; m++)
                    {
                        sum += number[m];
                        Console.WriteLine("The sum of elements {0}, {1}, {2} and {3} = {4}", i, j, k, m, sum);
                        if (sum == 0)
                        {
                            Console.WriteLine("The sum of these elements is zero.");
                            count++;
                        }
                        for (int n = m + 1; n < 5; n++)
                        {
                            sum += number[n];
                            Console.WriteLine("The sum of elements {0}, {1}, {2}, {3} and {4} = {5}", i, j, k, m, n, sum);
                            if (sum == 0)
                            {
                                Console.WriteLine("The sum of these elements is zero.");
                                count++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the subsets equal to Zero: {0}", count);
        Console.WriteLine();  
    }
}

