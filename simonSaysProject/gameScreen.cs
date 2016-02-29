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

namespace simonSaysProject
{
    public partial class gameScreen : UserControl
    {
        //Sound Player
        SoundPlayer redPlayer = new SoundPlayer(Properties.Resources.red);
        SoundPlayer bluePlayer = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer greenPlayer = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellowPlayer = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer mistakePlayer = new SoundPlayer(Properties.Resources.mistake);

        public gameScreen()
        {
            InitializeComponent();

            //Button Locations
            yellowButton.Location = new Point(this.Width / 2, this.Height / 2);
            blueButton.Location = new Point(this.Width / 2 - blueButton.Width, this.Height / 2);
            redButton.Location = new Point(this.Width / 2, this.Height / 2 - redButton.Height);
            greenButton.Location = new Point(this.Width / 2 - greenButton.Width, this.Height / 2 - greenButton.Height);
        }

        private void gameScreen_Load(object sender, EventArgs e)
        {
            //Clear Pattern List at the Start of the Game
            Form1.pattern.Clear();

            //Game Starting Pause
            this.Refresh();
            Thread.Sleep(5000);

            //Go to Computer Turn method
            computerTurn();
        }

        private void computerTurn()
        {
            //Random Number Generator to pick Colour
            Random randGen = new Random();
            int randColour = randGen.Next(0, 4);

            //Add randColour to Pattern list
            Form1.pattern.Add(randColour);

            for(int i = 0; i < Form1.pattern.Count(); i++)
            {
                //Button Flash and Play Sound
                if (Form1.pattern[i] == 0)
                {
                    //Play Sound
                    greenPlayer.Play();

                    //Flash Green Button
                    greenButton.BackColor = Color.LightGreen;
                }

                else if(Form1.pattern[i] == 1)
                {
                    //Play Sound
                    redPlayer.Play();

                    //Flash Red Button
                    redButton.BackColor = Color.LightCoral;
                }

                else if(Form1.pattern[i] == 2)
                {
                    //Play Sound
                    bluePlayer.Play();

                    //Flash Blue Button
                    blueButton.BackColor = Color.LightBlue;
                }

                else if(Form1.pattern[i] == 3)
                {
                    //Play Sound
                    yellowPlayer.Play();

                    //Flash Yellow Button
                    yellowButton.BackColor = Color.LightYellow;
                }

                //Pause and Refresh
                Thread.Sleep(1000);
                this.Refresh();
            }
        }
    }
}
