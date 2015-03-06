using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Fatorial : Form
    {
        public double result;

        public Fatorial()
        {
            InitializeComponent();
        }

        private void ClickR(object sender, EventArgs e)
        {
            Button recur = sender as Button;
            double Ab = Double.Parse(txt.Text);
            label.Text = Convert.ToString(Recursiva(Ab));
        }

        private void ClickI(object sender, EventArgs e)
        {
            Button iter = sender as Button;
            double Bc = Double.Parse(txt.Text);
            label.Text = Convert.ToString(Iterativa(Bc));
        }

        public double Iterativa(double num)
        {
            double x = num;
            for (double i = num-1; i > 0; i--)
                {
                    x *=  i;
                }
            return x;
        }

        public double Recursiva(double num)
        {
            if (num == 0) return 1;
            result = num * Recursiva(num - 1);
            return result;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}