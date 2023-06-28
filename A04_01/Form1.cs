using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double CalculateHypotenuse(double side1, double side2)
        {
            double hypotenuse;
            hypotenuse = Math.Sqrt((side1*side1) + (side2*side2));
            return hypotenuse;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double side1 = Convert.ToDouble(txt1Side.Text);
            double side2 = Convert.ToDouble(txt2Side.Text);

            double hypo = CalculateHypotenuse(side1, side2);

            txt3Side.Text = hypo.ToString();
        }

        private void txt1Side_Enter(object sender, EventArgs e)
        {
            txt1Side.SelectAll();
        }

        private void txt2Side_Enter(object sender, EventArgs e)
        {
            txt2Side.SelectAll();
        }
    }
}
