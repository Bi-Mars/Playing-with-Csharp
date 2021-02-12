using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using network
using System.Net.Sockets; // create sockets
using System.Net;
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {
       // private TcpListener server; // listen to somebody to connects
        private TcpClient client;

        private NetworkStream ns; // IO --> read and write using network stream
        StreamReader sr; // 
        StreamWriter sw;
       // Boolean open; // can i take other connection?
        String s;

        public Form1()
        {
            InitializeComponent();

            client = new TcpClient();
            client.Connect(IPAddress.Loopback, 18888);

            ns = client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
          //  open = true; // connection is false

            bgSocket.RunWorkerAsync(); // listen
            //server.Start();

            //run in the background 
        }

        private void bgSocket_DoWork(object sender, DoWorkEventArgs e)
        {
            s = sr.ReadLine();
        }

        private void bgSocket_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblResponse.Text = lblResponse.Text + s;
            bgSocket.RunWorkerAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sw.WriteLine(txtMessage.Text + "\n");
            txtMessage.Text = "";
            sw.Flush();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
         
                //close everything
                sw.Close();
                sr.Close();
                ns.Close();
                client.Close();
        }
    }
}
