using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Program create by Carter Bott
//on Febuary 16th, 2017
//Description: A basic memorization game based on the original Simon game.
namespace SimonGame
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //Create an instance of the main screen
            MainScreen ms = new MainScreen();

            //Add User Control to the Form
            this.Controls.Add(ms);
        }
    }
}
