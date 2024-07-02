using System;

namespace ThresholdCheckerApp
{
    //Implementing relative comparision that's checking if the relative difference(percentage) of values is greater than the threshold
    public class RelativeComparisonStrategy : IComparisonStrategy
    {
        private readonly double _thresholdPercentage;

        public RelativeComparisonStrategy(double thresholdPercentage)
        {
            if (thresholdPercentage <= 0 || thresholdPercentage >= 100)
            {
                throw new ArgumentOutOfRangeException(nameof(thresholdPercentage), "Threshold percentage must be between 0 and 100.");
            }
            _thresholdPercentage = thresholdPercentage / 100.0; // Convert percentage to fraction
        }

        public bool Compare(double value1, double value2)
        {
            if (value1 == 0)
            {
                throw new DivideByZeroException("Cannot calculate relative difference with zero as the base value.");
            }
            double relativeDifference = Math.Abs((value2 - value1) / value1);
            return relativeDifference > _thresholdPercentage;
        }
    }
}
