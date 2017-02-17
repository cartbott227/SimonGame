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
        Random randGen = new Random();

        int guess = 0;

        SoundPlayer redplayer = new SoundPlayer(Properties.Resources.red);
        SoundPlayer greenplayer = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellowplayer = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueplayer = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer errorplayer = new SoundPlayer(Properties.Resources.mistake);

        public GameScreen()
        {
            InitializeComponent();
            Form1.pattern.Clear();
        }
        #region ComputerTurn
        private void ComputerTurn()
        {
            //Refresh();
            int colorvalue = randGen.Next(0, 4);
            Form1.pattern.Add(colorvalue);

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

            guess = 0;
        }
        #endregion

        private void greenButton_Click(object sender, EventArgs e)
        {
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
            errorplayer.Play();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen go = new GameOverScreen();
            f.Controls.Add(go);
        }

        
    }
}
