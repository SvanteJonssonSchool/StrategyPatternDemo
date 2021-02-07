using StrategyPatternDemo.Strategy;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                FaultyInput:
                string numberInputOne;
                string numberInputTwo;
                Console.WriteLine("Input the first number");
                numberInputOne = Console.ReadLine();
                Console.WriteLine("Input the second number");
                numberInputTwo = Console.ReadLine();
                if (!Regex.IsMatch(numberInputOne, "^(-?)(0|([1-9][0-9]*))(\\.[0-9]+)?$") || !Regex.IsMatch(numberInputTwo, "^(-?)(0|([1-9][0-9]*))(\\.[0-9]+)?$"))
                {
                    Console.WriteLine($"One or both of you inputs were not valid please try again\nInput one: {numberInputOne}\nInput two: {numberInputTwo}");
                    goto FaultyInput;
                }
                double firstNum = Convert.ToDouble(numberInputOne);
                Console.WriteLine("Input the second number");
                double secondNum = Convert.ToDouble(numberInputTwo);

                ICalculationStrategy mathStrategy = new DefaultStrategy();

                switch (typeOfMath)
                {
                    case "+":
                        mathStrategy = new AdditionStrategy();
                        break;
                    case "-":
                        mathStrategy = new SubtractionStrategy();
                        break;
                    case "/":
                        mathStrategy = new DivisionStrategy();
                        break;
                    case "*":
                        mathStrategy = new MultiplicationStrategy();
                        break;
                    default:
                        break;
                }

                //Inputs are calculated
                var calculate = new Calculation(mathStrategy);

                Console.WriteLine($"The result is: {calculate.CalculationInterface(firstNum, secondNum)}");
            }
        }
    }
}
