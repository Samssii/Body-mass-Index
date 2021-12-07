using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Isa_W12B
{
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            double height = Double.Parse(textBoxHeight.Text);
            double weight = Double.Parse(textBoxWeight.Text);
            listBoxInfo.Items.Add(BodyMassIndex(weight, height));
            listBoxInfo.HorizontalScrollbar = true;
        }

        private string BodyMassIndex(double weight, double height)
        {
            string result = "";
            double BMI = Math.Round(weight / Math.Pow(height / 100, 2), 1);
            if (BMI < 18.5)
            {
                result = "Your BMI = " + BMI + ", you are Underweight.";
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                result = "Your BMI = " + BMI + ", you are Normal.";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                result = "Your BMI = " + BMI + ", you are Overweight.";
            }
            else if (BMI >= 30)
            {
                result = "Your BMI = " + BMI + ", you are Obese.";
            }
            return result;
        }

        private void labelWeight_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDash_Click(object sender, EventArgs e)
        {

        }

        private void labelEqual_Click(object sender, EventArgs e)
        {

        }

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelHeight_Click(object sender, EventArgs e)
        {

        }
    }
}
