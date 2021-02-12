using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharmaHWNo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FtoC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CtoF_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void FtoC_Click(object sender, EventArgs e)
        {
            if (FtoC.Checked) // if the button is clicked, the click is on
            {
                textBox1.Focus();
                textBox1.SelectAll();
                return;

                text1.Text = " Fahrenhite";
                text2.Text = "Celcius";
                textBox2.Text = "    ";

            }
        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            if (CtoF.Checked)
            {
                textBox1.Focus();
                textBox1.SelectAll();
                return;

                text1.Text = "Celcius";
                text2.Text = "Fahrenhite";
                textBox2.Text = "   ";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Calc_butt_Click(object sender, EventArgs e)
        {
           
           

            if (CtoF.Checked)
            {
                Double result;
                Double input;

               

                try
                {
                    input = Double.Parse(textBox1.Text);
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, " Error");
                    textBox1.Focus();
                    textBox1.SelectAll();
                    return;


                }

                result = (input * 9 / 5) + 32;
                textBox2.Text = result.ToString();

                textBox1.Focus();
                textBox1.SelectAll();
                return;

            }

            if (FtoC.Checked)
            {
                Double result1;
                Double input1;

                

                try
                {
                    input1 = Double.Parse(textBox1.Text);
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, " Error");
                    textBox1.Focus();
                    textBox1.SelectAll();
                    return;

                }

                result1 = (input1-32) * 5/9;
                textBox2.Text = "" + result1;


                textBox1.Focus();
                textBox1.SelectAll();
                return;

            }
        }
    }
}
