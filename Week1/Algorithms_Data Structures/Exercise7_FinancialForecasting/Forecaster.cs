public static class Forecaster
{
    // Recursive: future value = presentValue * (1 + rate)^years
    public static double FutureValue(double presentValue, double rate, int years)
    {
        if (years == 0) return presentValue;
        return FutureValue(presentValue * (1 + rate), rate, years - 1);
    }

    // Memoized version to avoid redundant calculations
    private static readonly Dictionary<int, double> _cache = new();

    public static double FutureValueMemo(double presentValue, double rate, int years)
    {
        if (years == 0) return presentValue;
        if (_cache.TryGetValue(years, out double cached)) return cached;
        _cache[years] = FutureValueMemo(presentValue, rate, years - 1) * (1 + rate);
        return _cache[years];
    }
}
