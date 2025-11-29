using System.Windows.Forms.VisualStyles;
using Tyuiu.MolkovIS.Sprint6.Task1.V22.Lib;


namespace Tyuiu.MolkovIS.Sprint6.Task1.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCompute_MIS_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxInput1_MIS.Text, out int startStep) || !int.TryParse(textBoxInput2_MIS.Text, out int stopStep))
                {
                    MessageBox.Show("Значения старта и конца шага должны быть целыми числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (startStep > stopStep)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataService dataService = new DataService();
                double[] values = dataService.GetMassFunction(startStep, stopStep);

                DisplayResult(values, startStep);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Мольков  И. С.","Справка", MessageBoxButtons.OK);
        }

        private void DisplayResult(double[] values, int startStep)
        {
            textBoxOutput_MIS.Text = "";
            textBoxOutput_MIS.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxOutput_MIS.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
            textBoxOutput_MIS.AppendText("+----------+----------+" + Environment.NewLine);
            
            for (int i = 0; i < values.Length; i++)
            {
                int currentX = startStep + i;
                string str = String.Format("| {0,5:d}    | {1,8:f2} |", currentX, values[i]);
                textBoxOutput_MIS.AppendText(str + Environment.NewLine);
            }
            textBoxOutput_MIS.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}
