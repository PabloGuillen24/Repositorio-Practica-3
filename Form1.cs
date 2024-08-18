using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica03
{
    public partial class Form1 : Form
    {
        double celsius;
        double fahrenheit;
        double conversionC;
        double conversionF;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fahrenheit = Convert.ToDouble(gradosF.Text);
            conversionC = (fahrenheit - 32) * 5/9;
            gradosC.Text = conversionC.ToString();
            
        }

        private void cafahren_Click(object sender, EventArgs e)
        {
            celsius = Convert.ToDouble(gradosC.Text);

            conversionF = (celsius * 1.8) + 32;
            gradosF.Text = conversionF.ToString();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            gradosC.Clear();
            gradosF.Clear();
        }
    }
}
