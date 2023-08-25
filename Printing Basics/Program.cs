using System;
using System.Runtime.ExceptionServices;

namespace Printing_Basics
{
    class Program
    {
        static void Method_II()
        {
            int n = 5;
            //int k = 20;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    if (j==1 || j==n)
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
        static void MethodPlus()
        {
            int n = 5;
            //int k = 20;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == n/2+1 || j == n / 2 + 1)
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
        static void MethodX()
        {
            int n = 5;
            //int k = 20;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j || i+j == n + 1)
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
        static void HollowSquare()
        {
            int n = 5;
            //int k = 20;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1|| i == n || j == n)
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
        static void HollowTriangle()
        {
            int n = 5;
            //int k = 20;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == 1 || j == i)
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
        static void HollowTriangleII()
        {
            int n = 5;
            //int k = 20;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (i == 1 || j ==i || j == n)
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
        static void HollowHill()
        {
            int n = 5;
            for (int i = 1; i <=n; i++)
            {
                //First triangle
                for (int j = i; j <=n; j++)
                {
                    Console.Write("  ");
                }
                //Secound triangle
                for (int j = 1; j < i; j++)
                {
                    if (i== n || j== 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                //Third triangle
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == i )
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
        static void Diamant()
        {
            int n = 5;
            for (int i = 1; i < n; i++)
            {
                for (int j = i+1; j <=n; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++)
                {
                    if (j==1)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = 1; j <=i; j++)
                {
                    if (j==i)
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
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++)
                {
                    if (j==i)
                    {

                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = i; j <=n; j++)
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
            //Method_II();
            //MethodPlus();
            //MethodX();
            //HollowSquare();
            //HollowTriangle();
            //HollowTriangleII();
            //HollowHill();
            Diamant();

        }
    }
}
