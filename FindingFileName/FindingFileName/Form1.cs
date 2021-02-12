using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FindingFileName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String s;
            s = getPath() + "\\MyFiles";
            InitializeComponent();
            //MessageBox.Show(getPath());
            String[] myFileNames;
            myFileNames = Directory.GetFiles(s); // gets all files and returns array of files --> s is the path location of our files
            
            for(int i = 0; i <myFileNames.Length;i++)
            {
                textBox1.Text = textBox1.Text + Path.GetFileName(myFileNames[i]) + "\r\n"; // getFileName(separates path name from file name)
            }

        }

        String getPath()
        {
            String s = Application.StartupPath;
            int i = s.IndexOf(Application.ProductName);
            s = s.Substring(0, i + Application.ProductName.Length);
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Myfiles yourfiles
           // File.Copy(getPath() + "\\MyFiles\\FileNo1.txt", getPath() + "\\YourFiles\\YourFileNo1.txt");
            //File.Delete(getPath() + "\\YourFiles\\YourFileNo1");
            File.Move(getPath() + "\\MyFiles\\FileNo1.txt", getPath() + "\\YourFiles\\YourFileNo1.txt");

        }
    }
}
