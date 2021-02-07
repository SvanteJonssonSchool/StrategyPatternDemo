using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class DefaultStrategy : ICalculationStrategy
    {
        public double Calculate(double firstNum, double secondNum)
        {
            throw new NotImplementedException();
        }
    }
}