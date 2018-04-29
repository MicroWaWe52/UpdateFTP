namespace UpdateFTP
{
    partial class FormTDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTDS));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxUnderTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.dateTimePickerChange = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNameImage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.buttonPushFtp = new System.Windows.Forms.Button();
            this.progressBarOnInternet = new System.Windows.Forms.ProgressBar();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBody = new System.Windows.Forms.RichTextBox();
            this.checkBoxNPosti = new System.Windows.Forms.CheckBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(15, 562);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(266, 27);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Carica";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(15, 63);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(268, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxUnderTitle
            // 
            this.textBoxUnderTitle.Location = new System.Drawing.Point(15, 112);
            this.textBoxUnderTitle.Name = "textBoxUnderTitle";
            this.textBoxUnderTitle.Size = new System.Drawing.Size(268, 20);
            this.textBoxUnderTitle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sottotitolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Corpo";
            // 
            // dateTimePickerEvent
            // 
            this.dateTimePickerEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerEvent.CustomFormat = "MMMMdd, yyyy | HH:mm";
            this.dateTimePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEvent.Location = new System.Drawing.Point(15, 161);
            this.dateTimePickerEvent.Name = "dateTimePickerEvent";
            this.dateTimePickerEvent.Size = new System.Drawing.Size(268, 20);
            this.dateTimePickerEvent.TabIndex = 11;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadImage.Location = new System.Drawing.Point(15, 462);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(123, 30);
            this.buttonLoadImage.TabIndex = 13;
            this.buttonLoadImage.Text = "Carica Immagine";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // dateTimePickerChange
            // 
            this.dateTimePickerChange.CustomFormat = "MMMMdd, yyyy | HH:mm";
            this.dateTimePickerChange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChange.Location = new System.Drawing.Point(16, 522);
            this.dateTimePickerChange.Name = "dateTimePickerChange";
            this.dateTimePickerChange.Size = new System.Drawing.Size(265, 20);
            this.dateTimePickerChange.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data Cambiamento ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Carica Un Nuovo Evento";
            // 
            // labelNameImage
            // 
            this.labelNameImage.AutoEllipsis = true;
            this.labelNameImage.AutoSize = true;
            this.labelNameImage.Location = new System.Drawing.Point(144, 471);
            this.labelNameImage.Name = "labelNameImage";
            this.labelNameImage.Size = new System.Drawing.Size(103, 13);
            this.labelNameImage.TabIndex = 17;
            this.labelNameImage.Text = "Nome dell\' immagine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gestione Degli Eventi";
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(316, 529);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(226, 27);
            this.buttonModify.TabIndex = 19;
            this.buttonModify.Text = "Modifica";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 25;
            // 
            // buttonDelet
            // 
            this.buttonDelet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelet.Location = new System.Drawing.Point(316, 562);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(226, 27);
            this.buttonDelet.TabIndex = 26;
            this.buttonDelet.Text = "Elimina";
            this.buttonDelet.UseVisualStyleBackColor = false;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // buttonPushFtp
            // 
            this.buttonPushFtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPushFtp.Location = new System.Drawing.Point(548, 562);
            this.buttonPushFtp.Name = "buttonPushFtp";
            this.buttonPushFtp.Size = new System.Drawing.Size(540, 27);
            this.buttonPushFtp.TabIndex = 28;
            this.buttonPushFtp.Text = "Pubblica Online";
            this.buttonPushFtp.UseVisualStyleBackColor = true;
            this.buttonPushFtp.Click += new System.EventHandler(this.buttonPushFtp_Click);
            // 
            // progressBarOnInternet
            // 
            this.progressBarOnInternet.Location = new System.Drawing.Point(548, 529);
            this.progressBarOnInternet.Name = "progressBarOnInternet";
            this.progressBarOnInternet.Size = new System.Drawing.Size(475, 27);
            this.progressBarOnInternet.TabIndex = 29;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(1029, 529);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(59, 27);
            this.buttonHelp.TabIndex = 30;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(950, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 94);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(12, 210);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(269, 246);
            this.textBoxBody.TabIndex = 32;
            this.textBoxBody.Text = "";
            // 
            // checkBoxNPosti
            // 
            this.checkBoxNPosti.AutoSize = true;
            this.checkBoxNPosti.Location = new System.Drawing.Point(53, 194);
            this.checkBoxNPosti.Name = "checkBoxNPosti";
            this.checkBoxNPosti.Size = new System.Drawing.Size(74, 17);
            this.checkBoxNPosti.TabIndex = 33;
            this.checkBoxNPosti.Text = "Molti Posti";
            this.checkBoxNPosti.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Proggetti",
            "Stagione Teatrale"});
            this.comboBoxTipo.Location = new System.Drawing.Point(134, 185);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(147, 21);
            this.comboBoxTipo.TabIndex = 34;
            this.comboBoxTipo.Text = "Proggetti";
            // 
            // FormTDS
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.checkBoxNPosti);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.progressBarOnInternet);
            this.Controls.Add(this.buttonPushFtp);
            this.Controls.Add(this.buttonDelet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNameImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.dateTimePickerEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUnderTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTDS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TSE Gestione Sito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.buttonHelp_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxUnderTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvent;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.DateTimePicker dateTimePickerChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNameImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Button buttonPushFtp;
        private System.Windows.Forms.ProgressBar progressBarOnInternet;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox textBoxBody;
        private System.Windows.Forms.CheckBox checkBoxNPosti;
        private System.Windows.Forms.ComboBox comboBoxTipo;
    }
}

