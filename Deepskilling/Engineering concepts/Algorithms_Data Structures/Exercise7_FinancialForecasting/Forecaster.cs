public class Forecaster
{
    public static double CalculateFutureValue(double presentValue, double growthRate, int years)
    {
        if (years == 0)
            return presentValue;

        return CalculateFutureValue(presentValue * (1 + growthRate), growthRate, years - 1);
    }
}
