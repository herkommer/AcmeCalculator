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
        public Form1()
        {
            InitializeComponent();

            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "/";
            button4.Text = "*";

            button1.Click += new EventHandler(DoCalculation);
        }

        private void DoCalculation(object sender, EventArgs e)
        {
            //Läs av siffrorna
            //Anropa add metoden
            //Visa resultat

            decimal n1 = decimal.Parse(textBox1.Text);
            decimal n2 = decimal.Parse(textBox2.Text);

            decimal result;
            result = new Calculate().Add(n1, n2);

            listBox1.Items.Add(string.Format("{0} + {1} = {2}", n1,n2,result));
        }
    }
}
