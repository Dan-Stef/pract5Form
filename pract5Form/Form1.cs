using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private double f(double x)
        {
            try
            {
                if (x <= -2) throw new Exception();
                else if (x >= 2) throw new Exception();
                else return Math.Log(4 - x * x);
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double h = Convert.ToDouble(textBox3.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        textBox4.AppendText("y(" + i + ")=" + f(i));
                        textBox4.AppendText(Environment.NewLine);
                    }
                    catch
                    {
                        textBox4.AppendText("y(" + i + ")=error");
                        textBox4.AppendText(Environment.NewLine);
                    }
            }
            catch(FormatException) { textBox4.AppendText("Неверный формат ввода данных"); }
        }
    }
}
