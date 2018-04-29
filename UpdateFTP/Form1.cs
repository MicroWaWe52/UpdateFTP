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
using System.Xml.Serialization;
using System.Xml;

namespace UpdateFTP
{
    public partial class FormTDS : Form
    {
        readonly ToolTip toolTip22 = new ToolTip();
        readonly ToolTip toolTip23 = new ToolTip();
        readonly ToolTip toolTip24 = new ToolTip();
        readonly ToolTip toolTip25 = new ToolTip();
        readonly ToolTip toolTip26 = new ToolTip();
        readonly ToolTip toolTip27 = new ToolTip();
        readonly ToolTip toolTip28 = new ToolTip();
        readonly ToolTip toolTip29 = new ToolTip();
        readonly ToolTip toolTip222 = new ToolTip();
        readonly ToolTip toolTip223 = new ToolTip();
        readonly ToolTip toolTip224 = new ToolTip();

        string imgP;
        Eventii eviii = new Eventii();
        bool OnModify;
        int iM;
        readonly DataGrid dataGridView1 = new DataGrid();
        DataSet ds = new DataSet();



        public FormTDS()
        {


            InitializeComponent();
            eviii.EventiTeatroDelSegno = new List<EventoSingolo>(1);
            grab();
            Controls.Add(dataGridView1);
            var evTemp = Eventii.XMLFTP();
            if (evTemp != null)
            {
                eviii = evTemp;
            }
            ricarica();
            dataGridView1.ReadOnly = true;
            dataGridView1.Click += DataGridView1_Click;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView1.BackgroundColor = Color.AliceBlue;


        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentCell.RowNumber;
            pictureBox1.ImageLocation = eviii.EventiTeatroDelSegno[index].imgPath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {

        }

        public void ricarica()
        {

            var xml = XmlReader.Create("eventi.xml");
            File.Copy("eventi.xml", "eventitemp.xml", true);
            var fs = new FileStream("eventitemp.xml", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            try
            {
                ds = new DataSet();
                ds.ReadXml(xml);
                xml.Close();
                XmlSerializer x = new XmlSerializer(typeof(Eventii));
                eviii = (Eventii)x.Deserialize(fs);
                dataGridView1.DataSource = ds.Tables[1];
            }
            catch (Exception e)
            { }
            finally
            {

                dataGridView1.Size = new Size(772, 454);
                dataGridView1.Location = new Point(334, 80);
                dataGridView1.Refresh();
                fs.Close();
                xml.Close();

            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (imgP == null)
            {
                MessageBox.Show("Devi caricare l'immagine per poter inserire l'evento");
            }
            else
            {
                if (textBoxTitle.Text == "" || textBoxUnderTitle.Text == "" || textBoxBody.Text == "")
                {
                    MessageBox.Show("Le informazioni sull' evento non sono complete");
                }
                else

                {
                    if (OnModify)
                    {
                        OnModify = false;
                        EventoSingolo evm = new EventoSingolo(textBoxTitle.Text, textBoxUnderTitle.Text, dateTimePickerEvent.Value, textBoxBody.Text, imgP, dateTimePickerChange.Value, checkBoxNPosti.Checked, comboBoxTipo.Text);
                        eviii.EventiTeatroDelSegno.RemoveAt(iM);
                        eviii.EventiTeatroDelSegno.Insert(iM, evm);
                        XmlSerializer xmlsmp = new XmlSerializer(typeof(Eventii));
                        eviii.EventiTeatroDelSegno.Sort((x, y) => DateTime.Compare(x.dataEvento, y.dataEvento));
                        using (FileStream fs = new FileStream("eventi.xml", FileMode.Create))
                        {
                            xmlsmp.Serialize(fs, eviii);
                            fs.Close();
                        }
                        ordinaCamb();
                        dataGridView1.DataSource = ds.Tables[0];
                        ricarica();
                    }
                    else
                    {
                        EventoSingolo ev = new EventoSingolo(textBoxTitle.Text, textBoxUnderTitle.Text, dateTimePickerEvent.Value, textBoxBody.Text, imgP, dateTimePickerChange.Value, checkBoxNPosti.Checked, comboBoxTipo.Text);
                        XmlSerializer xmls = new XmlSerializer(ev.GetType());
                        var s = new StreamWriter("Evento.xml");
                        xmls.Serialize(s, ev);
                        s.Close();
                        // ev.carica(ev.imgPath);
                        File.Delete("Evento.xml");
                        MessageBox.Show("Caricamento Effetuato");
                        eviii.EventiTeatroDelSegno.Capacity += 1;
                        eviii.EventiTeatroDelSegno.Add(ev);
                        var xmlsp = new XmlSerializer(typeof(Eventii));
                        eviii.EventiTeatroDelSegno.Sort((x, y) => DateTime.Compare(x.dataEvento, y.dataEvento));
                        using (FileStream fs = new FileStream("eventi.xml", FileMode.Create))
                        {
                            xmlsp.Serialize(fs, eviii);
                        }
                        ordinaCamb();
                        ricarica();
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }

        }


        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString() };


            if (ofd.ShowDialog() != DialogResult.No)
            {


                try
                {
                    File.Copy(ofd.FileName, ofd.SafeFileName, true);
                    imgP = ofd.SafeFileName;


                    if (imgP.Length >= 15)
                    {

                        labelNameImage.Text = imgP.Substring(0, 15);
                    }
                    else
                    {

                        labelNameImage.Text = ofd.SafeFileName;
                    }
                }
                catch (Exception ec)
                {

                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.CurrentCell.RowNumber;
            EventoSingolo evM = eviii.EventiTeatroDelSegno[dataGridView1.CurrentCell.RowNumber];

            textBoxTitle.Text = evM.titolo;
            textBoxUnderTitle.Text = evM.sottotitolo;
            dateTimePickerChange.Value = evM.dataCambio;
            dateTimePickerEvent.Value = evM.dataEvento;
            textBoxBody.Text = evM.corpo;
            imgP = evM.imgPath;
            iM = dataGridView1.CurrentCell.RowNumber;
            checkBoxNPosti.Checked = evM.MoltiPosti;
            comboBoxTipo.Text = evM.tipoEvento;
            OnModify = true;



        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            eviii.EventiTeatroDelSegno.RemoveAt(dataGridView1.CurrentCell.RowNumber);

            XmlSerializer xmlsp = new XmlSerializer(typeof(Eventii));
            using (FileStream fs = new FileStream("eventi.xml", FileMode.Create))
            {
                xmlsp.Serialize(fs, eviii);
                fs.Close();
            }
            ordinaCamb();
            var cmlr = XmlReader.Create("eventi.xml", new XmlReaderSettings());
            dataGridView1.DataSource = ds.Tables[0];
            ricarica();
            cmlr.Close();
            ricarica();
        }



        private void buttonPushFtp_Click(object sender, EventArgs e)
        {
            EventoSingolo evee = new EventoSingolo();
            progressBarOnInternet.Value = 20;
            foreach (var element in eviii.EventiTeatroDelSegno)
            {
                string img = element.imgPath;
                element.ImmagineFTP(img);
            }
            progressBarOnInternet.Value = 50;
            evee.DataFtp();
            progressBarOnInternet.Value = 100;
            MessageBox.Show("Caricamento effetuato");
            progressBarOnInternet.Value = 0;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            int durationMilliseconds = 5000;
            toolTip22.Show(toolTip22.GetToolTip(buttonAdd), buttonAdd, durationMilliseconds);
            toolTip23.Show(toolTip23.GetToolTip(buttonDelet), buttonDelet, durationMilliseconds);
            toolTip24.Show(toolTip24.GetToolTip(buttonLoadImage), buttonLoadImage, durationMilliseconds);
            toolTip25.Show(toolTip25.GetToolTip(buttonModify), buttonModify, durationMilliseconds);
            toolTip26.Show(toolTip26.GetToolTip(buttonPushFtp), buttonPushFtp, durationMilliseconds);
            toolTip27.Show(toolTip27.GetToolTip(textBoxBody), textBoxBody, durationMilliseconds);
            toolTip28.Show(toolTip28.GetToolTip(textBoxTitle), textBoxTitle, durationMilliseconds);
            toolTip29.Show(toolTip29.GetToolTip(textBoxUnderTitle), textBoxUnderTitle, durationMilliseconds);
            toolTip222.Show(toolTip222.GetToolTip(dateTimePickerChange), dateTimePickerChange, durationMilliseconds);
            toolTip223.Show(toolTip223.GetToolTip(dateTimePickerEvent), dateTimePickerEvent, durationMilliseconds);
            toolTip224.Show(toolTip224.GetToolTip(pictureBox1), pictureBox1, durationMilliseconds);

        }
        void ordinaCamb()
        {
            eviii.EventiTeatroDelSegno.Sort((x, y) => DateTime.Compare(x.dataCambio, y.dataCambio));

        }


        public void grab()

        {
            toolTip22.AutoPopDelay = 5000;
            toolTip22.InitialDelay = 1000;
            toolTip22.ReshowDelay = 500;
            toolTip22.ShowAlways = true;
            toolTip22.SetToolTip(this.buttonAdd, "Aggiungi l'evento nella lista degli eventi");

            toolTip23.AutoPopDelay = 5000;
            toolTip23.InitialDelay = 1000;
            toolTip23.ReshowDelay = 500;
            toolTip23.ShowAlways = true;
            toolTip23.SetToolTip(this.buttonDelet, "Elimina l'evento selezionato");

            toolTip24.AutoPopDelay = 5000;
            toolTip24.InitialDelay = 1000;
            toolTip24.ReshowDelay = 500;
            toolTip24.ShowAlways = true;
            toolTip24.SetToolTip(this.buttonLoadImage, "Carica un immagine dal tuo computer 16:9");

            toolTip25.AutoPopDelay = 5000;
            toolTip25.InitialDelay = 1000;
            toolTip25.ReshowDelay = 500;
            toolTip25.ShowAlways = true;
            toolTip25.SetToolTip(this.buttonModify, "Modifica l'evento ricaricandolo a sinistra");

            toolTip26.AutoPopDelay = 5000;
            toolTip26.InitialDelay = 1000;
            toolTip26.ReshowDelay = 500;
            toolTip26.ShowAlways = true;
            toolTip26.SetToolTip(this.buttonPushFtp, "Pubblicazione online della lista completa eventi");

            toolTip27.AutoPopDelay = 5000;
            toolTip27.InitialDelay = 1000;
            toolTip27.ReshowDelay = 500;
            toolTip27.ShowAlways = true;
            toolTip27.SetToolTip(this.textBoxBody, "Corpo dell' evento (mandare a capo ogni volta che finisce lo spazio)");

            toolTip28.AutoPopDelay = 5000;
            toolTip28.InitialDelay = 1000;
            toolTip28.ReshowDelay = 500;
            toolTip28.ShowAlways = true;
            toolTip28.SetToolTip(this.textBoxTitle, "Titolo dell' evento");

            toolTip29.AutoPopDelay = 5000;
            toolTip29.InitialDelay = 1000;
            toolTip29.ReshowDelay = 500;
            toolTip29.ShowAlways = true;
            toolTip29.SetToolTip(this.textBoxUnderTitle, "Sottotitolo dell' evento: in grassetto, dello stesso carattere del corpo");

            toolTip222.AutoPopDelay = 5000;
            toolTip222.InitialDelay = 1000;
            toolTip222.ReshowDelay = 500;
            toolTip222.ShowAlways = true;
            toolTip222.SetToolTip(this.dateTimePickerChange, "quando l'evento andrà in pagina principale ");

            toolTip223.AutoPopDelay = 5000;
            toolTip223.InitialDelay = 1000;
            toolTip223.ReshowDelay = 500;
            toolTip223.ShowAlways = true;
            toolTip223.SetToolTip(this.dateTimePickerEvent, "Data in cui si terrà l'evento scelto");

            toolTip224.AutoPopDelay = 5000;
            toolTip224.InitialDelay = 1000;
            toolTip224.ReshowDelay = 500;
            toolTip224.ShowAlways = true;
            toolTip224.SetToolTip(this.pictureBox1, "Anteprima immagine evento");



        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            foreach (var element in eviii.EventiTeatroDelSegno)
            {
                string img = element.imgPath;
                File.Delete(img);
            }
        }
    }
}
