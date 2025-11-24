using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MolkovIS.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            double underRoot = x * x + x;
            double root = Math.Sqrt(underRoot);
            return Math.Round(x/root,3);
        }
    }
}
