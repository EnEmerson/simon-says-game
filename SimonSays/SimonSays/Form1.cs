using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        List<string> compPick = new List<string>();
        List<string> playerPick = new List<string>();
        List<string> colors = new List<string>();
        Timer timer = new Timer();
        bool compTurn;

        public Form1()
        {
            InitializeComponent();

            greenButton.BackColor = Color.Green;
            redButton.BackColor = Color.Red;
            yellowButton.BackColor = Color.Yellow;
            blueButton.BackColor = Color.Blue;

            greenButton.Text = "";
            redButton.Text = "";
            yellowButton.Text = "";
            blueButton.Text = "";

            colors.Clear();
            compPick.Clear();
            playerPick.Clear();

            timer.Interval = 1000;

            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("blue");

            compTurn = true;

            computerPick();
        }

        private void checkAccuracy()
        {
            //this is where i will check if the arrays match or not
        }

        private void computerPick()
        {
            Random rand = new Random();
            do
            {
                int upper = colors.Count() + 1;
                int compChoice = rand.Next(1, upper);
                compPick.Add(colors[compChoice - 1].ToString());

                Console.WriteLine("Computer picked: " + compChoice.ToString());

                switch (compChoice)
                {
                    case 1:
                        greenButton_Click(new object(), new EventArgs());
                        break;
                    case 2:
                        redButton_Click(new object(), new EventArgs());
                        break;
                    case 3:
                        yellowButton_Click(new object(), new EventArgs());
                        break;
                    case 4:
                        blueButton_Click(new object(), new EventArgs());
                        break;
                    default:
                        MessageBox.Show("something went wrong.");
                        return;
                }

                if(compPick.Count() > playerPick.Count())
                {
                    compTurn = false;
                }
            }
            while (compTurn);
        }
        private void timerTick(object sender, EventArgs e)
        {
            timer.Stop();
            resetColors();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            startTimer();

            if (greenButton.Enabled == false)
            {
                greenButton.BackColor = Color.White;
            }
            if(!compTurn)
            {
                playerPick.Add("green");
                checkAccuracy();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            startTimer();

            if (redButton.Enabled == false)
            {
                redButton.BackColor = Color.White;
            }
            if (!compTurn)
            {
                playerPick.Add("red");
                checkAccuracy();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            startTimer();

            if (yellowButton.Enabled == false)
            {
                yellowButton.BackColor = Color.White;
            }
            if (!compTurn)
            {
                playerPick.Add("yellow");
                checkAccuracy();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            startTimer();

            if (blueButton.Enabled == false)
            {
                blueButton.BackColor = Color.White;
            }
            if (!compTurn)
            {
                playerPick.Add("blue");
                checkAccuracy();
            }
        }

        private void startTimer()
        {
            if(compTurn)
            {
                timer.Interval = 1000;
            }
            if(!compTurn)
            {
                timer.Interval = 100;
            }
            timer.Tick += timerTick;
            timer.Start();
            disableButtons();
        }

        private void disableButtons()
        {
            greenButton.Enabled = false;
            redButton.Enabled = false;
            yellowButton.Enabled = false;
            blueButton.Enabled = false;
        }

        private void resetColors()
        {
            greenButton.BackColor = Color.Green;
            redButton.BackColor = Color.Red;
            yellowButton.BackColor = Color.Yellow;
            blueButton.BackColor = Color.Blue;

            greenButton.Enabled = true;
            redButton.Enabled = true;
            yellowButton.Enabled = true;
            blueButton.Enabled = true;
        }
    }
}
