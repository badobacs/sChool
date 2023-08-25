using System;

namespace Visible_Diamant
{
    class Program
    {
        static void Diamant()
        {
            Console.WriteLine("A gyémánt oldalszélessége:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A gyémánt oldal távolság:");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = i - k+1; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++)
                {
                    if (j == 1)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1- k; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++)
                {
                    if (j == i)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = i; j <= n; j++)
                {
                    if (j == n)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            
            Diamant();

        }
    }
}
