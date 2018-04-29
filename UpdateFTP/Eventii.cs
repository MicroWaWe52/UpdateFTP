/*
 * Created by SharpDevelop.
 * User: LOL
 * Date: 25/01/2018
 * Time: 20.03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using  System.Xml.Serialization;

namespace UpdateFTP
{
	/// <summary>
	/// Description of Eventii.
	/// </summary>
	
	public class Eventii
	{  
		public  Eventii()
		{
		
		}
	    public static Eventii XMLFTP()
	    {
	        //FileStream file = File.Create("eventi.xml");
	        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Eventii));
	        Eventii ev = null;
	        try
	        {

	            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.teatrotse.com/teatrotse.com/Evento/evento.xml");
	            request.Method = WebRequestMethods.Ftp.DownloadFile;
	            request.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
	            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
	            Stream responseStream = response.GetResponseStream();
	            StreamReader reader = new StreamReader(responseStream);
	            File.WriteAllText("eventi.xml", reader.ReadToEnd());
	            using (FileStream file = new FileStream("eventi.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
	            {
	                ev = (Eventii)xmlSerializer.Deserialize(file);
	            }

	            foreach (var img in ev.EventiTeatroDelSegno)
	            {
	                EventoSingolo.GetImg(img.imgPath);
	            }
	        }
	        catch (Exception)
	        {

	        }
	        return ev;
	    }


        public List<EventoSingolo> EventiTeatroDelSegno;
		 
	}
}
