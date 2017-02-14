using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    class Guy
    {
        public string name;
        private decimal cash;
        private decimal betValue;
        private decimal target;
        private RadioButton playerItem;

        public Guy(string name, RadioButton playerItem)
        {
            this.cash = 100;
            this.name = name;
            this.playerItem = playerItem;
        }

        public bool Bet(decimal value)
        {
            if (value <= this.cash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ActivateBet(decimal value, decimal target)
        {
            this.betValue = value;
            this.cash -= this.betValue;
            this.target = target;
           
        }

        public void Winning(Label betting)
        {
            this.cash += (this.betValue * 2);
            betting.Text = this.name + " has won " + this.betValue + " account balance " + this.cash;
            betting.Visible = true;
        }

        public void Losing()
        {

        }

        public void UpdateMessage(TextBox[] messageBoxes)
        {
            messageBoxes[2].Text = messageBoxes[1].Text;
            Thread.Sleep(10);
            messageBoxes[1].Text = messageBoxes[0].Text;
            Thread.Sleep(10);
            messageBoxes[0].Text = this.name + " bet " + this.betValue + " on " + this.target;
        }

        public void ShowWinnerMessage(TextBox[] messageBoxes)
        {
            messageBoxes[2].Text = messageBoxes[1].Text;
            Thread.Sleep(10);
            messageBoxes[1].Text = messageBoxes[0].Text;
            Thread.Sleep(10);
            messageBoxes[0].Text = this.name + " won the bet of " + this.betValue + " on " + this.target;
        }

        public void SetBoxText()
        {
            this.playerItem.Text = this.playerItem.Name + " " + this.cash;
        }

        public void SetBetValue(decimal betValue)
        {
            this.betValue = betValue;
        }

        public void SetCash(decimal cash)
        {
            this.cash = cash;
        }

        public void SetTarget(decimal targetBet)
        {
            this.target = targetBet;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public decimal GetBetValue()
        {
            return this.betValue;
        }

        public decimal GetCash()
        {
            return this.cash;
        }

        public decimal GetTarget()
        {
            return this.target;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
