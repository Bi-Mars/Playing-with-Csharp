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
using System.Net;


namespace InternetPlay
{
    public partial class Form1 : Form
    {
        
      
        public Form1()
        {
            InitializeComponent();

            // get the files from computer:
            String s;
            s = getPath(); //  + "\\MyFiles";

            String[] myFileNames;
            //cpFile.Checked = true;
            myFileNames = Directory.GetFiles(s); // gets all files and returns array of files --> s is the path location of our files

            for (int i = 0; i < myFileNames.Length; i++)
            {
                lbRemote.Items.Add(Path.GetFileName(myFileNames[i])); // getFileName(separates path name from file name)
            }

        }

       void refresh()
        {
            // get the files from computer:
            String s;
            s = getPath(); //  + "\\MyFiles";

            String[] myFileNames;
            //cpFile.Checked = true;
            myFileNames = Directory.GetFiles(s); // gets all files and returns array of files --> s is the path location of our files
            lbRemote.Items.Clear();
            for (int i = 0; i < myFileNames.Length; i++)
            {
                lbRemote.Items.Add(Path.GetFileName(myFileNames[i])); // getFileName(separates path name from file name)
            }


            //get files from Server

            FtpWebRequest request;
            //send request to URL and cast into FTP
            request = (FtpWebRequest)WebRequest.Create("ftp://cs-is.wvutech.edu/"); // ftp: port 421
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            //request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(usrname.Text, usrpass.Text); // username and password
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string str;
            lbServer.Items.Clear();
            while (!reader.EndOfStream) // show it in textbox
            {
                str = reader.ReadLine();
                lbServer.Items.Add(str);
            }

        }

        // UPLOAD
        void Upload(string fileName)
        {
            FtpWebRequest request;
            Stream requestStream;
            byte[] fileContents;
            StreamReader sr; //read from data file
            string s = fileName;

            //send request to URL and cast into FTP
            request = (FtpWebRequest)WebRequest.Create("ftp://cs-is.wvutech.edu/" + s); // ftp: port 421

            //  request.Method = WebRequestMethods.Ftp.ListDirectoryDetails; // returns list of directory from CS server

            //  request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(usrname.Text,usrpass.Text); // username and password

            //response = (FtpWebResponse) request.GetResponse();

            sr = new StreamReader(getPath() + s); // path + file name
            fileContents = Encoding.UTF8.GetBytes(sr.ReadToEnd());
            sr.Close();


            request.ContentLength = fileContents.Length;
            requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);

            refresh();
        
        }
        void DownloadData(string file)
            {
            FtpWebRequest request;
            FtpWebResponse response;
            Stream responseStream;
            StreamReader reader;
          string path = getPath() + file;
            


            request = (FtpWebRequest) WebRequest.Create("ftp://cs-is.wvutech.edu/" + file);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(usrname.Text, usrpass.Text);

            response = (FtpWebResponse)request.GetResponse();
            responseStream = response.GetResponseStream();
            reader = new StreamReader(responseStream);

            
                if(!File.Exists(path))
               
                {

                StreamWriter sw = new StreamWriter(File.Create(getPath() + file));
                // Create a file to write to.
                //while (!reader.EndOfStream)
                   // {
                        sw.Write(reader.ReadToEnd());
                    //}
                sw.Flush();
                sw.Close();
            }

            refresh();

            reader.Close();
            responseStream.Close();

        }

        string getPath()
        {
            string s;
            s = Application.StartupPath;
            int i = s.IndexOf(Application.ProductName);
            s = s.Substring(0, i + Application.ProductName.Length + 1);
            return s;
        }

        private void lbRemote_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                lbRemote.Items.Add(str);
            }
        }

        private void lbServer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                lbServer.Items.Add(str);
            }
        }

        private void lbRemote_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbServer_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbRemote_MouseDown(object sender, MouseEventArgs e)
        {
            lbRemote.AllowDrop = false;
            lbServer.AllowDrop = true;
            int index = lbRemote.IndexFromPoint(e.X, e.Y);
            if (lbRemote.SelectedItem == null || index == -1)
            {
                return;
            }

            string s = lbRemote.Items[index].ToString();
            DragDropEffects dde = DoDragDrop(s, DragDropEffects.All);

            try
            {
                
                    Upload(s);
                 
            }
            catch (IOException)
            {
                MessageBox.Show("File Already Exist");
            }

            if (dde == DragDropEffects.All)
            {
                lbRemote.Items.RemoveAt(lbRemote.IndexFromPoint(e.X, e.Y));
            }
        }

        private void lbServer_MouseDown(object sender, MouseEventArgs e)
        {
            lbRemote.AllowDrop = true;
            lbServer.AllowDrop = false;

            int index = lbServer.IndexFromPoint(e.X, e.Y);
            if (lbServer.SelectedItem == null || index == -1)
            {
                return;
            }
            string s = lbServer.Items[index].ToString();
            DragDropEffects dde = DoDragDrop(s, DragDropEffects.All);

            try
            {
                
                    DownloadData(s);
                
                
            }
            catch (IOException)
            {
                MessageBox.Show("File Already Exit");
            }

            if (dde == DragDropEffects.All)
            {
                lbServer.Items.RemoveAt(lbServer.IndexFromPoint(e.X, e.Y));
            }

        }

        private void usrpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //send request to URL and cast into FTP
                /*  request = (FtpWebRequest)WebRequest.Create("ftp://cs-is.wvutech.edu/"); // ftp: port 421
                  request.Method = WebRequestMethods.Ftp.ListDirectory;
                  //request.Method = WebRequestMethods.Ftp.DownloadFile;
                  request.Credentials = new NetworkCredential(usrname.Text, usrpass.Text); // username and password
                  FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                  Stream responseStream = response.GetResponseStream();
                  StreamReader reader = new StreamReader(responseStream);
                  string str;

                  while (!reader.EndOfStream) // show it in textbox
                  {
                      str = reader.ReadLine();
                      lbServer.Items.Add(str);
                  }
                  */
                refresh();
            }
        }
    }
}
