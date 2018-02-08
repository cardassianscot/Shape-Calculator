using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cone();
        }

        private void cone()
        {
            try
            {
                double r = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                double area = Math.PI * r * r + Math.PI * r * Math.Sqrt(h * h + r * r);
                double volume = 1.0 / 3.0 * Math.PI * r * r * h;
                label3.Text = "Area = " + area.ToString("N");
                label4.Text = "Volume = " + volume.ToString("N");
            }
            catch
            {
                label3.Text = "Area = ";
                label4.Text = "Volume = ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cone();
        }
    }
}
