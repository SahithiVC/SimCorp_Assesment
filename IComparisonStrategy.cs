
namespace ThresholdCheckerApp
{
    //Interface that can be used in implemented comparisions. This would be common for any newly implemented comparisions.
    public interface IComparisonStrategy
	{
        bool Compare(double value1, double value2);
    }
}

