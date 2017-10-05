using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficult_Settings
{
    public partial class Form1 : Form
    {
        //global variables
        string heroName;
        string difficultySettings;

        public Form1()
        {
            InitializeComponent();
        }

        //easy
        private void easyButton_Click(object sender, EventArgs e)
        {
            heroName = nameTextBox.Text;
            difficultySettings = "easy";
            welcomeLabel.Text = "Welcome " + heroName + "! " + "Are you Serious? You selected difficulty " + difficultySettings + ".";

        }

        //medium
        private void mediumButton_Click(object sender, EventArgs e)
        {
            heroName = nameTextBox.Text;
            difficultySettings = "medium";
            welcomeLabel.Text = "Welcome " + heroName + "! " + "Okaaayyy... Now the difficulty is " + difficultySettings + ".";
        }

        //hard
        private void hardButton_Click(object sender, EventArgs e)
        {
            heroName = nameTextBox.Text;
            difficultySettings = "hard.";
            welcomeLabel.Text = "Welcome " + heroName + "! " + "Woah, you are in difficulty " + difficultySettings + " Good luck !";
        }
    }
}
