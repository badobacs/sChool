using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ird be a magasságot: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ird be a szélességet: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("\n****"));
            for (int i = 0; i <= x; i++)
            {
                Console.Write("                        ");
                for (int q = 0; q <= y; q++)
                {

                    Console.Write("H");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine(MyMethod(2 ,3));
        }
    }
}
