using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //QUE 1
            Console.WriteLine("The correct answer is \" B \" ");

            // QUE 2
            Console.WriteLine("The correct answer is \" C \" ");

            // QUE 3
            Console.WriteLine("The correct answer is \" E \" ");

            // QUE 4
            // Console.WriteLine("Enter the number to check");
            // int prime = int.Parse(Console.ReadLine());

            // bool checkPrime = true;

            // if(prime % 2 == 0)
            // {
            //     checkPrime = false;
            // }
            // else if (prime == 1 || prime == 2 || prime == 3)
            // {
            //     checkPrime = true;
            // }
            // else if (prime > 3)
            // {
            //     int count = 1;
            //     for(int h = 3; h <= prime; h++)
            //     {
            //         if(prime % h == 0)
            //         {
            //             count++;
            //         }
            //        if(count > 2)
            //        break;
            //     }
            //      if(count > 2)
            //         {
            //             checkPrime = false;
            //         }
            //         else
            //         {
            //             checkPrime = true;
            //         }
            // }

            // Console.WriteLine("Is the number " + prime + " prime? - " + checkPrime);

            // QUE 5
            // Console.WriteLine("Enter a four digit number");
            // int digit = int.Parse(Console.ReadLine());

            // if(digit < 1000 || digit > 9999)
            // {
            //     Console.WriteLine("Invalid Input");
            // }
            // else 
            // {
            //     int lastNum = digit % 10;
            //     int thirdNum = (digit / 10) % 10;
            //     int secondNum = (digit / 100) % 10;
            //     int firstNum = (digit / 1000) % 10;
            //     Console.WriteLine("The sum of all digits is " + firstNum +  secondNum  + thirdNum  + lastNum);
            //     Console.WriteLine("The digits in reverse - " + lastNum + "" +  thirdNum + ""  + secondNum + "" + firstNum);
            //     Console.WriteLine("The last digit in first position - " + lastNum + "" +  firstNum + ""  + secondNum + "" + thirdNum);
            //     Console.WriteLine("Exchange second and third digit - " + firstNum +  thirdNum  + secondNum  + lastNum);
            // }

            // QUE 7
            // Console.WriteLine("Enter number to check divisibility");
            // int num = int.Parse(Console.ReadLine());

            // Console.WriteLine(num % 5 == 0 && num % 7 == 0);

            // QUE 8
            // Console.WriteLine("Enter weight of the man on earth");
            // float earthWeight = float.Parse(Console.ReadLine());

            // float moonWeight = earthWeight * 0.17f;
            // Console.WriteLine("The weight of the on the moon is " + moonWeight);

            // QUE 10
            Console.WriteLine("Enter a value in pounds");
            float pounds = float.Parse(Console.ReadLine());

            float kilogram = pounds * 0.454f;
            Console.WriteLine("The kilogram equivalent is " + kilogram + "kg");

        }
    }
}
