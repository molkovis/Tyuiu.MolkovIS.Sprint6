using System.Text;
using System.Windows.Forms;
using Tyuiu.MolkovIS.Sprint6.Task7.V21.Lib;

namespace Tyuiu.MolkovIS.Sprint6.Task7.V21
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        string OpenPath;
        int rows;
        int columns;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenPath = openFileDialog1.FileName;
                try
                {
                    string[] lines = File.ReadAllLines(OpenPath);
                    rows = lines.Length;
                    columns = lines[0].Split(";").Length;
                    dataGridViewIn.ColumnCount = columns;
                    dataGridViewIn.RowCount = rows;
                    dataGridViewOut.ColumnCount = columns;
                    dataGridViewOut.RowCount = rows;
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewIn.Columns[i].Width = 25;
                        dataGridViewOut.Columns[i].Width = 25;
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        string[] line_r = lines[r].Split(';');
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewIn.Rows[r].Cells[c].Value = line_r[c];
                        }
                    }

                    buttonDone.Enabled = true;


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = ds.GetMatrix(OpenPath);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut.Rows[r].Cells[c].Value = matrix[r, c];
                    }
                }
                buttonSaveFile.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog1.FileName;
                    StringBuilder sb = new StringBuilder();

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            sb.Append(dataGridViewOut.Rows[r].Cells[c].Value);
                            if (c < columns - 1)
                                sb.Append(";");
                        }
                        sb.AppendLine();
                    }
                    File.WriteAllText(path, sb.ToString());
                    MessageBox.Show("Файл успешно сохранен!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент Мольков И. С.", "Справка");
        }
    }
}
