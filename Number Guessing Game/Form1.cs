//  Scottie Sterling
//  4/20/2018
//  Number Guessing Game


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number;

        private void Form1_Load(object sender, EventArgs e)
        {
            //generate the number
            Random generator = new Random();
            number = generator.Next(0, 101);
            MessageBox.Show("I'm thinking of a number from 1-100, let's guess it!");
        }

        private void button_guess_Click(object sender, EventArgs e)
        {
            // get the guess from the textbox
            int guess = Convert.ToInt32(textbox_guess.Text);

            //check the guess
            if (guess > number)
            {
                MessageBox.Show("Too High.");
            }
            if (guess < number)
            {
                MessageBox.Show("Too low.");
            }
            if (guess == number)
            {
                MessageBox.Show("You guessed it.");
                Application.Exit();
            }
        }
    }
}
