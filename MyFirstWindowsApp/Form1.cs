using System;
using System.Windows.Forms;
using static System.Math;

namespace MyFirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;

            if (!double.TryParse(textBox1.Text, out x))
            {
                label2.Text = "Ошибка ввода X!";
                return;
            }

            if (!double.TryParse(textBox2.Text, out y))
            {
                label2.Text = "Ошибка ввода Y!";
                return;
            }

            double result = (3 * x + 6 * Cos(y)) / 2;

            label2.Text = $"Результат: {result:F4}";
        }
    }
}
