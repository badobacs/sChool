using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            Console.WriteLine("Ird be az első számot");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ird be a második számot ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                return x * y;
            }
            else
            {
                return x + y;
            }
            
        }

        static void Main(string[] args)
        {

            Console.WriteLine(MyMethod(2 ,3));
        }
    }
}
