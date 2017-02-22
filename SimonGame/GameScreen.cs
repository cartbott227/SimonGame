using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SimonGame
{
    public partial class GameScreen : UserControl
    {
        //Create a random number generator
        Random randGen = new Random();

        //Set the guess amount to 0
        int guess = 0;

        //Sound players for various sound effects
        SoundPlayer redplayer = new SoundPlayer(Properties.Resources.red);
        SoundPlayer greenplayer = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellowplayer = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueplayer = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer errorplayer = new SoundPlayer(Properties.Resources.mistake);

        public GameScreen()
        {
            InitializeComponent();

            //Clear the pattern list
            Form1.pattern.Clear();
        }
        #region ComputerTurn
        private void ComputerTurn()
        {
            //Set the colour value to a random number between 0 and 4
            int colorvalue = randGen.Next(0, 4);

            //Add the number to the pattern list
            Form1.pattern.Add(colorvalue);

            //Run though the list and activate each button if the statement is true, then hand the control over to the
            //user once the end of the list is reached and add to the list.
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.Green;
                    greenplayer.Play();
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.Lime;
                    Thread.Sleep(500);
                    Refresh();
                }

                if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Maroon;
                    redplayer.Play();
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.Red;
                    Thread.Sleep(500);
                    Refresh();
                }

                if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.YellowGreen;
                    yellowplayer.Play();
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Yellow;
                    Thread.Sleep(500);
                    Refresh();
                }

                if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DarkBlue;
                    blueplayer.Play();
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.Blue;
                    Thread.Sleep(500);
                    Refresh();
                }
            }

            //Reset the guess amoun to 0
            guess = 0;
        }
        #endregion

        private void greenButton_Click(object sender, EventArgs e)
        {
            //If the pattern is equal to the button pressed, highlight the button, play a sound and add to the guess
            //amount
            if (Form1.pattern[guess] == 0)
            {               
                greenButton.BackColor = Color.Green;
                greenplayer.Play();
                Refresh();
                Thread.Sleep(500);
                greenButton.BackColor = Color.Lime;
                Thread.Sleep(500);
                Refresh();
                guess++;

                //If the guess amount is equal to the amount of guesses in the list, hand the control over to the 
                //Computer Turn
                if (guess == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            //If neither statement is true, play the GameOver method
            else
            {
                GameOver();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                redButton.BackColor = Color.Maroon;
                redplayer.Play();
                Refresh();
                Thread.Sleep(500);
                redButton.BackColor = Color.Red;
                Thread.Sleep(500);
                Refresh();
                guess++;

                if (guess == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                yellowButton.BackColor = Color.YellowGreen;
                yellowplayer.Play();
                Refresh();
                Thread.Sleep(500);
                yellowButton.BackColor = Color.Yellow;
                Thread.Sleep(500);
                Refresh();
                guess++;

                if (guess == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }

        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                blueButton.BackColor = Color.DarkBlue;
                blueplayer.Play();
                Refresh();
                Thread.Sleep(500);
                blueButton.BackColor = Color.Blue;
                Thread.Sleep(500);
                Refresh();
                guess++;

                if (guess == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(500);
            ComputerTurn();
        }

        private void GameOver()
        {
            //Play an error sound
            errorplayer.Play();

            //Declare that Form f is the Form that this control is on
            Form f = this.FindForm();

            //Remove User Control from the Form.
            f.Controls.Remove(this);

            //Create an instance of Game Over Screen
            GameOverScreen go = new GameOverScreen();

            //Add User Control to the Form
            f.Controls.Add(go);
        }

        
    }
}
