using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    class Bet
    {
        public void CheckWinner(Guy[] players, Greyhound[] entitys, Label betting, TextBox[] messageBoxes)
        {
            foreach(var player in players)
            {
                foreach (var entity in entitys)
                {
                    if (("entity" + player.GetTarget().ToString()) == entity.GetName() && entity.GetPosX() >= entity.RaceTrackLength)
                    {
                        player.Winning(betting);
                        player.ShowWinnerMessage(messageBoxes);
                    }
                    else
                    {
                        player.Losing();
                    }
                }
            }
        }
    }
}
