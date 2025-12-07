using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MolkovIS.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);

            char[] separators = new char[] { ' ', '\n'};


            string[] words = text.Split(" ");

            StringBuilder res = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Contains("n"))
                {
                    res.Append(word);
                }
            }
            return res.ToString();
        }
    }
}
