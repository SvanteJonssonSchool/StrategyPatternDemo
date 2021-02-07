using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    interface ICalculationStrategy
    {
        double Calculate(double firstNum, double secondNum);
    }
}
