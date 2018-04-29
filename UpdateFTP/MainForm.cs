/*
 * Created by SharpDevelop.
 * User: LOL
 * Date: 24/01/2018
 * Time: 23.50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Net;

namespace UpdateFTP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{ 	//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			
		}
			
		 void Button1Click(object sender, EventArgs e)
        { // Get the object used to communicate with the server.  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.teatrotse.com/teatrotse.com/ftpdir/");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            MessageBox.Show(reader.ReadToEnd());

           

            reader.Close();
            response.Close();


        }

        public void DataFtp()
		{
			   FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.teatrotse.com/teatrotse.com/ftpdir/data.txt");
		       request.Method = WebRequestMethods.Ftp.UploadFile;
	     	   request.Credentials= new NetworkCredential("3835532@aruba.it","Teatro09127");
          	    //Caricamento Date          	   
          	    var dateStream =new StreamReader("data.txt");
                byte [] dateftp = Encoding.UTF8.GetBytes(dateStream.ReadToEnd());
                dateStream.Close();
          	    request.ContentLength=dateftp.Length;
                Stream requestStream = request.GetRequestStream();   
                requestStream.Write(dateftp, 0, dateftp.Length);
                requestStream.Close();  
                MessageBox.Show("Data Caricata");		
		
		}
		public void ImmagineFTP()
		{
					
				FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.teatrotse.com/teatrotse.com/ftpdir/evento.png");
		        request.Method = WebRequestMethods.Ftp.UploadFile;
		        request.Credentials= new NetworkCredential("3835532@aruba.it","Teatro09127");
          	    //Caricamento Date          	   
          	    var imgStream =new FileStream("evento.png",FileMode.Open);
          	   byte[]buffer=new byte[imgStream.Length];
          	   imgStream.Read(buffer,0,buffer.Length);
          	   imgStream.Close();
          	   Stream requestStream = request.GetRequestStream();
               requestStream.Write(buffer, 0, buffer.Length);
               requestStream.Close();               
               MessageBox.Show("Immagine caricata");	
		}
		   	
		   
		}
		
		
		}
	

