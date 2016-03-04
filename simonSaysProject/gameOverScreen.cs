using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace simonSaysProject
{
    public partial class gameOverScreen : UserControl
    {
        public gameOverScreen()
        {
            InitializeComponent();

            scoreLabel2.Text = "Score: " + Convert.ToString(gameScreen.score);

            //Label Locations
            titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, this.Height / 2 - 100);
            scoreLabel2.Location = new Point(this.Width / 2 - scoreLabel2.Width / 2, this.Height / 2 - 50);

            //Button Locations
            replayButton.Location = new Point(this.Width / 2 - replayButton.Width / 2, this.Height / 2 + 50);
            closeButton.Location = new Point(this.Width / 2 - closeButton.Width / 2, this.Height / 2 + 94);

            //High Scores
            string[] lines = File.ReadAllLines(Form1.filePath);
            lines.Reverse();
            for (int i = 0; i < lines.Count(); i++)
            {
                string[] split = lines[i].Split(':');

                if (gameScreen.score > Convert.ToInt16(split[1]))
                {
                    
                }
            }
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            //Move to game screen
            mainScreen ms = new mainScreen();
            Form f = this.FindForm();

            //Remove Main Screen
            f.Controls.Remove(this);

            f.Controls.Add(ms);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
