using System;

namespace MyApplication
{
    class Program
    {
        static void Cube(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ird be a kocka oldalának hosszát: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ird be a pozíció távolságát: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("\n****"));
            for (int i = 0; i < a; i++)
            {
                Console.Write("                        ");
                for (int j = 0; j < a; j++)
                {

                    Console.Write("[]");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Cube();
        }


    }
}
