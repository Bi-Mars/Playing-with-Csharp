using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        // variables for the ranges of the axis --> world coordinate
        float xmin = -5;
        float xmax = 5;
        float ymin = -5;
        float ymax = 5;
        float interval = 1;
        Graphics g;
        float xStop = -5;
        float xinterval = .1f;

        MyGraphics gg;
       
        public float myfunc(float x)
        {
            float xx = x * x;
            return xx;
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            // call mygraphic class
            gg = new MyGraphics(xmin, xmax, ymin, ymax, interval, panel1.Width, panel1.Height, xinterval);
        }

        public static float xx(float x)
        {
            float y = x * x;
            return x;
        }
       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
          
            g = e.Graphics; // e is Paint Event
            gg.MyGraph = g;
           gg.DrawAxis();
          gg.DrawTickMark();
           gg.DrawFunction(this.myfunc);
        } //panel
    

        private void Timer1_Tick(object sender, EventArgs e)  // everytime timer ticks we draw line
        {
            xStop = xStop + xinterval;
            gg.setStop(xStop);
            panel1.Refresh();

            if(xStop > xmax)
            {
                timer1.Stop();
            }
            
        }
    }
}

