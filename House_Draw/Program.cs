using System;

namespace House_Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            



            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(" ");

            //}
            int hi = 5;
            int wi = 4;

            for (int z = 0; z <= hi; z++)
            {
                Console.Write("                                    ");
                for (int q = 0; q <= wi; q++)
                {

                    Console.Write("H");
                }
                Console.WriteLine();
            }


            //tető
            int h = 15;
            int w = h*4+10;

            int t = h*3;
            int t1 = t - 1;
            
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 30; i < t; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("               ");
                for (int j = i; j <= t1; j++)
                {

                    Console.Write(" ");

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("U");

                }
                for (int l = 2; l <= i; l++)
                {
                    if (l-1==i)
                    {
                        //Console.Write("*");
                    }
                    Console.Write("U");

                }
                Console.WriteLine();
            }
            //Falak

            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Ird be a magasságot: ");
            //h = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ird be a szélességet: ");
            //w = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(("\n****"));
            for (int z = 0; z <= h; z++)
            {
                Console.Write("                        ");
                for (int q = 0; q <= w; q++)
                {

                    Console.Write("H");
                }
                Console.WriteLine();
            }
        }
    }
}
