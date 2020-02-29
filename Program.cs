using System;

namespace Methods_Project
{
    class Program
    {
        static void PrintMessage(string work, int X, int Y)
        {
            bool divideByZeroError = false;

            if (Y == 0)
            {
                divideByZeroError = true;
            }

            static double basicCalucation(double x, double y, int func);


        }
         
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Michael Hansen");

            int X;
            int Y;
            string work;

            Console.WriteLine("Please enter the first number of the equation");

            while (!int.TryParse(Console.ReadLine(), out X))
            {
                Console.Clear();
                Console.WriteLine("Please enter numbers only!");
            }

            Console.WriteLine("The first number you entered is:" + X);
            Console.WriteLine("Please enter the second number of the equation");

            while (!int.TryParse(Console.ReadLine(), out Y))
            {
                Console.Clear();
                Console.WriteLine("Please enter numbers only!");
            }

            Console.WriteLine(" The second number you entered is:" + Y);

            Console.WriteLine(" Please enter an addition, subtraction, division, or multiplication sign");

            work = Console.ReadLine();

            basicCalculation(X, Y, work);
        }
    }

