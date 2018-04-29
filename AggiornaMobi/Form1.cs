using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;
using System.IO;

namespace AggiornaMobi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinSCP.SessionOptions wse = new WinSCP.SessionOptions()
            {
                FtpMode = FtpMode.Active,
                UserName = "3835532@aruba.it",
                Password = "Teatro09127",
                HostName = "ftp.teatrotse.com",
                Protocol = Protocol.Ftp

            };
            Session s=new Session();
            s.Open(wse);
            Directory.CreateDirectory("Project");
            s.GetFiles("/mobi", "Project", false);
        }
    }
}
