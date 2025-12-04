using System.Diagnostics;
using Tyuiu.MolkovIS.Sprint6.Task4.V17.Lib;

namespace Tyuiu.MolkovIS.Sprint6.Task4.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                if (start > stop)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                int len = (stop - start) + 1;
                int[] xValues = new int[len];
                for (int i = 0; i < len; i++)
                {
                    xValues[i] = start + i;
                }

                
                double[] yValues = ds.GetMassFunction(start, stop);

                
                textBoxResult.Clear();
                textBoxResult.Text = "+----------+----------+" + Environment.NewLine;
                textBoxResult.Text += "|    X     |   F(X)   |" + Environment.NewLine;
                textBoxResult.Text += "+----------+----------+" + Environment.NewLine;
                for (int i = 0; i < len; i++)
                {
                    textBoxResult.Text += String.Format("| {0, 8:d} | {1, 8:f2} |{2}", xValues[i], yValues[i], Environment.NewLine);
                }
                textBoxResult.Text += "+----------+----------+" + Environment.NewLine;

                // --- Надежное построение графика (обновленный блок) ---
                chartOutput.Series.Clear();
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("F(x)")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline,
                    BorderWidth = 2
                };

                for (int i = 0; i < len; i++)
                {
                    series.Points.AddXY(xValues[i], yValues[i]);
                }

                chartOutput.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка вычислений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V17.txt");
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show("Файл успешно сохранен в: " + path + "\nОткрыть его в Блокноте?", "Сохранение завершено", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
