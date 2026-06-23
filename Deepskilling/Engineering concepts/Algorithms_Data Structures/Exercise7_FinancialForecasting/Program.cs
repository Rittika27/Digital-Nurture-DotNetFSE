double presentValue = 1000.0;
double growthRate = 0.08;
int years = 5;

double futureValue = Forecaster.CalculateFutureValue(presentValue, growthRate, years);
Console.WriteLine("Present Value  : " + presentValue);
Console.WriteLine("Growth Rate    : " + (growthRate * 100) + "%");
Console.WriteLine("Years          : " + years);
Console.WriteLine("Future Value   : " + Math.Round(futureValue, 2));
