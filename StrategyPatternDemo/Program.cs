using StrategyPatternDemo.Strategy;
using System;
using System.Collections.Generic;

namespace StrategyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mathOperatorList = new List<string>()
            {
                "+", "-", "/", "*"
            };
            while (true)
            {
                //Output of all available math types the program can run
                Console.WriteLine("What kind of math would you like to do?");
                foreach(string mathOperator in mathOperatorList)
                {
                    Console.Write($"\"{mathOperator}\" ");
                }

                //User inputs type of math that is to be used, if its not valid, a reset will be done
                var typeOfMath = Console.ReadLine().ToString();
                if (!mathOperatorList.Contains(typeOfMath))
                {
                    Console.WriteLine("\nNot a valid input, please try again!\n");
                    continue;
                }

                //User inputs numbers that is to be calculated
                Console.WriteLine("Input the first number");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                switch (typeOfMath)
                {
                    case "+":
                        break;
                    case "-":
                        break;
                    case "/":
                        break;
                    case "*":
                        break;
                }
            }
        }
    }
}
