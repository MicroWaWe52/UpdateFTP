﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;

namespace UpdateFTP
{
    /// <summary>
    /// Description of ClassEvento.
    /// </summary>
    public class EventoSingolo
    {
        public string titolo;
        public string sottotitolo;
        public DateTime dataEvento;
        public string corpo;
        public string imgPath;
        static int eventNumber;
        public bool MoltiPosti;
        public string tipoEvento;



        public EventoSingolo()
        {

        }
        public EventoSingolo(string titolo, string sottotitolo, DateTime dataEvento, string corpo, string imgPath, DateTime dataCambio, bool posti, string tipo)
        {
            this.titolo = titolo;
            this.sottotitolo = sottotitolo;
            this.dataEvento = dataEvento;
            this.imgPath = imgPath;
            this.dataCambio = dataCambio;
            this.corpo = corpo;
            MoltiPosti = posti;
            tipoEvento = tipo;
        }



        public DateTime dataCambio;

        public void carica(string ip)
        {
            ImmagineFtp(ip);
            DataFtp();

        }
        public void DataFtp()
        {

            var request = (FtpWebRequest)WebRequest.Create("ftp://www.teatrotse.com/teatrotse.com/Evento/Evento.xml");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
            //Caricamento Date          	   
            var dateStream = new StreamReader("Eventi.xml");
            var dateftp = Encoding.UTF8.GetBytes(dateStream.ReadToEnd());
            dateStream.Close();
            request.ContentLength = dateftp.Length;
            var requestStream = request.GetRequestStream();
            requestStream.Write(dateftp, 0, dateftp.Length);
            requestStream.Close();
        }


        public void ImmagineFtp(string iP)
        {

            var request = (FtpWebRequest)WebRequest.Create("ftp://www.teatrotse.com/teatrotse.com/Evento/" + imgPath);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
            //Caricamento Date      

            var imgStream = new FileStream(iP, FileMode.Open);
            byte[] buffer = new byte[imgStream.Length];
            imgStream.Read(buffer, 0, buffer.Length);
            imgStream.Close();

            imgStream.Dispose();
            var requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();
            requestStream.Dispose();

        }

       
       public static void GetImg(string imgName)
        {
            var outputStream = new FileStream(imgName, FileMode.Create);
            var request = (FtpWebRequest)WebRequest.Create($"ftp://www.teatrotse.com/teatrotse.com/Evento/{imgName}");
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential("3835532@aruba.it", "Teatro09127");
            var response = (FtpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            const int bufferSize = 102400;
            var buffer = new byte[bufferSize];

            var readCount = responseStream.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                outputStream.Write(buffer, 0, readCount);
                readCount = responseStream.Read(buffer, 0, bufferSize);
            };
            responseStream.Close();
            outputStream.Close();
            response.Close();
        }

    }



}