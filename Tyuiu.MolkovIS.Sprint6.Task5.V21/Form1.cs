using System.IO;
using Tyuiu.MolkovIS.Sprint6.Task5.V21.Lib;

namespace Tyuiu.MolkovIS.Sprint6.Task5.V21
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutFileTask5V21.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                double[] data = ds.LoadFromDataFile(path);

                
                chart_MIS.Series[0].Points.Clear();

                dataGridView_MIS.Rows.Clear();
                dataGridView_MIS.Columns.Clear();
                dataGridView_MIS.ReadOnly = true;
                chart_MIS.ChartAreas[0].AxisX.Title = "Ось X";
                chart_MIS.ChartAreas[0].AxisY.Title = "Ось Y";

                dataGridView_MIS.Columns.Add("Index", "Индекс");
                dataGridView_MIS.Columns.Add("Value", "Значение");

                dataGridView_MIS.Columns[0].Width = 50;
                dataGridView_MIS.Columns[1].Width = 50;


                for (int i = 0; i < ds.index; i++)
                {
                    double val = Math.Round(data[i], 3);
                    dataGridView_MIS.Rows.Add(i.ToString(), val.ToString());
                    chart_MIS.Series[0].Points.AddXY(i, val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы Мольков И. С.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
