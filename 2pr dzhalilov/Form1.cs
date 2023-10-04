using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2pr_dzhalilov
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // to generate random numbers.
        Random randomizer = new Random();
        // These integer variables store the numbers 
        // for the addition problem. 
        int addent1;
        int addent2;
        // These integer variables store the numbers
        // for the subtraction problem.
        int minuend;
        int subtrahend;
        // These integer variables store the numbers 
        // for the multiplication problem.
        int multiplicand;
        int multiplier;
        // These integer 
        public void StartTheQuiz()
        {
            //Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addent1' and 'addent2'.
            addent1 = randomizer.Next(51);
            addent2 = randomizer.Next(51);
            // Convert the two randomaly generated numbers 
            // into strings so that they can be displayed 
            // in the label controls.
            plusLeftLabel.Text = addent1.ToString();
            plusRightLabel.Text = addent2.ToString();
            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
