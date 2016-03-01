using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simonSaysProject
{
    public partial class gameOverScreen : UserControl
    {
        public gameOverScreen()
        {
            InitializeComponent();

            //Label Locations
            titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, this.Height / 2 - 100);
            scoreLabel2.Location = new Point(this.Width / 2 - scoreLabel2.Width / 2, this.Height / 2 - 50);

            //Button Locations
            replayButton.Location = new Point(this.Width / 2 - replayButton.Width / 2, this.Height / 2 + 50);
            closeButton.Location = new Point(this.Width / 2 - closeButton.Width / 2, this.Height / 2 + 94);

            scoreLabel2.Text = "Score: " + Convert.ToString(gameScreen.score);
        }
    }
}
