using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }
        public bool player = true;
        public bool draws = false;
        public bool flip = true;
        public bool flip2 = false;
        public int turn = 0;
        public bool drawstar = false;
        public int p1 = 0;
        public int p2 = 0;
        public int draw = 0;

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            if (player == true && b.Text == "")
            {

                b.Text = "X";
                player = false;
                turn++;


            } else if (player == false && b.Text == "")
            {
                b.Text = "O";
                player = true;
                turn++;


            }



            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {

                if (b.Text == "X")
                {

                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }else
                    {
                        p2++;
                    }
                }
                else if (b.Text == "O")
                {

                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }

                reset_buttons();

            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            {
                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }
                reset_buttons();
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            {
                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }
                reset_buttons();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {

                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else if (b.Text == "O")
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }
                reset_buttons();

            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            {

                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else if (b.Text == "O")
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }

                reset_buttons();
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            {

                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else if (b.Text == "O")
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }

                reset_buttons();

            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text != "")
            {
                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }

                reset_buttons();

            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                if (b.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p1++;
                    }
                    else
                    {
                        p2++;
                    }
                }
                else
                {
                    MessageBox.Show("O Wins!");
                    if (flip == true && flip2 == false)
                    {
                        p2++;
                    }
                    else
                    {
                        p1++;
                    }
                }

                reset_buttons();

            } else if (turn == 9)
            {
                drawstar = true;
                draws = true;
            }


            if (draws == true && drawstar == true)
            {
                MessageBox.Show("Draw!");
                draw++;
                
                reset_buttons();
            }

            if (flip2 == false)
            {
                label1.Text = "X :" + p1;
                label2.Text = "O :" + p2;
                label3.Text = "Draw :" + draw;

            }
            else if (flip2 == true)
            {
                label1.Text = "X :" + p2;
                label2.Text = "O :" + p1;
                label3.Text = "Draw :" + draw;

            }



        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = true;
            draws = false;
            turn = 0;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = true;
            turn = 0;
            draws = false;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            p1 = 0;
            p2 = 0;
            draw = 0;
            label1.Text = "X :" + p1;
            label2.Text = "O :" + p2;
            label3.Text = "Draw :" + draw;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void reset_buttons()
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            turn = 0;
            drawstar = false;
            draws = false;
            player = true;

    }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            if (flip == true)
            {
                label1.Text = "X :" + p2;
                label2.Text = "O :" + p1;
                label3.Text = "Draw :" + draw;
                flip = false;
                flip2 = true;
            }
            else
            {
                label1.Text = "X :" + p1;
                label2.Text = "O :" + p2;
                label3.Text = "Draw :" + draw;
                flip = true;
                flip2 = false;
            }
        }

     
    }
}
