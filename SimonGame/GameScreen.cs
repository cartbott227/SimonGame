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

        SoundPlayer redplayer = new SoundPlayer(Properties.Resources.red);
        SoundPlayer greenplayer = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellowplayer = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueplayer = new SoundPlayer(Properties.Resources.blue);

        public GameScreen()
        {
            InitializeComponent();
            
            
        }

        private void ComputerTurn()
        {
            //Refresh();
            //int colorvalue = randGen.Next(0, 4);
            int colorvalue = 0;

            if (colorvalue == 0)
            {
                greenButton.BackColor = Color.Green;
                greenplayer.Play();
                Refresh();
                Thread.Sleep(1000);
                greenButton.BackColor = Color.Lime;
                Refresh();
            }

            if (colorvalue == 1)
            {
                redButton.BackColor = Color.Maroon;
                redplayer.Play();
                Refresh();
                Thread.Sleep(1000);
                redButton.BackColor = Color.Red;
                Refresh();
            }

            if (colorvalue == 2)
            {
                yellowButton.BackColor = Color.YellowGreen;
                yellowplayer.Play();
                Refresh();
                Thread.Sleep(1000);                
                yellowButton.BackColor = Color.Yellow;
                Refresh();
            }

            if (colorvalue == 3)
            {
                blueButton.BackColor = Color.DarkBlue;
                blueplayer.Play();
                Refresh();
                Thread.Sleep(1000);
                blueButton.BackColor = Color.Blue;
                Refresh();

            }

        }
        private void greenButton_Click(object sender, EventArgs e)
        {

        }

        private void redButton_Click(object sender, EventArgs e)
        {

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

        }

        private void blueButton_Click(object sender, EventArgs e)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(500);
            
            ComputerTurn();
        }
    }
}
