using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleAreaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double baseValue = Convert.ToDouble(txtBase.Text);
            double heightValue = Convert.ToDouble(txtHeight.Text);

            double area = 0.5 * baseValue * heightValue;
            lblResult.Text = "Area: " + area.ToString("F2");
        }

 
    }
}