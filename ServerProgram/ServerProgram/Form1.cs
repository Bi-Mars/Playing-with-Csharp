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
using System.Threading;

namespace ServerProgram
{
    public partial class Form1 : Form
    {
        private TcpListener server; // listen to somebody to connects
        private TcpClient client;

        private NetworkStream ns; // IO --> read and write using network stream
        StreamReader sr; // 
        StreamWriter sw;
        Boolean open; // can i take other connection?
        String s;

        public Form1()
        {
            InitializeComponent();
            //port number 18888
            constructorRebuilt();
           

        }

        void constructorRebuilt()
        {
            try // try becoming client if throws error the become server
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, 18888);
                ns = client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                //  open = true; // connection is false
                bgSocket.RunWorkerAsync(); // listen
                open = true; // client is connected
                this.Text = "Client"; // form name
            }
            catch (Exception ee)
            {
                server = new TcpListener(IPAddress.Loopback, 18888); // who you wanna connect to? .Loopback --> talk to same computer
                open = false; // connection is false

                bgConnect.RunWorkerAsync(); // listen
                server.Start();
                this.Text = "Server";
            }
            //run in the background 
        }
        private void bgConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            client = server.AcceptTcpClient(); // in background accept the client request
        }

        //connection.
        private void bgConnect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ns = client.GetStream();
            sr = new StreamReader(ns); 
            sw = new StreamWriter(ns);
            open = true; // we have connection 
            server.Stop(); // stops connection because we only have 1 conncetion
            bgSocket.RunWorkerAsync(); // after connection has been established, listen to the client
        }

        private void bgSocket_DoWork(object sender, DoWorkEventArgs e)
        {
            // while reading is error is encountered 
            try
            {
                s = sr.ReadLine();
            } catch(Exception ee)
            {
                //close everything
                sw.Close();
                sr.Close();
                ns.Close();
                client.Close();
                server.Stop();
                open = false;
            }
        }

        private void bgSocket_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(s == "Quit")
            {
                this.Close();
                return;
            }

            if(!open) // if no connection
            {
                return;
            }
            //set a selection for a change of color
            //change the color. Our selection will be at the end of the current text
            //change color and then add the new text

            richResponse.SelectionStart = richResponse.TextLength; // starting position
            richResponse.SelectionLength = 0;

            if(this.Text == "Server")
            {
                richResponse.SelectionColor = Color.Red;
                richResponse.AppendText("Sent from Client:  " + s + "    Sent at: " + DateTime.Now.ToString() + "\n" );
               // richResponse.Text = richResponse.Text + "Sent from Client: " + s + "\n"; // this text gets transmitted
            }
            else
            {
                richResponse.SelectionColor = Color.Green;
                richResponse.AppendText("Sent from Server:   " + s + "    Sent at: " + DateTime.Now.ToString() + "\n");
               // richResponse.Text = richResponse.Text + "Sent from Server: " + s + "\n";
            }
           
            bgSocket.RunWorkerAsync(); // listen again
            
        }

     /*   private void btnSend_Click(object sender, EventArgs e)
        {
            if(open)
            {
                lblResponse.Text = lblResponse.Text + "Sent from " + this.Text + " :" + txtMessage.Text + "\n";
                sw.WriteLine(txtMessage.Text);
                txtMessage.Text = "";
                sw.Flush(); // flush the buffer writer
            }
            
        }
        */

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(open == true)
            {
                sw.WriteLine("Quit");
                sw.Close(); // only opens when connection has been established
                sr.Close();
                ns.Close();
                client.Close();

            }

            // server.Stop();
            bgConnect.Dispose(); // stop the process
            bgSocket.Dispose();
            open = false;
        }

        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {

            if(!open)
            {
                return;
            }
            if(e.KeyCode == Keys.Return) // keyEventArgs will tell what key is entered
            {
                richResponse.SelectionStart = richResponse.TextLength;
                richResponse.SelectionLength = 0;

                if(this.Text == "Client")
                {
                    richResponse.SelectionColor = Color.Red;
                   richResponse.AppendText("Sent from " + this.Text + " :" + txtMessage.Text + "    Sent at: " + DateTime.Now.ToString() + "\n");
                }

                else
                {
                    richResponse.SelectionColor = Color.Green;
                    richResponse.AppendText("Sent from " + this.Text + " :" + txtMessage.Text + "    Sent at: " + DateTime.Now.ToString() + "\n");
                }
                 //   richResponse.Text = richResponse.Text + "Sent from " + this.Text + " :" + txtMessage.Text + "\n";
                    sw.WriteLine(txtMessage.Text);
                    txtMessage.Text = "";
                    sw.Flush(); // flush the buffer writer
                
                  
            }
        }

        // close file all the resources 
    }
}
