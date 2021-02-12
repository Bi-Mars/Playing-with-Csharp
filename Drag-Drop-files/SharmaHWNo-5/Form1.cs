using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharmaHWNo_5
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
            cpFile.Checked = true;
            myFileNames = Directory.GetFiles(s); // gets all files and returns array of files --> s is the path location of our files

            for (int i = 0; i < myFileNames.Length; i++)
            {
                LSBox1.Items.Add(Path.GetFileName(myFileNames[i])); // getFileName(separates path name from file name)
            }

            s = getPath() + "\\YourFiles";
            myFileNames = Directory.GetFiles(s);

            for (int i = 0; i < myFileNames.Length; i++)
            {
                LSBox2.Items.Add(Path.GetFileName(myFileNames[i])); // getFileName(separates path name from file name)
            }

        }

        String getPath()
        {
            String s = Application.StartupPath;
            int i = s.IndexOf(Application.ProductName);
            s = s.Substring(0, i + Application.ProductName.Length);
            return s;
        }

        private void LSBox1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                LSBox1.Items.Add(str);
            }
        }

        private void LSBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void LSBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                LSBox2.Items.Add(str);
            }
        }

        private void LSBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void LSBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LSBox1.AllowDrop = false;
            LSBox2.AllowDrop = true;
            int index = LSBox1.IndexFromPoint(e.X, e.Y);
            if (LSBox1.SelectedItem == null || index == -1)
            {
                return;
            }

            string s = LSBox1.Items[index].ToString();
            DragDropEffects dde = DoDragDrop(s, DragDropEffects.All);

            if (mvFile.Checked)
            {
                try
                {
                    File.Move(getPath() + "\\MyFiles\\" + s, getPath() + "\\YourFiles\\" + s);

                }
                 catch (IOException)
                {
                    MessageBox.Show("File Already Exit");
                }
            }
            else if (cpFile.Checked)
            {
                try
                {
                    File.Copy(getPath() + "\\MyFiles\\" + s, getPath() + "\\YourFiles\\" + s);

                }
                catch (IOException)
                {
                    MessageBox.Show("File Already Exit");
                }
                //File.Delete(getPath() + "\\YourFiles\\YourFileNo1");
            }

            if (dde == DragDropEffects.All)
            {
                LSBox1.Items.RemoveAt(LSBox1.IndexFromPoint(e.X, e.Y));
            }
        }

        private void LSBox2_MouseDown(object sender, MouseEventArgs e)
        {
            LSBox1.AllowDrop = true;
            LSBox2.AllowDrop = false;
            if (LSBox2.SelectedItem == null)
            {
                return;
            }

            int index = LSBox2.IndexFromPoint(e.X, e.Y);
            string s = LSBox2.Items[index].ToString();
            DragDropEffects dde = DoDragDrop(s, DragDropEffects.All);

            if (mvFile.Checked)
            {
                try
                {
                    File.Move(getPath() + "\\YourFiles\\" + s, getPath() + "\\MyFiles\\" + s);
                }catch(IOException)
                {
                    MessageBox.Show("File Already Exit");
                }
                
            }
            else if (cpFile.Checked)
            {
                try
                {
                    File.Copy(getPath() + "\\YourFiles\\" + s, getPath() + "\\MyFiles\\" + s);

                }catch(IOException)
                {
                    MessageBox.Show("File Already Exit");
                }
                //File.Delete(getPath() + "\\YourFiles\\YourFileNo1");
            }

            if (dde == DragDropEffects.All)
            {
                LSBox2.Items.RemoveAt(LSBox2.IndexFromPoint(e.X, e.Y));
            }
        }
    }
}
