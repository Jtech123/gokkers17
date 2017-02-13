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
        //Greyhound contestant1;
        //Greyhound contestant2;
        //Greyhound contestant3;
        //Greyhound contestant4;
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
            //Greyhound contestant1 = new Greyhound(781, entity1);
            //Greyhound contestant2 = new Greyhound(781, entity2);
            //Greyhound contestant3 = new Greyhound(781, entity3);
            //Greyhound contestant4 = new Greyhound(781, entity4);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in contestants)
            {
                Thread.Sleep(5);
                item.Run();
            }
        }
    }
}
