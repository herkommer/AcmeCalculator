using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeCalculator
{
    public partial class Form1 : Form
    {
        private Calculate calc; 

        public Form1()
        {
            InitializeComponent();

            calc = new Calculate();

            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "/";
            button4.Text = "*";

            button1.Click += new EventHandler(DoCalculation);
            button2.Click += new EventHandler(DoCalculation);
        }

        private void DoCalculation(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            decimal n1 = decimal.Parse(textBox1.Text);
            decimal n2 = decimal.Parse(textBox2.Text);
            decimal result = 0;

            switch (b.Text)
            {
                case "+":
                    result = calc.Add(n1, n2);
                    break;

                case "-":

                    break;

                default:
                    break;
            }


            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", n1, n2, result, b.Text));
        }
    }
}
