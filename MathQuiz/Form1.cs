using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addNum1;
        int addNum2;
        int subNum1;
        int subNum2;
        int multNum1;
        int multNum2;
        int divNum1;
        int divNum2;
        int clock;

        public void StartQuiz()
        {
            addNum1 = randomizer.Next(51);
            addNum2 = randomizer.Next(51);
            subNum1 = randomizer.Next(30,51);
            subNum2 = randomizer.Next(1,29);
            multNum1= randomizer.Next(12);
            multNum2= randomizer.Next(12);
            divNum1 = randomizer.Next(6,12);
            divNum2 = randomizer.Next(1,5);

            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();
            minusLeftLabel.Text = subNum1.ToString();
            minusRightLabel.Text = subNum2.ToString();
            leftMultiplyLabel.Text = multNum1.ToString();
            rightMultiplyLable.Text = multNum2.ToString();
            devideLeftLabel.Text = divNum1.ToString();
            devideRightLabel.Text = divNum2.ToString();
            sum.Value = 0;
            diffrence.Value = 0;
            product.Value = 0;
            quotent.Value = 0;

            clock = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckAnswer()
        {
            if ((((addNum1 + addNum2 == sum.Value)
                && (subNum1 - subNum2 == diffrence.Value))
                && (multNum1 * multNum2 == product.Value))
                && (divNum1 / divNum2 == quotent.Value))

                return true;
            else
                return false;
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
            if(clock > 0)
            {
                //display the time left
                //by updating the time label
                clock = clock - 1;
                timeLabel.Text = clock + "Seconds";
            }
            else
            {
                //If the user ran out of time, stop the timer, show message box, show answers
                timer1.Stop();
                timeLabel.Text = "Times Up!";
                if (!CheckAnswer())
                {
                    
                    MessageBox.Show("YOUR MATH IS BAD AND YOU SHOULD FEEL BAD!");
                    sum.Value = addNum1 + addNum2;
                    diffrence.Value = subNum1 - subNum2;
                    product.Value = multNum1 * multNum2;
                    quotent.Value = divNum1 / divNum2;
                }
                else
                {
                    MessageBox.Show("At least you can do basic math.");
                }
                
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //select whole answer in the numeric updown control
            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox !=null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
