using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    class Greyhound
    {
        public static Random Randomizer = new Random();
        public int RaceTrackLength;
        public PictureBox MyPictureBox;
       
        
        private int distance;
        
        public Greyhound(int RaceTrackLength, PictureBox MyPictureBox)
        {
            this.RaceTrackLength = RaceTrackLength;
            this.MyPictureBox = MyPictureBox;
            
        }

        public bool Run(Label winner)
        {
            if (this.MyPictureBox.Location.X < RaceTrackLength)
            {
                
                distance = Randomizer.Next(1, 70);
                this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + (distance / 20), this.MyPictureBox.Location.Y);
                return false;
            }
            else {
                winner.Text = MyPictureBox.Name + " Wins";
                winner.Visible = true;
                
                return true;
            }

        }

        public void TakeStartingPosition()
        {
            this.MyPictureBox.Location = new Point(23, this.MyPictureBox.Location.Y);
        }
    }
}
