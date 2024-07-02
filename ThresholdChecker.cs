using System;
namespace ThresholdCheckerApp
{
    //Using this class to call the respective implemented Compare method.
    public class ThresholdChecker
    {
        private readonly IComparisonStrategy _strategy;

        public ThresholdChecker(IComparisonStrategy strategy)
        {
            _strategy = strategy;
        }

        public bool CheckThreshold(double value1, double value2)
        {
            return _strategy.Compare(value1, value2);
        }
    }
}

