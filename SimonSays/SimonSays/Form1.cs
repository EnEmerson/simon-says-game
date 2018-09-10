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
        bool compTurn, playerTurn;

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
            timer.Interval = 1000;

            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("blue");

            compTurn = true;
            playerTurn = false;

            compPick.Clear();
            playerPick.Clear();

            computerPick();
        }

        private void computerPick()
        {
            Random rand = new Random();
            int upper = colors.Count() + 1;
            int compChoice = rand.Next(1,upper);
            compPick.Add(colors[compChoice-1].ToString());

            Console.WriteLine("Computer picked: "+compChoice.ToString());
        }
        private void timerTick(object sender, EventArgs e)
        {
            timer.Stop();
            resetColors();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            timer.Tick += timerTick;
            timer.Start();

            disableButtons();

            if(greenButton.Enabled == false)
            {
                greenButton.BackColor = Color.White;
            }

            playerPick.Add("green");

        }

        private void redButton_Click(object sender, EventArgs e)
        {
            timer.Tick += timerTick;
            timer.Start();

            disableButtons();

            if (redButton.Enabled == false)
            {
                redButton.BackColor = Color.White;
            }

            playerPick.Add("red");
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            timer.Tick += timerTick;
            timer.Start();

            disableButtons();

            if (yellowButton.Enabled == false)
            {
                yellowButton.BackColor = Color.White;
            }

            playerPick.Add("yellow");
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            timer.Tick += timerTick;
            timer.Start();

            disableButtons();

            if (blueButton.Enabled == false)
            {
                blueButton.BackColor = Color.White;
            }

            playerPick.Add("blue");
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
