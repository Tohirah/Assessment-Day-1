using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // QUE 1
            // Console.WriteLine("Enter the nth term");
            // int nthTerm = int.Parse(Console.ReadLine());

            // int a = 0;
            // int b = 1;
            // int c;

            // Console.Write(a + ", " + b + ", ");
            // for(int j = 0; j <= nthTerm - 2; j++)
            // {                
            //     c = a + b;
            //     if(j < nthTerm - 2)
            //     {
            //     Console.Write(c + ", ");
            //     }
            //     else
            //     {
            //         Console.Write(c);
            //     }

            //     a = b;
            //     b = c;

            // }

            // QUE 2
            // Console.WriteLine("Enter Last number");
            // int lastNum = int.Parse(Console.ReadLine());

            // for(int k = 1; k <= lastNum; k++)
            // {
            //     for(int d = 1; d <= k; d++)
            //     {
            //         Console.Write(k);
            //     }
            //     Console.WriteLine("");
            // }

            // QUE 4
            Console.WriteLine("Enter the value for x");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of terms");
            int terms = int.Parse(Console.ReadLine());

            int power = 3;
            double sol = num;

            for(int k = 2; k <= terms; k++)
            {
                double square = (Math.Pow(num, power));

                 if(k % 2 == 0)
                {
                    square *=(-1);
                }
                Console.WriteLine(square);

                sol += square;                

                power +=2;
            }

            Console.WriteLine(sol);

            // QUE 6
            // Console.WriteLine("Enter the first factorial");
            // int n1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the second factorial");
            // int n2 = int.Parse(Console.ReadLine());

            // int K = 1;
            // int N = 1;

            // if(1 < n1 && n1 < n2)
            // {
            //     for(int i = n1; i <= n1 && i > 0; i--)
            //     {
            //         K *=i;
            //     }
            // for(int m = n2; m <= n2 && m > 0; m--)
            //     {
            //         N *=m;
            //     }
            //      int ans = N / K;
            //      Console.WriteLine(n2 + "! / " + n1 + "! = " + ans);
            // }
            
            // else
            // {
            //     Console.WriteLine("First factorial is higher than second factorial");
            // }

            // QUE 7
            // Console.WriteLine("Enter the nth Term");
            // int nthTterm = int.Parse(Console.ReadLine());

            // Random rand = new Random();

            // for(int j = 1; j <= nthTterm; j++)
            // {
            //     int k = rand.Next(1, nthTterm + 1);
            //     Console.WriteLine(k);
            // }

            // QUE 8
            // Console.WriteLine("Enter desired number");
            // int numDiv = int.Parse(Console.ReadLine());

            // int j = 1;

            // while (j <= numDiv)
            //     {
            //         if( j % (3 * 7) != 0)
            //         {
            //             Console.WriteLine(j);
            //              j++;
            //         }
            //         else
            //         {
            //             j++;
            //         }   
            //     }

            //  QUE 9


            // QUE 10
            // Console.WriteLine("The answer is C - While do")

        }
    }
}
