using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // QUE 1
            // Console.WriteLine("Enter an amount to bet between $1 and $1000");
            // int amount = int.Parse(Console.ReadLine());
            
            // if(amount >= 1 && amount <= 1000)
            // {
            //     Console.WriteLine("Guess the total of two rolled dices.");
            //     int diceTotal = int.Parse(Console.ReadLine());

            //     Random dice1 = new Random();
            //     int dice1Rolled = dice1.Next(1, 7);
            //     Console.WriteLine(dice1Rolled);

            //     int dice2Rolled = dice1.Next(1, 7);
            //     Console.WriteLine(dice2Rolled);
            //     int rolledTotal = dice1Rolled + dice2Rolled;
            //     Console.WriteLine(rolledTotal);

            //         if(diceTotal == rolledTotal)
            //     {
            //         double wonBet = (amount * 8);
            //         Console.WriteLine("Correct! You just won " + wonBet);
            //     }
            //     else
            //     {
            //         int loseBet = (amount / );
            //         Console.WriteLine("You Lose! Your loss is " + loseBet)
            //     }
            // }
            // else
            // {
            //     {
            //         Console.WriteLine("Invalid Bet Amount");
            //     }
            // }

            // QUE 2
            // Console.WriteLine("What operation do you want to perform? - enter 1 for addition, 2 for multiplication, 3 for subrtaction, 4 for division and 5 for Exit");
            // int operand = int.Parse(Console.ReadLine());
            // double OperandSol;
            // string signInWords = "";

            // Console.WriteLine("Enter the first figure for operation");
            // double firstNum = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter the second figure for operation");
            // double secondNum = int.Parse(Console.ReadLine());

            // switch(operand)
            // {
            //     case 1:
            //     OperandSol  = firstNum + secondNum;
            //     signInWords = "Addition";
            //     Console.WriteLine("The solution of the " + signInWords + " operation is " + OperandSol);
            //     break;
            //     case 2:
            //     OperandSol = firstNum * secondNum;
            //     signInWords = "Multiplication";
            //     Console.WriteLine("The solution of the " + signInWords + " operation is " + OperandSol);
            //     break;
            //     case 3:
            //     OperandSol = firstNum - secondNum;
            //     signInWords = "Subtraction";
            //     Console.WriteLine("The solution of the " + signInWords + " operation is " + OperandSol);
            //     break;
            //     case 4:
            //     OperandSol = firstNum / secondNum;
            //     signInWords = "Division";
            //     Console.WriteLine("The solution of the " + signInWords + " operation is " + OperandSol);
            //     break;
                    // case 5:
                    // Console.WriteLine("Program Exit. Thank You.");
            //     default:
            //     Console.WriteLine("Invalid input");
            //     break;
            // }

            // QUE 3
            // Console.WriteLine("What shape do you want to calculate for?");
            // string geoShape = Console.ReadLine();

            // QUE 4
            // Console.WriteLine("Enter First number to be compared");
            // int num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter Second number to be compared");
            // int num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter Third number to be compared");
            // int num3 = int.Parse(Console.ReadLine());

            // int biggest = 0;
            // int midNum = 0;
            // int smallest = 0;

            // if(num1 == num2 && num2 == num3)
            // {
            //     Console.WriteLine("All numbers are equal");
            //     smallest = midNum = biggest = num1;
            // }
            // else if(num1 == num2)
            // {
            //     if(num1 > num3)
            //     {
            //         biggest = midNum = num1;
            //         smallest = num3;
            //     }
            //     else
            //     {
            //         smallest = midNum = num1;
            //         biggest = num3;
            //     }
            // }
            // else if(num1 == num3)
            // {
            //     if(num1 > num2)
            //     {
            //         biggest = midNum = num1;
            //         smallest = num2;
            //     }
            //     else
            //     {
            //         smallest = midNum = num1;
            //         biggest = num2;
            //     }
            // }
            // else if(num2 == num3)
            // {
            //     if(num2 > num1)
            //     {
            //         biggest = midNum = num2;
            //         smallest = num1;
            //     }
            //     else
            //     {
            //         smallest = midNum = num2;
            //         biggest = num1;
            //     }
            // }
            // else if(num1 > num2 && num1 > num3)
            // {
            //     biggest = num1;
            //     if(num2 > num3)
            //     {
            //         midNum = num2;
            //         smallest = num3;
            //     }
            //     else
            //     {
            //         midNum = num3;
            //         smallest = num2;
            //     }
            // }
            // else if(num2  > num1 && num2 > num3)
            // {
            //     biggest = num2;
            //     if(num1 > num3)
            //     {
            //         midNum = num1;
            //         smallest = num3;
            //     }
            //     else
            //     {
            //         midNum = num3;
            //         smallest = num1;
            //     }
            // }
            // else if(num3 > num1 && num3 > num2)
            // {
            //     biggest = num3;
            //     if(num1 > num2)
            //     {
            //         midNum = num1;
            //         smallest = num2;
            //     }
            //     else
            //     {
            //         midNum = num2;
            //         smallest = num1;
            //     }
            // }

            // Console.WriteLine(biggest);
            // Console.WriteLine(midNum);
            // Console.WriteLine(smallest);

            // QUE 5
            // Console.WriteLine("Enter student score from 1 to 9");
            // int score = int.Parse(Console.ReadLine());

            // if(score >= 1 && score <=3)
            // {
            //     score*=10;
            //     Console.WriteLine("The score is " + score);
            // }
            // else if(score >= 4 && score <=6)
            // {
            //     score*=100;
            //     Console.WriteLine("The score is " + score);
            // }
            // else if(score >= 7 && score <=9)
            // {
            //     score*=1000;
            //     Console.WriteLine("The score is " + score);
            // }
            // else
            // {
            //     Console.WriteLine("Error - Invalid Input");
            // }

            // QUE 6

            // QUE 7
            // Console.WriteLine("Enter First number to be compared");
            // int num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter Second number to be compared");
            // int num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter Third number to be compared");
            // int num3 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter Fourth number to be compared");
            // int num4 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter Fifth number to be compared");
            // int num5 = int.Parse(Console.ReadLine());
            
            // int greatest = 0;

            // if(num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5)
            // {
            //     greatest = num1;
            //     if(num1 > num3 && num1 > num4 && num1 > num5)
            //     {
            //         greatest = num1;
            //     }
            //     else if(num1 > num2 && num1 > num4 && num1 > num5)
            //     {
            //         greatest = num1;
            //     }
            //     else if(num1 > num2 && num1 > num3 && num1 > num5)
            //     {
            //         greatest = num1;
            //     }
            //     else if(num1 > num2 && num1 > num3 && num1 > num4)
            //     {
            //         greatest = num1;
            //     }
            //     else
            //     {
            //         if(num3 > num2 && num3 > num4 && num3 > num5)
            //         {greatest = num3;}
            //         else if(num2 > num4 && num2 > num5)
            //         {greatest = num2;}
            //         else if(num4 > num5)
            //         {greatest = num4;}
            //         else
            //         {greatest = num5;}
            //     }
            // }
            // else if(num2 == num3 || num2 == num4 || num2 == num5)
            // {
            //     greatest = num2;
            //      if(num2 > num3 && num2 > num4)
            //     {
            //         greatest = num2;
            //     }
            //     else if(num2 > num3 && num2 > num5)
            //     {
            //         greatest = num2;
            //     }
            //     else if(num2 > num4 && num2 > num5)
            //     {
            //         greatest = num2;
            //     }
            //     else
            //     {
            //         if(num3 > num4 && num3 > num5)
            //         {greatest = num3;}
            //         else if(num4 > num5)
            //         {greatest = num4;}
            //         else
            //         {greatest = num5;}
            //     }
            // }
            // else if(num3 == num4 || num3 == num5)
            // {
            //     greatest = num3;
            //      if(num3 > num4)
            //     {
            //         greatest = num3;
            //     }
            //     else if(num3 > num5)
            //     {
            //         greatest = num3;
            //     }
            //     else
            //     {
            //         if(num4 > num5)
            //         {greatest = num4;}
            //         else
            //         {greatest = num5;}
            //     }
            // }
            // else if(num4 == num5)
            // {
            //     greatest = num4;
            // }
            // else if(num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            // {
            //     greatest = num1;
            // }
            // else if(num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            // {
            //     greatest = num2;
            // }
            // else if(num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            // {
            //     greatest = num3;
            // }
            // else if(num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            // {
            //     greatest = num4;
            // }
            // else if(num5 > num1 && num5 > num3 && num5 > num4 && num5 > num2)
            // {
            //     greatest = num5;
            // }

            // Console.WriteLine("The greatest number is " + greatest);
            

            // QUE 8
             Console.WriteLine("Enter first number to be multiplied");
            int productNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to be multiplied");
            int productNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number to be multiplied");
            int productNum3 = int.Parse(Console.ReadLine());



            if(productNum1 == 0 || productNum2 == 0 || productNum3 == 0)
            {
                Console.WriteLine("The product is a zero");
            }
            else if(productNum1 < 1 && productNum2 < 1 && productNum3 < 1)
            {
                Console.WriteLine(" - ");
            }
            else if((productNum1 < 1 && productNum2 > 1 && productNum3 > 1) || (productNum1 > 1 && productNum2 < 1 && productNum3 > 1) || (productNum1 > 1 && productNum2 > 1 && productNum3 < 1))
            {
                Console.WriteLine(" - ");
            }
            else if((productNum1 < 1 && productNum2 < 1 && productNum3 > 1) || (productNum1 < 1 && productNum2 > 1 && productNum3 < 1) || (productNum1 > 1 && productNum2 < 1 && productNum3 < 1))
            {
                Console.WriteLine(" + ");
            }

            // QUE 9
            Console.WriteLine("Enter coefficient a");
            int aCoefficient = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coefficient b");
            int bCoefficient = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coefficient c");
            int cCoefficient = int.Parse(Console.ReadLine());

            // // Calculating the discriminant to know how many roots
            float discriminant = (bCoefficient * bCoefficient) - (4 * aCoefficient * cCoefficient);

            //Calculating the roots
            Console.WriteLine($"For this Quadratic Equation: {aCoefficient}x^2 + {bCoefficient}x + {cCoefficient}");
            if(discriminant == 0)
                {
                    decimal realRoot1 = 0m;
                    realRoot1 = -bCoefficient / (2 * aCoefficient);
                    Console.WriteLine($"The two roots of the equation are equal. the root = {realRoot1}");
                }
            else if(discriminant > 0)
                {
                    double x1 = 0;
                    double x2 = 0;
                    x1 = (-bCoefficient + Math.Sqrt(discriminant)) / (2 * aCoefficient);
                    x2 = (-bCoefficient - Math.Sqrt(discriminant)) / (2 * aCoefficient);
                    Console.WriteLine($"The first root is {x1} and the second root is {x2}");
                }
            else if(discriminant < 0)
                {
                    Console.WriteLine("This quadratic equation has no real roots");
                }

            // QUE 10
            // Console.WriteLine("Enter the month number");
            // int month = int.Parse(Console.ReadLine());
            // string monthInWords;

            // switch (month)
            // {
            //     case 1:
            //     monthInWords = "January";
            //     break;
            //     case 2:
            //     monthInWords = "February";
            //     break;
            //     case 3:
            //     monthInWords = "March";
            //     break;
            //     case 4:
            //     monthInWords = "April";
            //     break;
            //     case 5:
            //     monthInWords = "May";
            //     break;
            //     case 6:
            //     monthInWords = "June";
            //     break;
            //     case 7:
            //     monthInWords = "July";
            //     break;
            //     case 8:
            //     monthInWords = "August";
            //     break;
            //     case 9:
            //     monthInWords = "September";
            //     break;
            //     case 10:
            //     monthInWords = "October";
            //     break;
            //     case 11:
            //     monthInWords = "November";
            //     break;
            //     case 12:
            //     monthInWords = "December";
            //     break;
            //     default:
            //     monthInWords = "Invalid Input";
            //     break;
            // }

            // Console.WriteLine(monthInWords);

        }
    }
}
