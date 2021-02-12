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

namespace Notepad
{
    public partial class Form1 : Form
    {
        private String CurrentFileName;
        private Boolean hasChanged;
        ContextMenu cm;
        //Form2 fm2;
        public Form1()
        {
            InitializeComponent();
            // set the height and width of textbox to the form size
            txtEdit.Width = this.ClientSize.Width;
            txtEdit.Height = this.ClientSize.Height - 27; // -27 because some space is used by tool strip menu

            cm = new ContextMenu(); // context menu: When you right click
            cm.MenuItems.Add("Cut", new EventHandler(mnuCut_Click)); // whenever we get Cut, this executes the mnuCut_Click event
            cm.MenuItems.Add("Copy", new EventHandler(mnuCopy_Click));
            cm.MenuItems.Add("Paste", new EventHandler(pasteToolStripMenuItem_Click));
            cm.MenuItems.Add("Delete", new EventHandler(deleteToolStripMenuItem_Click));
            txtEdit.ContextMenu = cm;


            hasChanged = false;
            CurrentFileName = "";
        //    justName = "";

        }

       

      //  Everytime form size changes
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            txtEdit.Width = this.ClientSize.Width;
            txtEdit.Height = this.ClientSize.Height - 27;
        } // size changed


        //get path 
        string getPath()
        {
            String s;
            int i;
            s = Application.StartupPath;
            i = s.IndexOf(Application.ProductName);
            s = s.Substring(0, i + Application.ProductName.Length + 1);
            return s;
        } // get path

     
        // it returns true if cancel button of form2 is pressed 
        Boolean CancelBoolean()
        {
            Boolean c = false;

            // if text in text-box has changed 
            if (hasChanged) 
            { 
               Form2 fm2 = new Form2();
                fm2.ShowDialog(); //fm2.Show(); show and showdialog

                if (fm2.Result == "Cancel") // content of textbox change
                {
                    c = true;
                }
                else if (fm2.Result == "DontSave")
                {
                    txtEdit.Text = "";
                }
                else if (fm2.Result == "Save")
                {
                    mnuSave.PerformClick(); // save
                    //clear the text =box
                    txtEdit.Text = "";

                }

            } // end if(hasChanged)
            return c;
        } // cancel button


        //Open button
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // is cancel button is pressed, then do nothing
            if (CancelBoolean()) return;

            dlgOpen.InitialDirectory = getPath();
            //dropdown: first text file then all files
            dlgOpen.Filter = " Text Files| *.txt|All Files| *.*";

            string path, fileName;
            //input output stream
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);
                txtEdit.Text = sr.ReadToEnd();
                sr.Close(); // always close the stream reader
                CurrentFileName = dlgOpen.FileName;
                path = CurrentFileName;
               
                int start = path.LastIndexOf(("\\")) + 1;
                int end = path.LastIndexOf(("."));

                fileName = path.Substring(start, end - start);
                //  fileName = fileName.Substring(fileName.First((".")));
                this.Text = fileName + " - Notepad";
                hasChanged = false;
            }

            File.WriteAllText(CurrentFileName, txtEdit.Text);

        }

        //if font is clicked
        private void MenuFont_Click(object sender, EventArgs e)
        {
            if(dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtEdit.Font = dlgFont.Font;
            }
           
        }
        
        //if printer is clicked
        private void printer_Click(object sender, EventArgs e)
        {
            if (dlgPrint.ShowDialog() == DialogResult.OK)
            {
                Docprint.Print();
            }
        }

        private void Docprint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtEdit.Text, txtEdit.Font, Brushes.Black, 10, 25); // width, height
        }

        //if cut is clicked 
        private void mnuCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEdit.SelectedText); // selected text = highlight text
            // cut means removing the highlighted text
            txtEdit.SelectedText = ""; // add empty string

        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEdit.SelectedText);
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clipboard.SetText(txtEdit.SelectedText);
            
           string text = Clipboard.GetText();
            txtEdit.Text = txtEdit.Text.Insert(txtEdit.SelectionStart, text);
        }

        private void mnyPageSetup_Click(object sender, EventArgs e)
        {
            dlgPageSetup.PageSettings = Docprint.DefaultPageSettings;
            dlgPageSetup.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// exit

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            dlgSaveAs.Filter = " Text Files| *.txt|All Files| *.*";

            //check result of dialog box
            if (dlgSaveAs.ShowDialog() == DialogResult.OK) 
            {
                string path, fileName;
                File.WriteAllText(dlgSaveAs.FileName, txtEdit.Text);
                CurrentFileName = dlgOpen.FileName;
                path = dlgSaveAs.FileName;
                int start = path.LastIndexOf(("\\")) + 1;
                int end = path.LastIndexOf(("."));

                fileName = path.Substring(start, end - start);
                //  fileName = fileName.Substring(fileName.First((".")));
                this.Text = fileName + " - Notepad";
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
           //dlgOpen.InitialDirectory = getPath();
            //dropdown: first text file then all files
            dlgSaveAs.Filter = " Text Files| *.txt|All Files| *.*";
            string path, fileName;
            
            if (CurrentFileName == "")
            {
                if (dlgSaveAs.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlgSaveAs.FileName, txtEdit.Text);
                    CurrentFileName = dlgSaveAs.FileName;
                    path = dlgSaveAs.FileName;
                    int start = path.LastIndexOf(("\\")) + 1;
                    int end = path.LastIndexOf(("."));
                    
                    fileName = path.Substring(start, end-start);
                  //  fileName = fileName.Substring(fileName.First((".")));
                    this.Text = fileName + " - Notepad";
                    hasChanged = false;

                   // System.IO.File.WriteAllText(CurrentFileName, txtEdit.Text);
                }
            }
            else
            {
                File.WriteAllText(dlgSaveAs.FileName, txtEdit.Text);
                hasChanged = false;

            }


            //input output stream


            //File.WriteAllText(CurrentFileName, txtEdit.Text);
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if(hasChanged)
            {
                CancelBoolean();
            }
            else
            {
                txtEdit.Text = "";
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wordWrapToolStripMenuItem.Checked == true)
            {
                txtEdit.WordWrap = true;
            }
            else
            {
                txtEdit.WordWrap = false;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEdit.SelectAll();
            txtEdit.Focus();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEdit.Text = txtEdit.Text + DateTime.Now.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Boolean hold = true;
            if(hasChanged)
            {
              hold = CancelBoolean();
                Console.WriteLine(hold);
            }
            if(hold != true)
            {
                Console.WriteLine(hold);
              //  this.Close();
            }
            else
            {
                return;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(txtEdit.Text == "")
            {
                mnuCopy.Enabled = false;
                mnuCut.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
               // cm.Enabled = false;

            }

            else
            {
                mnuCopy.Enabled = true;
                mnuCut.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEdit.SelectedText = "";
        }
    }
}
