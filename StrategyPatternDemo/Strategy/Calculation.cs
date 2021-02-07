using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    class Calculation
    {
        private ICalculationStrategy _strategy;

        public Calculation(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public double CalculationInterface(double firstNum, double secondNum)
        {
            return _strategy.Calculate(firstNum, secondNum);
        }
    }
}
