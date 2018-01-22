using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_V._2
{

    public partial class Form1 : Form
    {
        int roll = 0;
        int Current_Distance = 0, Current_Distance_Bot = 0;
        int stage = 0;

        protected int Cal_Distance (int Old_Distance, int Dice) // Process Distance Function.
        {
            int New_Distance = 0;

            return (New_Distance = (Old_Distance + Dice) % 40);
        }

        public int RollDice()    // Roll Dice for player and bot
        {
            int dice1 = 0, totalDice = 0;

            Random rnd = new Random();
            dice1 = rnd.Next(1, 7);

            return (totalDice = dice1);
        }

        public Form1()
        {

            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            /*Player Turn*/
            if (stage == 0)
            {
                roll = RollDice();
                lbRoll.Text = roll.ToString();  // Check dice value

                Current_Distance = Cal_Distance(Current_Distance, roll);
                lbCheck.Text = Current_Distance.ToString();

                if (Current_Distance == 1)
                {
                    player.Location = btnDis1.Location;
                }
                else if (Current_Distance == 2)
                {
                    player.Location = btnDis2.Location;
                }
                else if (Current_Distance == 3)
                {
                    player.Location = btnDis3.Location;
                }
                else if (Current_Distance == 4)
                {
                    player.Location = btnDis4.Location;
                }
                else if (Current_Distance == 5)
                {
                    player.Location = btnDis5.Location;
                }
                else if (Current_Distance == 6)
                {
                    player.Location = btnDis6.Location;
                }
                else if (Current_Distance == 7)
                {
                    player.Location = btnDis7.Location;
                }
                else if (Current_Distance == 8)
                {
                    player.Location = btnDis8.Location;
                }
                else if (Current_Distance == 9)
                {
                    player.Location = btnDis9.Location;
                }
                else if (Current_Distance == 10)
                {
                    player.Location = btnDis10.Location;
                }
                else if (Current_Distance == 11)
                {
                    player.Location = btnDis11.Location;
                }
                else if (Current_Distance == 12)
                {
                    player.Location = btnDis12.Location;
                }
                else if (Current_Distance == 13)
                {
                    player.Location = btnDis13.Location;
                }
                else if (Current_Distance == 14)
                {
                    player.Location = btnDis14.Location;
                }
                else if (Current_Distance == 15)
                {
                    player.Location = btnDis15.Location;
                }
                else if (Current_Distance == 16)
                {
                    player.Location = btnDis16.Location;
                }
                else if (Current_Distance == 17)
                {
                    player.Location = btnDis17.Location;
                }
                else if (Current_Distance == 18)
                {
                    player.Location = btnDis18.Location;
                }
                else if (Current_Distance == 19)
                {
                    player.Location = btnDis19.Location;
                }
                else if (Current_Distance == 20)
                {
                    player.Location = btnDis20.Location;
                }
                else if (Current_Distance == 21)
                {
                    player.Location = btnDis21.Location;
                }
                else if (Current_Distance == 22)
                {
                    player.Location = btnDis22.Location;
                }
                else if (Current_Distance == 23)
                {
                    player.Location = btnDis23.Location;
                }
                else if (Current_Distance == 24)
                {
                    player.Location = btnDis24.Location;
                }
                else if (Current_Distance == 25)
                {
                    player.Location = btnDis25.Location;
                }
                else if (Current_Distance == 26)
                {
                    player.Location = btnDis26.Location;
                }
                else if (Current_Distance == 27)
                {
                    player.Location = btnDis27.Location;
                }
                else if (Current_Distance == 28)
                {
                    player.Location = btnDis28.Location;
                }
                else if (Current_Distance == 29)
                {
                    player.Location = btnDis29.Location;
                }
                else if (Current_Distance == 30)
                {
                    player.Location = btnDis30.Location;
                }
                else if (Current_Distance == 31)
                {
                    player.Location = btnDis31.Location;
                }
                else if (Current_Distance == 32)
                {
                    player.Location = btnDis32.Location;
                }
                else if (Current_Distance == 33)
                {
                    player.Location = btnDis33.Location;
                }
                else if (Current_Distance == 34)
                {
                    player.Location = btnDis34.Location;
                }
                else if (Current_Distance == 35)
                {
                    player.Location = btnDis35.Location;
                }
                else if (Current_Distance == 36)
                {
                    player.Location = btnDis36.Location;
                }
                else if (Current_Distance == 37)
                {
                    player.Location = btnDis37.Location;
                }
                else if (Current_Distance == 38)
                {
                    player.Location = btnDis38.Location;
                }
                else if (Current_Distance == 39)
                {
                    player.Location = btnDis39.Location;
                }
                else if (Current_Distance == 0)
                {
                    player.Location = btnDis0.Location;
                }
                stage = 1;
                lbdistance.Text = "Bot Turn";
            }


                
         
                
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btnDis1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbDis_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            /*Bot Turn*/
            if (stage == 1)
            {
                /*Bot Turn*/
                roll = RollDice();
                lbRoll.Text = roll.ToString();  // Check dice value

                Current_Distance_Bot = Cal_Distance(Current_Distance_Bot, roll);
                lbCheck.Text = Current_Distance.ToString();

                if (Current_Distance_Bot == 1)
                {
                    bot.Location = btnDis1.Location;
                }
                else if (Current_Distance_Bot == 2)
                {
                    bot.Location = btnDis2.Location;
                }
                else if (Current_Distance_Bot == 3)
                {
                    bot.Location = btnDis3.Location;
                }
                else if (Current_Distance_Bot == 4)
                {
                    bot.Location = btnDis4.Location;
                }
                else if (Current_Distance_Bot == 5)
                {
                    bot.Location = btnDis5.Location;
                }
                else if (Current_Distance_Bot == 6)
                {
                    bot.Location = btnDis6.Location;
                }
                else if (Current_Distance_Bot == 7)
                {
                    bot.Location = btnDis7.Location;
                }
                else if (Current_Distance_Bot == 8)
                {
                    bot.Location = btnDis8.Location;
                }
                else if (Current_Distance_Bot == 9)
                {
                    bot.Location = btnDis9.Location;
                }
                else if (Current_Distance_Bot == 10)
                {
                    bot.Location = btnDis10.Location;
                }
                else if (Current_Distance_Bot == 11)
                {
                    bot.Location = btnDis11.Location;
                }
                else if (Current_Distance_Bot == 12)
                {
                    bot.Location = btnDis12.Location;
                }
                else if (Current_Distance_Bot == 13)
                {
                    bot.Location = btnDis13.Location;
                }
                else if (Current_Distance_Bot == 14)
                {
                    bot.Location = btnDis14.Location;
                }
                else if (Current_Distance_Bot == 15)
                {
                    bot.Location = btnDis15.Location;
                }
                else if (Current_Distance_Bot == 16)
                {
                    bot.Location = btnDis16.Location;
                }
                else if (Current_Distance_Bot == 17)
                {
                    bot.Location = btnDis17.Location;
                }
                else if (Current_Distance_Bot == 18)
                {
                    bot.Location = btnDis18.Location;
                }
                else if (Current_Distance_Bot == 19)
                {
                    bot.Location = btnDis19.Location;
                }
                else if (Current_Distance_Bot == 20)
                {
                    bot.Location = btnDis20.Location;
                }
                else if (Current_Distance_Bot == 21)
                {
                    bot.Location = btnDis21.Location;
                }
                else if (Current_Distance_Bot == 22)
                {
                    bot.Location = btnDis22.Location;
                }
                else if (Current_Distance_Bot == 23)
                {
                    bot.Location = btnDis23.Location;
                }
                else if (Current_Distance_Bot == 24)
                {
                    bot.Location = btnDis24.Location;
                }
                else if (Current_Distance_Bot == 25)
                {
                    bot.Location = btnDis25.Location;
                }
                else if (Current_Distance_Bot == 26)
                {
                    bot.Location = btnDis26.Location;
                }
                else if (Current_Distance_Bot == 27)
                {
                    bot.Location = btnDis27.Location;
                }
                else if (Current_Distance_Bot == 28)
                {
                    bot.Location = btnDis28.Location;
                }
                else if (Current_Distance_Bot == 29)
                {
                    bot.Location = btnDis29.Location;
                }
                else if (Current_Distance_Bot == 30)
                {
                    bot.Location = btnDis30.Location;
                }
                else if (Current_Distance_Bot == 31)
                {
                    bot.Location = btnDis31.Location;
                }
                else if (Current_Distance_Bot == 32)
                {
                    bot.Location = btnDis32.Location;
                }
                else if (Current_Distance_Bot == 33)
                {
                    bot.Location = btnDis33.Location;
                }
                else if (Current_Distance_Bot == 34)
                {
                    bot.Location = btnDis34.Location;
                }
                else if (Current_Distance_Bot == 35)
                {
                    bot.Location = btnDis35.Location;
                }
                else if (Current_Distance_Bot == 36)
                {
                    bot.Location = btnDis36.Location;
                }
                else if (Current_Distance_Bot == 37)
                {
                    bot.Location = btnDis37.Location;
                }
                else if (Current_Distance_Bot == 38)
                {
                    bot.Location = btnDis38.Location;
                }
                else if (Current_Distance_Bot == 39)
                {
                    bot.Location = btnDis39.Location;
                }
                else if (Current_Distance_Bot == 0)
                {
                    bot.Location = btnDis0.Location;
                }
                stage = 0;
                lbdistance.Text = "Player Turn";
            }
        }

        private void gameReset_Click(object sender, EventArgs e)
        {
            bot.Location = btnDis0.Location;
            player.Location = btnDis0.Location;
            Current_Distance_Bot = 0;
            Current_Distance = 0;
            roll = 0;
        }






    }
}
