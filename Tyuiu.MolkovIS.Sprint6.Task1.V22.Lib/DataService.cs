using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolkovIS.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = Math.Cos(x) + 1;

                if (denom == 0)
                {
                    mass[count] = 0;
                }
                else
                {
                    double value = 3 * x + 2 - (x / denom);
                    mass[count] += Math.Round(value, 2);
                }
                count++;
            }
            return mass;
        }
    }
}
