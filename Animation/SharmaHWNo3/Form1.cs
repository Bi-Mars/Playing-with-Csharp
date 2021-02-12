using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary; // MyTimer class is in this library in .dll

namespace SharmaHWNo3
{
    public partial class Form1 : Form
    {
        //declare variables
        Image[] img;
        int picNo;
        int numPics;
        MyTimer mytimer;
        public Form1()
        {
            InitializeComponent();
         
            picNo = 0;
            numPics = 5;

            //initialize the array
            img = new Image[numPics];

            for(int i = 1; i < numPics; i++)
            {
                img[i-1] = Image.FromFile(getPath() + "Position" + i + ".png");
            }

            pictureBox.Image = img[0];

            //initialize timer class
            mytimer = new MyTimer();
            // update the event
            mytimer.tick += new MyTimer.timerTick(timerTick);
        }

      void  timerTick()
        {
            picNo++;
            picNo = picNo % numPics;
            pictureBox.Image = img[picNo];
        }


        string getPath()
        {
            String s;
            int i;
            s = Application.StartupPath; // this is the path used when application begins
            i = s.IndexOf(Application.ProductName);
            s = s.Substring(0, i + Application.ProductName.Length + 1); // this will get the location where animation.sln is 
            return s;
        }

        private void Faster_Click(object sender, EventArgs e)
        {
            //sleep shorter
            mytimer.tickInt = 50;
        }

        private void Slower_Click(object sender, EventArgs e)
        {
            // sleep longer
            mytimer.tickInt = 200;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            mytimer.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            mytimer.Stop();
        }
    }
}
