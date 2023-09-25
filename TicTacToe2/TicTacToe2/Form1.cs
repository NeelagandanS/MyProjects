using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";

            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkforwinner();
        }
        private void checkforwinner()
        {
            bool winner = false;
            //horizontal check
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled)) { winner = true; }



            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled)) { winner = true; }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled)) { winner = true; }

            //vertical checks
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                winner = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                winner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {
                winner = true;
            }
            //diagonal check
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                winner = true;
            }
            else if ((c1.Text == b2.Text) && (b2.Text == a3.Text) && (!c1.Enabled))
            {
                winner = true;
            }
            if (winner)
            {
                disablebutton();
                string w = " ";
                if (turn)
                {
                    w = "O";
                }
                else
                {
                    w = "X";
                }
                MessageBox.Show(w + "Wins!");

            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Match Draw!");
                }
            }
        }
        private void disablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = " ";
                    }

                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                BackColor = Color.Black;
                checkBox1.ForeColor = Color.White;
                checkBox1.BackColor = Color.Transparent;
               /* foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        Button b = (Button)c;
                        b.ForeColor = Color.LimeGreen;
                    }
                }
               */

            }
            else if (checkBox1.Checked == false)
            {
                BackColor = Color.YellowGreen;
                checkBox1.ForeColor = Color.Black;
             
             /*   a2.ForeColor = Color.Black;
                a3.ForeColor = Color.Black;
                b1.ForeColor = Color.Black;
                b2.ForeColor = Color.Black;
                b3.ForeColor = Color.Black;
                c1.ForeColor = Color.Black;
                c2.ForeColor = Color.Black;
                c3.ForeColor = Color.Black;
             */
            }

        }
    }
}
