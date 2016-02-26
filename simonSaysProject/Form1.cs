using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simonSaysProject
{
    public partial class Form1 : Form
    {
        //Pattern List
        public static List<int> pattern = new List<int>;
        public Form1()
        {
            InitializeComponent();

            //Go to main Screen
            mainScreen ms = new mainScreen();
            this.Controls.Add(ms);
        }
    }
}
