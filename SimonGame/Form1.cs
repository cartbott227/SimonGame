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
            MainScreen ms = new MainScreen();

            this.Controls.Add(ms);
        }
    }
}
