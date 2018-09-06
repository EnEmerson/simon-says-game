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
        List<string> compPick;
        List<string> playerPick;

        public Form1()
        {
            InitializeComponent();
            greenButton.BackColor = Color.Green;
            redButton.BackColor = Color.Red;
            yellowButton.BackColor = Color.Yellow;
            blueButton.BackColor = Color.Blue;
        }
    }
}
