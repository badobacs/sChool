using System;

namespace VarMeth
{
    class Program
    {
        static void Cube()
        {
            //Console.WriteLine("Enter the size of the margin:");
            //int s = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the length of the side of the cube:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int k = 5;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {

                    Console.Write("* ");
                }
                Console.WriteLine("*");

            }
        }
        static void Triangle()
        {
            //Console.WriteLine("Enter the size of the margin:");
            //int s = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the length of the side of the triangle:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int k = 5;
            for (int i = 1; i<=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
        static void DecreasingTriangle()
        {
            //Console.WriteLine("Enter the size of the margin:");
            //int s = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the length of the side of the DecreasingTriangle:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int k = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {

                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
        static void RsTriangle()
        {
            
            Console.WriteLine("Enter the length of the side of the half of Sandglass:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int k = 5;

            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
        static void Hill()
        {
            


            Console.WriteLine("Enter the length of the side of the Hill:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int k = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
        static void RewHill()
        {
            Console.WriteLine("Enter the length of the side of the Reverse Hill:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int k = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++)
                {
                    Console.Write("* ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }


        static void Main(string[] args)
        {
            Cube();
            Triangle();
            DecreasingTriangle();
            Hill();
            RsTriangle();
            RewHill();
        }
    }
}
