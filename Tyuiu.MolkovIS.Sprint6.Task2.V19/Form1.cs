using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Tyuiu.MolkovIS.Sprint6.Task2.V19.Lib;

namespace Tyuiu.MolkovIS.Sprint6.Task2.V19
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxInput1.Text, out int startStep) || !int.TryParse(textBoxInput2.Text, out int stopStep))
                {
                    MessageBox.Show("Значения старта и конца шага должны быть целыми числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (startStep > stopStep)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                DisplayResults(valueArray, startStep);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил Мольков И. С.", "Справка", MessageBoxButtons.OK);
        }

        private void DisplayResults(double[] valueArray, int startStep)
        {
            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();

            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].HeaderText = "X";
            dataGridViewResult.Columns[1].HeaderText = "F(x)";

            dataGridViewResult.Columns[0].Width = 50;
            dataGridViewResult.Columns[1].Width = 70;

            for (int i = 0; i < valueArray.Length; i++)
            {
                int currentX = startStep + i;
                dataGridViewResult.Rows.Add(currentX, valueArray[i]);
            }
            chartResult.Series.Clear();
            chartResult.ChartAreas[0].AxisX.Title = "Ось X";
            chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

            Series series = new Series("F(x)");
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;

            for (int i = 0; i < valueArray.Length; i++)
            {
                int currentX = startStep + i;
                series.Points.AddXY(currentX, valueArray[i]);
            }

            chartResult.Series.Add(series);
        }
    
    }
}
