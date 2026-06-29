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
            double baseValue, heightValue;

            // Blank input check
            if (string.IsNullOrWhiteSpace(txtBase.Text) || string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Please enter values for both Base and Height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for numeric input
            if (!double.TryParse(txtBase.Text, out baseValue) || !double.TryParse(txtHeight.Text, out heightValue))
            {
                MessageBox.Show("Please enter valid numeric values for Base and Height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for positive values
            if (baseValue <= 0 || heightValue <= 0)
            {
                MessageBox.Show("Values for Base and Height must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate and show area
            double area = 0.5 * baseValue * heightValue;
            lblResult.Text = "Area: " + area.ToString("F2");

            // Add to history
            string record = "Base=" + baseValue + ", Height=" + heightValue + ", Area=" + area.ToString("F2");
            history.Add(record);
        }

        // Store history of calculations
        private List<string> history = new List<string>();


        private void clear_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtHeight.Clear();
            lblResult.Text = "";
            showHistorey.Items.Clear();

        }

        private void btnhistory_Click_1(object sender, EventArgs e)
        {
            showHistorey.Items.Clear();
            foreach (var item in history)
            {
                showHistorey.Items.Add(item);
            }

        }
    }
}