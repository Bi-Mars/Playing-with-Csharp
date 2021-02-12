using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form2 : Form
    {
        string fresult;
        public Form2()
        {
            InitializeComponent();
            label1.Width = this.ClientSize.Width; 
         

        }

        //property that returns what button is clicked?
        public String Result
            {
                get { return fresult; }
                set { fresult = value; } // not needed
            }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fresult = "Save";
            
            this.Close();
        }

        private void btnDontSave_Click(object sender, EventArgs e)
        {
            fresult = "DontSave";
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fresult = "Cancel";
            this.Close();
        }
    }
}
