using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizGame
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addNum1;
        int addNum2;

        int subtractNum1;
        int subtractNum2;

        int multiplyNum1;
        int multiplyNum2;

        int divideNum1;
        int divideNum2;

        int clock;

        private bool CheckAnswer()
        {
            if ((addNum1 + addNum2 == sum.Value) 
                && (subtractNum1 - subtractNum2 == diffrence.Value) 
                && (multiplyNum1 * multiplyNum2 == product.Value) 
                && (divideNum1 / divideNum2 == quotent.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void StartQuiz()
        {
            addNum1 = randomizer.Next(20);
            addNum2 = randomizer.Next(20);

            addLeft.Text = addNum1.ToString();
            addRight.Text = addNum2.ToString();

            multiplyNum1 = randomizer.Next(2, 11);
            multiplyNum2 = randomizer.Next(1,11);

            multiplyLeft.Text = multiplyNum1.ToString();
            multiplyRight.Text = multiplyNum2.ToString();

            divideNum2 = randomizer.Next(2, 11);
            int temporaryQuotent = randomizer.Next(2, 11);
            divideNum1 = divideNum2 * temporaryQuotent;
          

            divideLeft.Text = divideNum1.ToString();
            divideRight.Text = divideNum2.ToString();

            subtractNum1 = randomizer.Next(1,51);
            subtractNum2 = randomizer.Next(1, subtractNum1);

            subtractLeft.Text = subtractNum1.ToString();
            subtractRight.Text = subtractNum2.ToString();

            clock = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            sum.Value = 0;
            diffrence.Value = 0;
            product.Value = 0;
            quotent.Value = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                clock = clock - 1;
                timeLabel.Text = clock + " seconds";
            }
            else
            {
                if(CheckAnswer())
                {
                    timer1.Stop();
                    MessageBox.Show("Nice you got everything correct!");
                    startButton.Enabled = true;
                }
                else
                {
                    timer1.Stop();
                    timeLabel.Text = "Time's up!";
                    MessageBox.Show("you didn't finish in time.", "Sorry!");
                    CheckAnswer();
                    sum.Value = addNum1 + addNum2;
                    diffrence.Value = subtractNum1 - subtractNum2;
                    product.Value = multiplyNum1 * multiplyNum2;
                    quotent.Value = divideNum1 / divideNum2;
                    startButton.Enabled = true;
                }
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer for the numericupdown control.
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
