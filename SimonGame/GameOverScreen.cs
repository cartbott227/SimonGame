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
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();

            //Display the user's pattern length
            outputLabel.Text = "Your pattern length was: " + Form1.pattern.Count();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            //Declare that Form f is the form that this control is on
            Form f = this.FindForm();

            //Remove User Control from the Form
            f.Controls.Remove(this);

            //Create an instance of Main Screen
            MainScreen ms = new MainScreen();

            //Add User Control to the Form
            f.Controls.Add(ms);
        }
    }
}
