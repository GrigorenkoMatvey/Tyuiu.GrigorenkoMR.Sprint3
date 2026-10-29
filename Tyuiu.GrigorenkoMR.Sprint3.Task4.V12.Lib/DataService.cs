using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task4.V12.Lib;

public class DataService : ISprint3Task4V12
{
    public double Calculate(int startValue, int stopValue)
    {
        int x;
        double sp = 1.0; 

        for (x = startValue; x <= stopValue; x++)
        {
            if (x == 0)
            {
                break; 
            }
            double y = x / (x + Math.Sin(x)) + 2.5;
            sp = sp * y;
        }
        return Math.Round(sp, 3);
    }
}
