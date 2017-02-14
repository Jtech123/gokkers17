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
        
        public void CreateEntity()
        {
            for (int i = 0; i < contestants.Length; i++)
            {
                contestants[i] = new Greyhound(625, entitys[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
            CreateEntity();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entitys[0] = entity1;
            entitys[1] = entity2;
            entitys[2] = entity3;
            entitys[3] = entity4;
            CreateEntity();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in contestants)
            {
                bool result = item.Run(winningLabel);
                if (result)
                {
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
    }
}
