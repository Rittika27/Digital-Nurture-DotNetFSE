double principal = 1000.0;
double annualRate = 0.08; // 8%
int years = 5;

double result = Forecaster.FutureValue(principal, annualRate, years);
Console.WriteLine($"Future Value (recursive)  : {result:F2}");

double memoResult = Forecaster.FutureValueMemo(principal, annualRate, years);
Console.WriteLine($"Future Value (memoized)   : {memoResult:F2}");

/*
 * Time Complexity:
 *   Plain recursion : O(n) — one call per year, no repeated work here
 *   Memoized        : O(n) first call, O(1) for repeated queries with same years
 * Memoization avoids recomputation when forecasting multiple scenarios.
 */
