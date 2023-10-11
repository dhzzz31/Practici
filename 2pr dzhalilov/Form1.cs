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
        int divident;
        int divisor;
        int timeleft; 


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
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            divident = divisor * temporaryQuotient;
            dividedLeftLabel.Text = divident.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


        }
        private bool CheckTheAnswer()
        {
            if ((addent1 + addent2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (divident / divisor == quotient.Value))
                return true;
            else
                return false;


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

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right! Congratulations!");

                startButton.Enabled = true;

            }
            else if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timeLabel.Text = timeleft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addent1 + addent2;
                difference.Value = minuend - subtrahend;
                product.Value = divident / divisor;
                startButton.Enabled = true;

            }
            timeleft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
            timeLabel.BackColor = Color.Red;
        }
    }
}
