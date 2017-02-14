﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    class Fish
    {
        public static Random Randomizer = new Random();
        public int RaceTrackLength;
        public PictureBox MyPictureBox;
        private string name;

        private int distance;

        public Fish(int RaceTrackLength, PictureBox MyPictureBox, string name)
        {
            this.RaceTrackLength = RaceTrackLength;
            this.MyPictureBox = MyPictureBox;
            this.name = name;
        }

        public bool Run(Label winner)
        {
            if (this.MyPictureBox.Location.X < RaceTrackLength)
            {

                distance = Randomizer.Next(1, 70);
                this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + (distance / 10), this.MyPictureBox.Location.Y);
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

        public string GetName()
        {
            return this.name;
        }

        public int GetPosX()
        {
            return MyPictureBox.Location.X;
        }
    }
}
