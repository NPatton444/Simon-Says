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
using System.IO;

namespace simonSaysProject
{
    public partial class gameScreen : UserControl
    {
        //Sound Player
        List<SoundPlayer> player = new List<SoundPlayer>();
        SoundPlayer mistakePlayer = new SoundPlayer(Properties.Resources.mistake);

        //Button List
        List<Button> button = new List<Button>();

        //Colour List
        List<Color> color = new List<Color>();

        //Guess index
        int index = 0;

        public static int score;

        double pauseIndex = 1000;

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

            //Add players to list
            player.Add(new SoundPlayer(Properties.Resources.green));
            player.Add(new SoundPlayer(Properties.Resources.red));
            player.Add(new SoundPlayer(Properties.Resources.blue));
            player.Add(new SoundPlayer(Properties.Resources.yellow));

            //Add Buttons to list
            button.Add(greenButton);
            button.Add(redButton);
            button.Add(blueButton);
            button.Add(yellowButton);

            //Add colours to list
            color.Add(Color.Green);
            color.Add(Color.Red);
            color.Add(Color.Blue);
            color.Add(Color.Yellow);
            color.Add(Color.LightGreen);
            color.Add(Color.LightCoral);
            color.Add(Color.LightBlue);
            color.Add(Color.LightYellow);

            //Go to Computer Turn method
            computerTurn();
        }

        #region Computer Turn

        /// <summary>
        /// Runs logic for randomly picking buttons to flash
        /// </summary>
        private void computerTurn()
        {
            //Decrease Pause Index to make game faster the longer it's been player
            if (Form1.pattern.Count() % 5 == 0)
            {
                pauseIndex = pauseIndex * 0.85;
            }

            //Make Buttons un clickable during computer turn
            for (int i = 0; i < button.Count; i++)
            {
                button[i].Enabled = false;
                button[i].BackColor = color[i];
            }

            this.Refresh();


            //Random Number Generator to pick Colour
            Random randGen = new Random();
            int randColour = randGen.Next(0, 4);

            //Add randColour to Pattern list
            Form1.pattern.Add(randColour);

            //Display Score
            score = Form1.pattern.Count() - 1;
            scoreLabel.Text = "Score: " + Convert.ToString(score);

            //Reset Index
            index = 0;

            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                //Button Flash and Play Sound
                if (Form1.pattern[i] == 0)
                {
                    flashes(0, 4);
                }

                else if (Form1.pattern[i] == 1)
                {
                    flashes(1, 5);
                }

                else if (Form1.pattern[i] == 2)
                {
                    flashes(2, 6);
                }

                else if (Form1.pattern[i] == 3)
                {
                    flashes(3, 7);
                }

                //Pause and Refresh
                Thread.Sleep(Convert.ToInt16(pauseIndex));
                this.Refresh();
            }

            //Pause and Refresh Between Computer Turn and Player Turn
            Thread.Sleep(500);

            //Re enable buttons
            for(int i = 0; i < button.Count(); i++)
            {
                button[i].Enabled = true;
            }
        }

        #endregion

        #region Player Turn

        private void greenButton_MouseDown(object sender, MouseEventArgs e)
        {
            playerTurn(0, 4);
        }

        private void redButton_MouseDown(object sender, MouseEventArgs e)
        {
            playerTurn(1, 5);
        }

        private void blueButton_MouseDown(object sender, MouseEventArgs e)
        {
            playerTurn(2, 6);
        }

        private void yellowButton_MouseDown(object sender, MouseEventArgs e)
        {
            playerTurn(3, 7);
        }

        /// <summary>
        /// Logic to be repeated for flashing buttons when clicked during player turn. 
        /// It also checks if it is the correct button. 
        /// </summary>
        /// <param name="colorCheck">Index for color and button list</param>
        /// <param name="color2">Index for flash color</param>
        private void playerTurn(int colorCheck, int color2)
        {
            if (Form1.pattern[index] == colorCheck)
            {
                flashes(colorCheck, color2);

                index++;

                //Run Computer Turn Method
                if (index == Form1.pattern.Count())
                {
                    Thread.Sleep(500);
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

        /// <summary>
        /// Makes buttons flash during computer turn or when clicked in player turn method
        /// </summary>
        /// <param name="buttonColor">Indexing for to pick button and color of button before and after flash</param>
        /// <param name="color2">Indexing to pick color of button during flash</param>
        private void flashes(int buttonColor, int color2)
        {
            Thread.Sleep(500);
            this.Refresh();

            //Play Sound
            player[buttonColor].Play();

            //Flash Yellow Button
            button[buttonColor].BackColor = color[color2];
            this.Refresh();
            Thread.Sleep(100);
            button[buttonColor].BackColor = color[buttonColor];
            this.Refresh();
        }

        private void gameOver()
        {
            //Play Mistake Sound 
            mistakePlayer.Play();

            //Go to game over Screen
            gameOverScreen gos = new gameOverScreen();
            Form f = this.FindForm();

            //Remove Main Screen
            f.Controls.Remove(this);

            f.Controls.Add(gos);
        }
    }
}
