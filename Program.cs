namespace ThresholdCheckerApp
{
    public static class Program
    {
        //Executing the implemented classes using sample input values
        public static void Main()
        {
            try
            {
                var absoluteChecker = new ThresholdChecker(new AbsoluteComparisonStrategy(10));
                var firstCheckAbsolute = absoluteChecker.CheckThreshold(108, 100);
                Console.WriteLine($"First Check Absolute: {firstCheckAbsolute}");

                var secondCheckAbsolute = absoluteChecker.CheckThreshold(88, 100);
                Console.WriteLine($"Second Check Absolute: {secondCheckAbsolute}");

                var relativeChecker = new ThresholdChecker(new RelativeComparisonStrategy(20)); // 20% threshold
                var firstCheckRelative = relativeChecker.CheckThreshold(120, 100); // 20% increase
                Console.WriteLine($"First Check Relative: {firstCheckRelative}");

                var secondCheckRelative = relativeChecker.CheckThreshold(80, 100); // 20% decrease
                Console.WriteLine($"Second Check Relative: {secondCheckRelative}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Argument Exception: {ae.Message}");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine($"Divide By Zero Exception: {dbze.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }
}
