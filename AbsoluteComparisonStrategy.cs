namespace ThresholdCheckerApp
{
    //Implementing the absolute comparision that's checking if the absolute difference of values is greater than the threshold
    public class AbsoluteComparisonStrategy : IComparisonStrategy
    {
        private readonly double _threshold;

        public AbsoluteComparisonStrategy(double threshold)
        {
            if (threshold <= 0)
            {
                throw new ArgumentException("Threshold must be greater than zero.", nameof(threshold));
            }
            _threshold = threshold;
        }

        public bool Compare(double value1, double value2)
        {
            return Math.Abs(value2 - value1) > _threshold;
        }
    }
}
