using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text),
                       y = double.Parse(textBox2.Text),
                       z = double.Parse(textBox3.Text),
                       result = 0;
                for (int i = 1; i <= x + y; i++)
                {
                    result += Math.Sqrt((2 + Math.Sqrt(-1) - z) / (Math.Pow(x, 3) - Math.Sqrt(-1) + Math.Pow(Math.Sqrt(-1), 2)));
                }
                    result_lable.Text = String.Format("{0:f5}", result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Перевірте параметри", "Помилка");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ділення на нуль", "Помилка");
            }
        }
    }
}