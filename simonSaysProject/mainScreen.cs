﻿using System;
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
    public partial class mainScreen : UserControl
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Move to game screen
            gameScreen gs = new gameScreen();
            Form f = this.FindForm();

            //Remove Main Screen
            f.Controls.Remove(this);

            f.Controls.Add(gs);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
