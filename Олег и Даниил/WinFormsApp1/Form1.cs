using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);
                double x = double.Parse(textBoxX.Text);

                double F;

                if (x < 1 && c != 0)
                {
                    F = a * Math.Pow(x, 2) + b / c;
                }
                else if (x > 1.5 && c == 0)
                {
                    F = (x - a) / Math.Pow((x - c), 2);
                }
                else
                {
                    F = Math.Pow(x, 2) / Math.Pow(c, 2);
                }
                labelResult.Text = $"F = {F}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных: " + ex.Message);
            }
        }
    }
}

