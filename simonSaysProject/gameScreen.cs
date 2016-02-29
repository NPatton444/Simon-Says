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

        //Guess index
        int index = 0;

        int score;

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

            //Game Starting Refresh
            this.Refresh();

            //Go to Computer Turn method
            computerTurn();
        }

        private void computerTurn()
        {

            this.Refresh();
            //Random Number Generator to pick Colour
            Random randGen = new Random();
            int randColour = randGen.Next(0, 4);

            //Add randColour to Pattern list
            Form1.pattern.Add(randColour);

            //Display Score
            score = Form1.pattern.Count() - 1;
            scoreLabel.Text = Convert.ToString(score);

            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                //Button Flash and Play Sound
                if (Form1.pattern[i] == 0)
                {
                    Thread.Sleep(500);
                    this.Refresh();

                    //Play Sound
                    greenPlayer.Play();

                    //Flash Green Button
                    greenButton.BackColor = Color.LightGreen;
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.Green;
                }

                else if(Form1.pattern[i] == 1)
                {
                    Thread.Sleep(500);
                    this.Refresh();

                    //Play Sound
                    redPlayer.Play();

                    //Flash Red Button
                    redButton.BackColor = Color.LightCoral;
                    Thread.Sleep(500);
                    redButton.BackColor = Color.Red;
                }

                else if(Form1.pattern[i] == 2)
                {
                    Thread.Sleep(500);
                    this.Refresh();

                    //Play Sound
                    bluePlayer.Play();

                    //Flash Blue Button
                    blueButton.BackColor = Color.LightBlue;
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.Blue;
                }

                else if(Form1.pattern[i] == 3)
                {
                    Thread.Sleep(500);
                    this.Refresh();

                    //Play Sound
                    yellowPlayer.Play();

                    //Flash Yellow Button
                    yellowButton.BackColor = Color.LightYellow;
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Yellow;
                }

                //Pause and Refresh
                Thread.Sleep(1000);
                this.Refresh();
            }
        }

        #region Player Turn

        private void greenButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(Form1.pattern[index] == 0)
            {
                //Play Sound
                greenPlayer.Play();

                //Flash Green Button
                greenButton.BackColor = Color.LightGreen;
                Thread.Sleep(500);
                greenButton.BackColor = Color.Green;

                index++;

                //Run Computer Turn Method
                if(index == Form1.pattern.Count())
                {
                    computerTurn();
                }
            }

            else
            {
                //Go to Game over
                gameOver();
            }
        }

        private void redButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form1.pattern[index] == 1)
            {
                //Play Sound
                redPlayer.Play();

                //Flash Green Button
                redButton.BackColor = Color.LightCoral;
                Thread.Sleep(500);
                redButton.BackColor = Color.Red;

                index++;

                //Run Computer Turn Method
                if (index == Form1.pattern.Count())
                {
                    computerTurn();
                }
            }

            else
            {
                //Go to Game over
                gameOver();
            }
        }

        private void blueButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form1.pattern[index] == 2)
            {
                //Play Sound
                bluePlayer.Play();

                //Flash Green Button
                blueButton.BackColor = Color.LightBlue;
                Thread.Sleep(500);
                blueButton.BackColor = Color.Blue;

                index++;

                //Run Computer Turn Method
                if (index == Form1.pattern.Count())
                {
                    computerTurn();
                }
            }

            else
            {
                //Go to Game over
                gameOver();
            }
        }

        private void yellowButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form1.pattern[index] == 3)
            {
                //Play Sound
                yellowPlayer.Play();

                //Flash Green Button
                yellowButton.BackColor = Color.LightYellow;
                Thread.Sleep(500);
                yellowButton.BackColor = Color.Yellow;

                index++;

                //Run Computer Turn Method
                if (index == Form1.pattern.Count())
                {
                    computerTurn();
                }
            }

            else
            {
                //Go to Game over
                gameOver();
            }
        }

        #endregion

        private void gameOver()
        {
            //Play Mistake Sound 
            mistakePlayer.Play();
        }
    }
}
