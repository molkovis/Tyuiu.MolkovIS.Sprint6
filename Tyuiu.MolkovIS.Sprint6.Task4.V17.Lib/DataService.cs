using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolkovIS.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = x + 1.7;

                if (denom == 0)
                {
                    mass[count] = 0;
                }
                else
                {
                    double value = (Math.Sin(x)) / (denom) - Math.Cos(x) * 4 * x - 6;
                    mass[count] = Math.Round(value, 2);
                }
                count++;
            }
            return mass;
        }
    }
}
