using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task2.V11.Lib;

public class DataService : ISprint3Task2V11
{
    public double GetSumSeries(double x, int startValue, int stopValue)
    {
        double s = 0.0;
        int i = startValue;

        do
        {
            double chislitel = 1.0;
            double znamenatel = 3 + Math.Pow(x, i);
            double drob = chislitel / znamenatel;

            s += Math.Pow(drob, i);
            i++;
        } while (i <= stopValue);

        return Math.Round(s, 3);
    }
}
