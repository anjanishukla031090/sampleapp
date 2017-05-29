using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmDownload : Form
    {
        WebClient wc = new WebClient();
      
        public frmDownload()
        {
        InitializeComponent();
        txtname.Visible = false;
        lblname.Visible=false;
        txtpass.Visible = false;
        lblpass.Visible = false;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {     
            try
            {
                String RemoteFtpPath = txtlink.Text;
                string[] Arr = RemoteFtpPath.Split(':');
                
                if (Arr[0] == "http"|| Arr[0] == "https" )
                {
                    if (rbtHTTP.Checked == true)
                    {
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
                        Uri imageUrl = new Uri(RemoteFtpPath);
                        wc.DownloadFileAsync(imageUrl, "test.gif");
                    }
                    else
                    {
                        MessageBox.Show("http link is not allowed.");
                    }
                }
                else if (Arr[0] == "ftp")
                    {
                        if (rbtFTP.Checked == true)
                        {
                            String LocalDestinationPath = "D:\\test.png";
                            String Username = txtname.Text;
                            String Password = txtpass.Text;
                            Boolean UseBinary = true; // use true for .zip file or false for a text file
                            Boolean UsePassive = false;

                            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(RemoteFtpPath);
                            request.Method = WebRequestMethods.Ftp.DownloadFile;
                            request.KeepAlive = true;
                            request.UsePassive = UsePassive;
                            request.UseBinary = UseBinary;

                            request.Credentials = new NetworkCredential(Username, Password);

                            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                            Stream responseStream = response.GetResponseStream();
                            StreamReader reader = new StreamReader(responseStream);

                            using (FileStream writer = new FileStream(LocalDestinationPath, FileMode.Create))
                            {

                                long length = response.ContentLength;
                                int bufferSize = 2048;
                                int readCount;
                                byte[] buffer = new byte[2048];

                                readCount = responseStream.Read(buffer, 0, bufferSize);
                                while (readCount > 0)
                                {
                                writer.Write(buffer, 0, readCount);
                                readCount = responseStream.Read(buffer, 0, bufferSize);
                                }
                            }
                            reader.Close();
                            response.Close();
                            MessageBox.Show("File downloaded completed.");
                        }
                        else
                        {
                            MessageBox.Show("ftp link is not allowed.");
                        }
                }
            }
            catch (Exception ex) { }
        }

        public void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded completed.");
        }

        private void btnclear(object sender, EventArgs e)
        {
            if (txtlink.Text.Length > 0)
            {
                txtlink.Text = "";
            }
            else
            {
                MessageBox.Show("Already clear!");
                return;
            }
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void rbtHTTP_CheckedChanged(object sender, EventArgs e)
        {
        txtname.Visible = false;
        lblname.Visible = false;
        txtpass.Visible = false;
        lblpass.Visible = false;
        }

        private void rbtFTP_CheckedChanged(object sender, EventArgs e)
        {
        txtname.Visible = true;
        lblname.Visible = true;
        txtpass.Visible = true;
        lblpass.Visible = true;
        } 
    }
}
