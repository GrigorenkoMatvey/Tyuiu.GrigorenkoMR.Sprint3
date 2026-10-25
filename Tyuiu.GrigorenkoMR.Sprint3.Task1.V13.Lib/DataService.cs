using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task1.V13.Lib;

public class DataService : ISprint3Task1V13
{
    public double GetMultiplySeries(double n, int startValue, int stopValue)
    {
        double p = 1.0;
        int k = startValue;

        while (k <= stopValue)
        {
            p *= Math.Pow(1.0 / Math.Pow(n, k), -1);
            k++;
        }

        return Math.Round(p, 3);
    }
}