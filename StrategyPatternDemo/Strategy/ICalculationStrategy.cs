using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    interface ICalculationStrategy
    {
        void Calculate(double numberOne, double numberTwo);
    }
}
