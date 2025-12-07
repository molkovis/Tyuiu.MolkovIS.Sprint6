using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolkovIS.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(";").Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                string[] line = lines[r].Split(";");
                for (int c = 0; c < colCount; c++)
                {
                    matrix[r, c] = int.Parse(line[c]);
                }
            }
            int target = 7;
            for (int r = 0; r < rowCount; r++)
            {
                if (target < colCount)
                {
                    if (matrix[r, target] != 5)
                    {
                        matrix[r, target] = -1;
                    }
                }
            }
            return matrix;
        }
    }
}
