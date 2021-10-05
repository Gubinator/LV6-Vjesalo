using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gubo___LV6_Z2_Vjesalo
{
    public partial class Form1 : Form
    {
        string secretWord;
        int zivot = 5;
        
        bool c1guess, c2guess, c3guess, c4guess, c5guess, c6guess, Win;

        private void ClickExitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        char c1, c2, c3, c4, c5, c6;
        
        
        private void ButtonIgrajClick(object sender, EventArgs e)
        {
            //ResetMethod();
            Resetter();
            secretWord = GetWord.WordGetter();
            c1 = secretWord[0]; c2 = secretWord[1]; c3 = secretWord[2]; c4 = secretWord[3]; c5 = secretWord[4];
            zivot = 5;
            LivesButton.Text = zivot.ToString();
            MessageBox.Show(secretWord);
            MessageBox.Show("Nova rijec je generirana.", "Hangman");
        }

       /* private void ResetMethod()
        {
            Application.Restart();
        } */
        private void GuessClick(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 2)
                MessageBox.Show("Maksimalno jedno slovo.", "Greska");

            if (secretWord.Contains(textBox1.Text.ToLower()))
            {
                if (textBox1.Text == c1.ToString())
                {
                    B1Guess.Text = c1.ToString();
                    c1guess = true;
                }
                if (textBox1.Text == c2.ToString())
                {
                    B2Guess.Text = c2.ToString();
                    c2guess = true;
                }
                if (textBox1.Text == c3.ToString())
                {
                    B3Guess.Text = c3.ToString();
                    c3guess = true;
                }
                if (textBox1.Text == c4.ToString())
                {
                    B4Guess.Text = c4.ToString();
                    c4guess = true;
                }
                if (textBox1.Text == c5.ToString())
                {
                    B5Guess.Text = c5.ToString();
                    c5guess = true;
                }
                if (c1guess && c2guess && c3guess && c4guess && c5guess)
                {
                    Win = true;
                }
                if (Win)
                {
                    MessageBox.Show("Pobjeda! broj preostalih zivota:" + zivot.ToString()  , "Pobjeda");
                }
            }
            else
            {
                zivot--;
                LivesButton.Text = zivot.ToString();
                if (LivesButton.Text == "0")
                {
                    MessageBox.Show("Izgubili ste. Trazena rijec je:" + secretWord, "Poraz");
                    Win = false;
                    GuessButton.Visible = false;
                }
            }
        }

        private void Resetter()
        {
            Win = false; c1guess = false; c2guess = false; c3guess = false; c4guess = false; c5guess = false; GuessButton.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
