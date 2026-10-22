using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double a, int startK, int stopK)
        {
            double p = 1.0;

            for (int k = startK; k <= stopK; k++)
            {
                p *= (Math.Pow(a, k) + 1) * Math.Cos(4);
            }

            return Math.Round(p, 3);
        }
    }
}