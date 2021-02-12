using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8puzzle
{
    public partial class Form1 : Form
    {
        int blank;
        int NoOfSqs;
        public Form1()
        {
            InitializeComponent();
            NoOfSqs = 5;
            this.Text = NoOfSqs * NoOfSqs - 1 + "s Puzzle";
            CreateButtons();
            resizetile();
            blank = NoOfSqs * NoOfSqs; // number of Green button
            mixTiles();
        }

        void CreateButtons()
        {
            // size of buttons
            int mywidth = 46;
            int myheight = 33;
            float myfontsize = 8.25f;
            int x = 67;
            int y = 72;
            int c = 1;

            for(int j = 1; j <= NoOfSqs; j++)
            {

            
                for (int i = 1; i <= NoOfSqs; i++)
                {


                    Button b = new Button();
                    b.Name = "btn" + c;
                    b.Text = "" + c;
                    b.BackColor = Color.Yellow;
                    b.Click += new EventHandler(all_click);
                    Controls.Add(b);

                    
                    Controls["btn" + c].Left = x; // left position of button 1
                    Controls["btn" + c].Top = y; // right position of button 1
                    Controls["btn" + c].Width = mywidth; // width of the button 1
                    Controls["btn" + c].Height = myheight;
                    Controls["btn" + c].Font = new Font("Microsoft Sans Serif", myfontsize);
                    c++;
                    x = mywidth + x; // y stays same
            
                }
                x = x - NoOfSqs * mywidth;
                y = y + myheight;
            } // outerloop

        }

        void mixTiles()
        {
            int count = 0;
            Random r = new Random();
            int bNo;
            while(count <= 3000)
            {
                bNo = r.Next(1,NoOfSqs*NoOfSqs + 1); // includes 1 excudes 10
                if(ValidMove(bNo))
                {
                    MakeMove(bNo);
                    count++;
                } // if
            }// while
        }// mix tiles 
        Boolean ValidMove(int bNo)
        {
            
            if (bNo == blank - NoOfSqs) return true;
            if (bNo == blank + NoOfSqs) return true;
            if (bNo == blank - 1 && (bNo % NoOfSqs) != 0) return true; //left
            if (bNo == blank + 1 && (bNo % NoOfSqs) != 1) return true; // right
            return false;
        }

        void MakeMove(int bNo)
        {
            Controls["btn" +blank].Text = Controls["btn" + bNo].Text;
            Controls["btn" +blank].BackColor = Color.Yellow;
            Controls["btn" +bNo].Text = "";
            Controls["btn" + bNo].BackColor = Color.Green;
            blank = bNo;


        }
        private void all_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; // get the number in the button
            
            int bNo = Convert.ToInt32(b.Name.Substring(3,b.Name.Length-3)); // remove 'btn' from button name


            //sender will let you know if button is clicked
            if(ValidMove(bNo))
            {
                MakeMove(bNo);
            } // if
        } // all_click

        //making window resizable 
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            resizetile();
        }

        void resizetile()
        {
            int myleft;
            int mytop;
            int mywidth = 46; // original size 
            int myheight = 33;
            float myfontsize = 8.25F;

            //changing the width of the button
            mywidth = Convert.ToInt32(mywidth / 300.00 * this.Width);
            //changing the height of the button
            myheight = Convert.ToInt32(myheight / 300.00 * this.Height);
            myfontsize = (float)(myfontsize / 300.0 * this.Width);

            //left edge of the first column
            myleft = Convert.ToInt32(0.5 * (this.Width - NoOfSqs * mywidth));
            mytop = Convert.ToInt32(0.5 * (this.Height - NoOfSqs * myheight));

            int c = 1;

            for (int i = 0; i < NoOfSqs; i++) // for each row
            {
                for (int j = 0; j < NoOfSqs; j++)
                {
                    Controls["btn" + c].Left = myleft + j * mywidth;
                    Controls["btn" + c].Top = mytop + i * myheight;

                    //width and height of each button
                    Controls["btn" + c].Width = mywidth;
                    Controls["btn" + c].Height = myheight;
                    Controls["btn" + c].Font = new Font("microsoft sans serif", myfontsize);
                    c++;
                }
            }
        }
    } // form
} //namespace
