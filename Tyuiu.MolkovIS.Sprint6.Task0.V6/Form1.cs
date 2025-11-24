using Tyuiu.MolkovIS.Sprint6.Task0.V6.Lib;

namespace Tyuiu.MolkovIS.Sprint6.Task0.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_MolkovIS_Click(object sender, EventArgs e)
        {
            try
            {


                DataService ds = new DataService();
                if (!int.TryParse(textBoxA_MolkovIS.Text, out int x))
                {
                    MessageBox.Show("ВВедите корректное целое число");
                    return;
                }

                textBoxResult_MIS.Text = Math.Round(ds.Calculate(x), 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void textBoxA_MolkovIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '-' && textBoxA_MolkovIS.Text.Length == 0)
            {
                return;
            }
            e.Handled = true;
        }
    }
}
