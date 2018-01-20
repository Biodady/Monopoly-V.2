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
        public Form1()
        {
            InitializeComponent();
        }
        int roll = 0;
        int x1 = 45, x2 = 90, x3 = 135, x4 = 180, x5 = 225, x6 = 270; //270 //32
        int y1 = 45, y2 = 90, y3 = 135, y4 = 180, y5 = 225, y6 = 270;
        int currentDis = 0;
        
        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            roll = rnd.Next(1, 1);
            lbRoll.Text = roll.ToString();
            lbDis.Text = player.Top.ToString();
            lbCheck.Text = player.Left.ToString();
            if (player.Left >= 77)
            {
                if (roll == 1)
                {
                    player.Left -= x1;
                }
                else if (roll == 2)
                {
                    player.Left -= x2;
                }
                else if (roll == 3)
                {
                    player.Left -= x3;
                }
                else if (roll == 4)
                {
                    player.Left -= x4;
                }
                else if (roll == 5) 
                {
                    player.Left -= x5;
                }
                else if (roll == 6)
                {
                    player.Left -= x6;
                    currentDis += roll;
                }
            }
            else if(player.Left < 77)
            {
                if (roll == 1)
                {
                    player.Top -= y1;
                }
                else if (roll == 2)
                {
                    player.Top -= y2;
                }
                else if (roll == 3)
                {
                    player.Top -= y3;
                }
                else if (roll == 4)
                {
                    player.Top -= y4;
                }
                else if (roll == 5)
                {
                    player.Top -= y5;
                }
                else if (roll == 6)
                {
                    player.Top -= y6;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
