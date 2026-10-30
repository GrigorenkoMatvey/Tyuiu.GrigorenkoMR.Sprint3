using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task5.V9.Lib;

public class DataService : ISprint3Task5V9
{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        double s0 = 0;
        double s1 = 0;

        for (int i = startValue1; i <= stopValue1; i++)
        {
            for (int k = startValue2; k <= stopValue2; k++)
            {
                s0 = (1.0 / Math.Sin(k)) + x;

                s1 += s0;
            }
        }
        return Math.Round(s1, 3);
    }
}