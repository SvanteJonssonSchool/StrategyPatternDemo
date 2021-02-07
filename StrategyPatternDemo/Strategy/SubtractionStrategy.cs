using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class SubtractionStrategy : ICalculationStrategy
    {
        public double Calculate(double firstNum, double secondNum)
        {
            return (firstNum - secondNum);
        }
    }
}
