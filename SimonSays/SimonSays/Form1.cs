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
        List<string> temp = new List<string>();
        Timer timer = new Timer();
        bool compTurn;
        int winNum, accuracy;
        string cheatSheet = "";

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
            temp.Clear();

            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("blue");

            compTurn = false;
            accuracy = 0;
            winNum = 20;
            
            Random rand = new Random();
            for (int i = 0; i < winNum; i++)
            {
                int upper = colors.Count() + 1;
                int compChoice = rand.Next(1, upper);
                compPick.Add(colors[compChoice - 1].ToString());
                cheatSheet += compPick[i];
            }
        }

        private void checkAccuracy()
        {
            accuracy += 1;
            for(int i = 0; i < accuracy; i++)
            {
                temp.Add(compPick[i]);
            }
            for(int j = 0; j < accuracy; j++)
            {
                if(playerPick[j].Equals(temp[j]))
                {
                    Console.WriteLine("item at " + j + " matches");
                    Console.WriteLine(cheatSheet);
                }
            }
            temp.Clear();
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
                timer.Interval = 300;
            }
            timer.Tick += timerTick;
            timer.Start();
            disableButtons();
        }
        private void timerTick(object sender, EventArgs e)
        {
            timer.Stop();
            resetButtons();
        }


        private void disableButtons()
        {
            greenButton.Enabled = false;
            redButton.Enabled = false;
            yellowButton.Enabled = false;
            blueButton.Enabled = false;
        }

        private void resetButtons()
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
