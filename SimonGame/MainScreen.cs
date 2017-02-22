using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGame
{

    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void newgameButton_Click(object sender, EventArgs e)
        {
            //Declare that Form f is the form that this control is on
            Form f = this.FindForm();

            //Remove User Control from the Form
            f.Controls.Remove(this);

            //Create an instance of Game Screen
            GameScreen gs = new GameScreen(); 

            //Add User Control to the Form
            f.Controls.Add(gs);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
