using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gokkers
{
    public partial class Form1 : Form
    {
        Greyhound[] contestants = new Greyhound[4];
        PictureBox[] entitys = new PictureBox[4];
        RadioButton[] playerBoxes = new RadioButton[3];
        TextBox[] messageBoxes = new TextBox[3];
        Guy[] players = new Guy[3];
        string[] messageHolder = new string[3];
        Bet bet = new Bet();
        public void CreateEntity()
        {
            for (int i = 0; i < contestants.Length; i++)
            {
                contestants[i] = new Greyhound(625, entitys[i], entitys[i].Name);
            }
        }

        public void CreatePlayers()
        {
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Guy(playerBoxes[i].Text);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entitys[0] = entity1;
            entitys[1] = entity2;
            entitys[2] = entity3;
            entitys[3] = entity4;
            playerBoxes[0] = player1;
            playerBoxes[1] = player2;
            playerBoxes[2] = player3;
            messageBoxes[0] = bottomMessage;
            messageBoxes[1] = centerMessage;
            messageBoxes[2] = topMessage;
            CreateEntity();
            CreatePlayers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in contestants)
            {
                bool result = item.Run(winningLabel);
                if (result)
                {
                    bet.CheckWinner(players, contestants, betLabel, messageBoxes);
                    timer1.Stop();
                    break;
                }
                else
                {
                    item.Run(winningLabel);
                }
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            foreach (var item in contestants)
            {
                item.TakeStartingPosition();
            }
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            decimal betValue;
            
            betValue = betAmount.Value;
            if (player1.Checked)
            {
                if (players[0].Bet(betValue))
                {
                    players[0].ActivateBet(betValue, targetNumbers.Value);
                    players[0].UpdateMessage(messageBoxes);

                }
            }
            else if (player2.Checked)
            {
                if (players[1].Bet(betValue))
                {
                    players[1].ActivateBet(betValue, targetNumbers.Value);
                    players[1].UpdateMessage(messageBoxes);
                }
            }
            else if (player3.Checked)
            {
                if (players[2].Bet(betValue))
                {
                    players[2].ActivateBet(betValue, targetNumbers.Value);
                    players[2].UpdateMessage(messageBoxes);
                }
            }
            
            

        }

        
    }
}
