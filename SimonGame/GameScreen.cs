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

        public GameScreen()
        {
            InitializeComponent();
        }
        #region ComputerTurn
        private void ComputerTurn()
        {
            Refresh();
            int colorvalue = randGen.Next(0, 4);
            Form1.pattern.Add(colorvalue);

            for (int i = 0; guess < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    greenButton.BackColor = Color.Green;
                    greenplayer.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    greenButton.BackColor = Color.Lime;
                    Refresh();                   
               }

                if (Form1.pattern[i] == 1)
                {
                    redButton.BackColor = Color.Maroon;
                    redplayer.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    redButton.BackColor = Color.Red;
                    Refresh();               
                }

                if (Form1.pattern[i] == 2)
                {
                    yellowButton.BackColor = Color.YellowGreen;
                    yellowplayer.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();             
                }

                if (Form1.pattern[i] == 3)
                {
                    blueButton.BackColor = Color.DarkBlue;
                    blueplayer.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                }
            }
            
        }
        #endregion

        private void greenButton_Click(object sender, EventArgs e)
        {
            if(Form1.pattern[i] == 0)
            greenButton.BackColor = Color.Green;
            greenplayer.Play();
            Refresh();
            Thread.Sleep(1000);
            greenButton.BackColor = Color.Lime;
            Refresh();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redButton.BackColor = Color.Maroon;
            redplayer.Play();
            Refresh();
            Thread.Sleep(1000);
            redButton.BackColor = Color.Red;
            Refresh();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            yellowButton.BackColor = Color.YellowGreen;
            yellowplayer.Play();
            Refresh();
            Thread.Sleep(1000);
            yellowButton.BackColor = Color.Yellow;
            Refresh();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            blueButton.BackColor = Color.DarkBlue;
            blueplayer.Play();
            Refresh();
            Thread.Sleep(1000);
            blueButton.BackColor = Color.Blue;
            Refresh();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(500);

            ComputerTurn();
        }
    
    }
}
