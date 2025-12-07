using Tyuiu.MolkovIS.Sprint6.Task6.V18.Lib;

namespace Tyuiu.MolkovIS.Sprint6.Task6.V18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonOpenFile.Text = "\uE8B7";

            buttonDone.Text = "\uE768";

            buttonHelp.Text = "\uE897";
        }
        DataService ds = new DataService();
        string path;
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = openFileDialog.FileName;
                    textBoxInput.Text = File.ReadAllText(path);
                    buttonDone.Enabled = true;
                    textBoxOutput.Clear();
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
                string output = ds.CollectTextFromFile(path);
                textBoxOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент Мольков И. С.", "Справка");
        }
    }
}
