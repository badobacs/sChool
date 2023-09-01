using System;

namespace Bloodgroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a vércsoportod betüpárosát:");
            string b = Console.ReadLine();
            //Console.WriteLine("Your age is: ");
            if (b == "aa" || b == "a0" || b == "0a")
            {
                Console.WriteLine("A vércsoportod: A");
            }
            else if (b == "bb" || b == "b0" || b == "0b")
            {
                Console.WriteLine("A vércsoportod: B");
            }
            else if (b == "00")
            {
                Console.WriteLine("A vércsoportod: 0");
            }
            else
            {
                Console.WriteLine("Irjon be érvényes karakterpárt.");

            }



        }

    }
}
