using System;

namespace sqare
{
    class Program
    {
        static void Square()
        {
            int n = 5;
                for (int i = 1; i <=n; i++)
            {
                for (int j = 0; j <=n; j++)
                {
                    if (j==1 || j ==n)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Square();
        }
    }
}
