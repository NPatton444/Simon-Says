using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace simonSaysProject
{
    public partial class Form1 : Form
    {
        public static string filePath = "highscores.txt";

        //Pattern List
        public static List<int> pattern = new List<int>();

        public Form1()
        {
            //Create High Score File
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            else
            {
                string[] lines = File.ReadAllLines(filePath);
                string[] newLines = new string[lines.Count() + 1];
                foreach (var s in lines)
                {

                }
            }

            InitializeComponent();
            
            //Go to main Screen
            mainScreen ms = new mainScreen();
            this.Controls.Add(ms);
        }
    }
}
