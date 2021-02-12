using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics1
{
    class MyGraphics
    {
        // variables for the ranges of the axis --> world coordinate
        float xmin;
        float xmax;
        float ymin;
        float ymax;
        float interval;
        Graphics g;
        float xStop;
        float xinterval;
        float width;
        float height;

        public delegate float myfunc(float x); 

      

        // contrutctor to initialize our min, max, interval
        public MyGraphics(float xxmin, float xxmax, float yymin, float yymax, float tinterval, float pwidth, float pheight, float xxinterval )
        {
            xmin = xxmin;
            xmax = xxmax;
            ymin = yymin;
            ymax = yymax;
            interval = tinterval;
            width = pwidth;
            height = pheight;
            xinterval = xxinterval;
        } // constructor


        public Graphics MyGraph
        {
            get
            {
                return g;
            }
            set
            {
                g = value;
            }
        }


        // world coordinate to pixel
        public float xWorldToPixel(float xworld)
        {
            //we know
            float xorigin = width / 2;
            float xpixelperunit = width / (xmax - xmin);
            return xorigin + xworld * xpixelperunit;
        }

        public float yWorldToPixel(float yworld)
        {
            float yorigin = height / 2;
            float ypixelperunit = height / (ymax - ymin);
            return yorigin - yworld * ypixelperunit; // height measures downward 

        }

        //Any time you have to create axis. Call this method
        public void DrawAxis()
        {
            //Drawing axis
            //x-axis --> parameter: we start from middile of the panel 
            g.DrawLine(new Pen(Color.Red), xWorldToPixel(xmin), yWorldToPixel(0), xWorldToPixel(xmax), yWorldToPixel(0));

            //y-axis
            g.DrawLine(new Pen(Color.Red), xWorldToPixel(0), yWorldToPixel(ymax), xWorldToPixel(0), yWorldToPixel(ymin)); // in y axis --> x is 0

        }

        public void DrawTickMark()
        {
            for (int i = 1; i < xmax / interval; i++) // making 10 tic mark
            {

                g.DrawLine(new Pen(Color.Red), xWorldToPixel(i * interval), yWorldToPixel(0) + 5, xWorldToPixel(i * interval), yWorldToPixel(0) - 5); // -5 takes up starting point, +5 ending point
            }

            //making tics on -x axis
            for (int i = 1; i < xmax / interval; i++) // making 10 tic mark --> extreme left to right
            {

                g.DrawLine(new Pen(Color.Red), xWorldToPixel(xmin + i * interval), yWorldToPixel(0) + 5, xWorldToPixel(xmin + i * interval), yWorldToPixel(0) - 5); // -5 takes up starting point, +5 ending point
            }

            //making tics on y axis UP

            for (int i = 1; i < ymax / interval; i++)
            {
                g.DrawLine(new Pen(Color.Red), xWorldToPixel(0) + 5, yWorldToPixel(i * interval), xWorldToPixel(0) - 5, yWorldToPixel(i * interval));
            }

            //-yaxix

            for (int i = 1; i < ymax / interval; i++)
            {
                g.DrawLine(new Pen(Color.Red), xWorldToPixel(0) + 5, yWorldToPixel(ymin + i * interval), xWorldToPixel(0) - 5, yWorldToPixel(ymin + i * interval));
            }

        }

        // This method takes function as input parameter. Now, we don't need to explicilty define the function/equation
        public void DrawFunction(myfunc functionGraphic)
        {
            // go from xmin to xmax in little pieces
            float xlast = xmin;
            float ylast = xlast * xlast;
            float x = xmin + xinterval;
            float y = functionGraphic(x);


            while (x < xStop)
            {

                g.DrawLine(new Pen(Color.Red), xWorldToPixel(xlast), yWorldToPixel(ylast), xWorldToPixel(x), yWorldToPixel(y));

                //timer

                xlast = x;
                ylast = y;
                x = x + xinterval;
                y = functionGraphic(x);
            } // while
        }// DrawFunction

            public void setStop(float xxStop)
            {
            xStop = xxStop;
            }
        

        
    } // class
} // namespace
