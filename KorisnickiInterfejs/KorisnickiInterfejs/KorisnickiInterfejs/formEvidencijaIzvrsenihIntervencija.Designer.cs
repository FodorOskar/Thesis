namespace KorisnickiInterfejs
{
    partial class formEvidencijaIzvrsenihIntervencija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEvidencijaIzvrsenihIntervencija));
            this.groupBoxPrikazIntervencije = new System.Windows.Forms.GroupBox();
            this.buttonExportXML = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.labelNazivIntervencijeFilter = new System.Windows.Forms.Label();
            this.buttonSve = new System.Windows.Forms.Button();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.dataGridViewSpisakIntervencija = new System.Windows.Forms.DataGridView();
            this.buttonBrisanje = new System.Windows.Forms.Button();
            this.groupBoxUnosIntervencije = new System.Windows.Forms.GroupBox();
            this.buttonIzmena = new System.Windows.Forms.Button();
            this.dateTimePickerVreme = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxKomentarIntervencije = new System.Windows.Forms.TextBox();
            this.textBoxStomatologPrezime = new System.Windows.Forms.TextBox();
            this.labelKomentarIntervencije = new System.Windows.Forms.Label();
            this.labelStomatologPrezime = new System.Windows.Forms.Label();
            this.textBoxPacijentIme = new System.Windows.Forms.TextBox();
            this.textBoxPacijentPrezime = new System.Windows.Forms.TextBox();
            this.labelPacijentIme = new System.Windows.Forms.Label();
            this.labelPacijentPrezime = new System.Windows.Forms.Label();
            this.labelVremeIntervencije = new System.Windows.Forms.Label();
            this.labelDatumIntervencije = new System.Windows.Forms.Label();
            this.labelPozicija = new System.Windows.Forms.Label();
            this.buttonPoslednji = new System.Windows.Forms.Button();
            this.buttonSledeci = new System.Windows.Forms.Button();
            this.buttonPrethodni = new System.Windows.Forms.Button();
            this.buttonPrvi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.textBoxNazivIntervencije = new System.Windows.Forms.TextBox();
            this.textBoxPacijentJmbg = new System.Windows.Forms.TextBox();
            this.labelNazivIntervencije = new System.Windows.Forms.Label();
            this.labelPacijentJmbg = new System.Windows.Forms.Label();
            this.groupBoxPrikazIntervencije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpisakIntervencija)).BeginInit();
            this.groupBoxUnosIntervencije.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrikazIntervencije
            // 
            this.groupBoxPrikazIntervencije.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPrikazIntervencije.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPrikazIntervencije.BackgroundImage")));
            this.groupBoxPrikazIntervencije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPrikazIntervencije.Controls.Add(this.buttonExportXML);
            this.groupBoxPrikazIntervencije.Controls.Add(this.textBoxFilter);
            this.groupBoxPrikazIntervencije.Controls.Add(this.labelNazivIntervencijeFilter);
            this.groupBoxPrikazIntervencije.Controls.Add(this.buttonSve);
            this.groupBoxPrikazIntervencije.Controls.Add(this.buttonFiltriraj);
            this.groupBoxPrikazIntervencije.Controls.Add(this.dataGridViewSpisakIntervencija);
            this.groupBoxPrikazIntervencije.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxPrikazIntervencije.Location = new System.Drawing.Point(414, 22);
            this.groupBoxPrikazIntervencije.Name = "groupBoxPrikazIntervencije";
            this.groupBoxPrikazIntervencije.Size = new System.Drawing.Size(719, 391);
            this.groupBoxPrikazIntervencije.TabIndex = 13;
            this.groupBoxPrikazIntervencije.TabStop = false;
            this.groupBoxPrikazIntervencije.Text = "Tabelarni Prikaz I Filtriranje";
            this.groupBoxPrikazIntervencije.Enter += new System.EventHandler(this.groupBoxPrikazIntervencije_Enter);
            // 
            // buttonExportXML
            // 
            this.buttonExportXML.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonExportXML.Location = new System.Drawing.Point(467, 290);
            this.buttonExportXML.Name = "buttonExportXML";
            this.buttonExportXML.Size = new System.Drawing.Size(89, 27);
            this.buttonExportXML.TabIndex = 14;
            this.buttonExportXML.Text = "Export XML";
            this.buttonExportXML.UseVisualStyleBackColor = true;
            this.buttonExportXML.Click += new System.EventHandler(this.buttonExportXML_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFilter.Location = new System.Drawing.Point(109, 294);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(144, 20);
            this.textBoxFilter.TabIndex = 13;
            // 
            // labelNazivIntervencijeFilter
            // 
            this.labelNazivIntervencijeFilter.AutoSize = true;
            this.labelNazivIntervencijeFilter.Location = new System.Drawing.Point(18, 301);
            this.labelNazivIntervencijeFilter.Name = "labelNazivIntervencijeFilter";
            this.labelNazivIntervencijeFilter.Size = new System.Drawing.Size(85, 13);
            this.labelNazivIntervencijeFilter.TabIndex = 12;
            this.labelNazivIntervencijeFilter.Text = "Pacijent Prezime";
            // 
            // buttonSve
            // 
            this.buttonSve.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonSve.Location = new System.Drawing.Point(363, 290);
            this.buttonSve.Name = "buttonSve";
            this.buttonSve.Size = new System.Drawing.Size(89, 28);
            this.buttonSve.TabIndex = 11;
            this.buttonSve.Text = "SVE";
            this.buttonSve.UseVisualStyleBackColor = true;
            this.buttonSve.Click += new System.EventHandler(this.buttonSve_Click);
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonFiltriraj.Location = new System.Drawing.Point(259, 290);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(89, 28);
            this.buttonFiltriraj.TabIndex = 10;
            this.buttonFiltriraj.Text = "FILTRIRAJ";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // dataGridViewSpisakIntervencija
            // 
            this.dataGridViewSpisakIntervencija.AllowUserToAddRows = false;
            this.dataGridViewSpisakIntervencija.AllowUserToDeleteRows = false;
            this.dataGridViewSpisakIntervencija.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSpisakIntervencija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpisakIntervencija.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSpisakIntervencija.Location = new System.Drawing.Point(21, 31);
            this.dataGridViewSpisakIntervencija.Name = "dataGridViewSpisakIntervencija";
            this.dataGridViewSpisakIntervencija.Size = new System.Drawing.Size(675, 253);
            this.dataGridViewSpisakIntervencija.TabIndex = 9;
            this.dataGridViewSpisakIntervencija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpisakIntervencija_CellContentClick);
            this.dataGridViewSpisakIntervencija.Click += new System.EventHandler(this.dataGridViewSpisakIntervencija_CellClick);
            // 
            // buttonBrisanje
            // 
            this.buttonBrisanje.BackColor = System.Drawing.Color.Transparent;
            this.buttonBrisanje.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonBrisanje.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBrisanje.Location = new System.Drawing.Point(147, 290);
            this.buttonBrisanje.Name = "buttonBrisanje";
            this.buttonBrisanje.Size = new System.Drawing.Size(68, 29);
            this.buttonBrisanje.TabIndex = 16;
            this.buttonBrisanje.Text = "BRISANJE";
            this.buttonBrisanje.UseVisualStyleBackColor = false;
            this.buttonBrisanje.Click += new System.EventHandler(this.buttonBrisanje_Click);
            // 
            // groupBoxUnosIntervencije
            // 
            this.groupBoxUnosIntervencije.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUnosIntervencije.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxUnosIntervencije.BackgroundImage")));
            this.groupBoxUnosIntervencije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonBrisanje);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonIzmena);
            this.groupBoxUnosIntervencije.Controls.Add(this.dateTimePickerVreme);
            this.groupBoxUnosIntervencije.Controls.Add(this.dateTimePickerDatum);
            this.groupBoxUnosIntervencije.Controls.Add(this.textBoxKomentarIntervencije);
            this.groupBoxUnosIntervencije.Controls.Add(this.textBoxStomatologPrezime);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelKomentarIntervencije);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelStomatologPrezime);
            this.groupBoxUnosIntervencije.Controls.Add(this.textBoxPacijentIme);
            this.groupBoxUnosIntervencije.Controls.Add(this.textBoxPacijentPrezime);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelPacijentIme);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelPacijentPrezime);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelVremeIntervencije);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelDatumIntervencije);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelPozicija);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonPoslednji);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonSledeci);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonPrethodni);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonPrvi);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonOdustani);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonSnimi);
            this.groupBoxUnosIntervencije.Controls.Add(this.buttonUnos);
            this.groupBoxUnosIntervencije.Controls.Add(this.textBoxNazivIntervencije);
            this.groupBoxUnosIntervencije.Controls.Add(this.textBoxPacijentJmbg);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelNazivIntervencije);
            this.groupBoxUnosIntervencije.Controls.Add(this.labelPacijentJmbg);
            this.groupBoxUnosIntervencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUnosIntervencije.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxUnosIntervencije.Location = new System.Drawing.Point(28, 22);
            this.groupBoxUnosIntervencije.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxUnosIntervencije.Name = "groupBoxUnosIntervencije";
            this.groupBoxUnosIntervencije.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxUnosIntervencije.Size = new System.Drawing.Size(380, 391);
            this.groupBoxUnosIntervencije.TabIndex = 14;
            this.groupBoxUnosIntervencije.TabStop = false;
            this.groupBoxUnosIntervencije.Text = "Unos Nove Intervencije";
            this.groupBoxUnosIntervencije.Enter += new System.EventHandler(this.groupBoxUnosIntervencije_Enter);
            // 
            // buttonIzmena
            // 
            this.buttonIzmena.BackColor = System.Drawing.Color.Transparent;
            this.buttonIzmena.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonIzmena.ForeColor = System.Drawing.Color.Transparent;
            this.buttonIzmena.Location = new System.Drawing.Point(82, 290);
            this.buttonIzmena.Name = "buttonIzmena";
            this.buttonIzmena.Size = new System.Drawing.Size(59, 29);
            this.buttonIzmena.TabIndex = 35;
            this.buttonIzmena.Text = "IZMENA";
            this.buttonIzmena.UseVisualStyleBackColor = false;
            this.buttonIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // dateTimePickerVreme
            // 
            this.dateTimePickerVreme.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerVreme.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerVreme.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerVreme.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerVreme.CausesValidation = false;
            this.dateTimePickerVreme.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerVreme.CustomFormat = "HH:mm";
            this.dateTimePickerVreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVreme.Location = new System.Drawing.Point(111, 115);
            this.dateTimePickerVreme.Name = "dateTimePickerVreme";
            this.dateTimePickerVreme.ShowUpDown = true;
            this.dateTimePickerVreme.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerVreme.TabIndex = 34;
            this.dateTimePickerVreme.Value = new System.DateTime(2022, 6, 28, 15, 21, 0, 0);
            this.dateTimePickerVreme.ValueChanged += new System.EventHandler(this.dateTimePickerVreme_ValueChanged);
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerDatum.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(111, 89);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerDatum.TabIndex = 33;
            this.dateTimePickerDatum.ValueChanged += new System.EventHandler(this.dateTimePickerDatum_ValueChanged);
            // 
            // textBoxKomentarIntervencije
            // 
            this.textBoxKomentarIntervencije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxKomentarIntervencije.Location = new System.Drawing.Point(111, 225);
            this.textBoxKomentarIntervencije.Multiline = true;
            this.textBoxKomentarIntervencije.Name = "textBoxKomentarIntervencije";
            this.textBoxKomentarIntervencije.Size = new System.Drawing.Size(167, 59);
            this.textBoxKomentarIntervencije.TabIndex = 32;
            // 
            // textBoxStomatologPrezime
            // 
            this.textBoxStomatologPrezime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxStomatologPrezime.Location = new System.Drawing.Point(111, 196);
            this.textBoxStomatologPrezime.Name = "textBoxStomatologPrezime";
            this.textBoxStomatologPrezime.Size = new System.Drawing.Size(167, 20);
            this.textBoxStomatologPrezime.TabIndex = 31;
            // 
            // labelKomentarIntervencije
            // 
            this.labelKomentarIntervencije.AutoSize = true;
            this.labelKomentarIntervencije.Location = new System.Drawing.Point(8, 222);
            this.labelKomentarIntervencije.Name = "labelKomentarIntervencije";
            this.labelKomentarIntervencije.Size = new System.Drawing.Size(52, 13);
            this.labelKomentarIntervencije.TabIndex = 30;
            this.labelKomentarIntervencije.Text = "Komentar";
            // 
            // labelStomatologPrezime
            // 
            this.labelStomatologPrezime.AutoSize = true;
            this.labelStomatologPrezime.Location = new System.Drawing.Point(8, 200);
            this.labelStomatologPrezime.Name = "labelStomatologPrezime";
            this.labelStomatologPrezime.Size = new System.Drawing.Size(100, 13);
            this.labelStomatologPrezime.TabIndex = 29;
            this.labelStomatologPrezime.Text = "Stomatolog Prezime";
            // 
            // textBoxPacijentIme
            // 
            this.textBoxPacijentIme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPacijentIme.Location = new System.Drawing.Point(111, 170);
            this.textBoxPacijentIme.Name = "textBoxPacijentIme";
            this.textBoxPacijentIme.Size = new System.Drawing.Size(167, 20);
            this.textBoxPacijentIme.TabIndex = 28;
            // 
            // textBoxPacijentPrezime
            // 
            this.textBoxPacijentPrezime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPacijentPrezime.Location = new System.Drawing.Point(111, 141);
            this.textBoxPacijentPrezime.Name = "textBoxPacijentPrezime";
            this.textBoxPacijentPrezime.Size = new System.Drawing.Size(167, 20);
            this.textBoxPacijentPrezime.TabIndex = 27;
            // 
            // labelPacijentIme
            // 
            this.labelPacijentIme.AutoSize = true;
            this.labelPacijentIme.Location = new System.Drawing.Point(8, 174);
            this.labelPacijentIme.Name = "labelPacijentIme";
            this.labelPacijentIme.Size = new System.Drawing.Size(65, 13);
            this.labelPacijentIme.TabIndex = 26;
            this.labelPacijentIme.Text = "Pacijent Ime";
            // 
            // labelPacijentPrezime
            // 
            this.labelPacijentPrezime.AutoSize = true;
            this.labelPacijentPrezime.Location = new System.Drawing.Point(8, 145);
            this.labelPacijentPrezime.Name = "labelPacijentPrezime";
            this.labelPacijentPrezime.Size = new System.Drawing.Size(85, 13);
            this.labelPacijentPrezime.TabIndex = 25;
            this.labelPacijentPrezime.Text = "Pacijent Prezime";
            this.labelPacijentPrezime.Click += new System.EventHandler(this.labelPacijentPrezime_Click);
            // 
            // labelVremeIntervencije
            // 
            this.labelVremeIntervencije.AutoSize = true;
            this.labelVremeIntervencije.Location = new System.Drawing.Point(8, 118);
            this.labelVremeIntervencije.Name = "labelVremeIntervencije";
            this.labelVremeIntervencije.Size = new System.Drawing.Size(37, 13);
            this.labelVremeIntervencije.TabIndex = 22;
            this.labelVremeIntervencije.Text = "Vreme";
            // 
            // labelDatumIntervencije
            // 
            this.labelDatumIntervencije.AutoSize = true;
            this.labelDatumIntervencije.Location = new System.Drawing.Point(8, 92);
            this.labelDatumIntervencije.Name = "labelDatumIntervencije";
            this.labelDatumIntervencije.Size = new System.Drawing.Size(38, 13);
            this.labelDatumIntervencije.TabIndex = 21;
            this.labelDatumIntervencije.Text = "Datum";
            // 
            // labelPozicija
            // 
            this.labelPozicija.AutoSize = true;
            this.labelPozicija.BackColor = System.Drawing.Color.Transparent;
            this.labelPozicija.ForeColor = System.Drawing.Color.Transparent;
            this.labelPozicija.Location = new System.Drawing.Point(166, 356);
            this.labelPozicija.Name = "labelPozicija";
            this.labelPozicija.Size = new System.Drawing.Size(54, 13);
            this.labelPozicija.TabIndex = 20;
            this.labelPozicija.Text = "POZICIJA";
            // 
            // buttonPoslednji
            // 
            this.buttonPoslednji.BackColor = System.Drawing.Color.Transparent;
            this.buttonPoslednji.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonPoslednji.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPoslednji.Location = new System.Drawing.Point(300, 350);
            this.buttonPoslednji.Name = "buttonPoslednji";
            this.buttonPoslednji.Size = new System.Drawing.Size(74, 24);
            this.buttonPoslednji.TabIndex = 19;
            this.buttonPoslednji.Text = ">>";
            this.buttonPoslednji.UseVisualStyleBackColor = false;
            this.buttonPoslednji.Click += new System.EventHandler(this.buttonPoslednjaIntervencija_Click);
            // 
            // buttonSledeci
            // 
            this.buttonSledeci.BackColor = System.Drawing.Color.Transparent;
            this.buttonSledeci.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonSledeci.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSledeci.Location = new System.Drawing.Point(226, 350);
            this.buttonSledeci.Name = "buttonSledeci";
            this.buttonSledeci.Size = new System.Drawing.Size(68, 24);
            this.buttonSledeci.TabIndex = 18;
            this.buttonSledeci.Text = ">";
            this.buttonSledeci.UseVisualStyleBackColor = false;
            this.buttonSledeci.Click += new System.EventHandler(this.buttonSledecaIntervencija_Click);
            // 
            // buttonPrethodni
            // 
            this.buttonPrethodni.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrethodni.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonPrethodni.FlatAppearance.BorderSize = 0;
            this.buttonPrethodni.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPrethodni.Location = new System.Drawing.Point(87, 350);
            this.buttonPrethodni.Name = "buttonPrethodni";
            this.buttonPrethodni.Size = new System.Drawing.Size(73, 27);
            this.buttonPrethodni.TabIndex = 17;
            this.buttonPrethodni.Text = "<";
            this.buttonPrethodni.UseVisualStyleBackColor = false;
            this.buttonPrethodni.Click += new System.EventHandler(this.buttonPrethodnaIntervencija_Click);
            // 
            // buttonPrvi
            // 
            this.buttonPrvi.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrvi.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonPrvi.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPrvi.Location = new System.Drawing.Point(8, 350);
            this.buttonPrvi.Name = "buttonPrvi";
            this.buttonPrvi.Size = new System.Drawing.Size(73, 26);
            this.buttonPrvi.TabIndex = 16;
            this.buttonPrvi.Text = "<<";
            this.buttonPrvi.UseVisualStyleBackColor = false;
            this.buttonPrvi.Click += new System.EventHandler(this.buttonPrvaIntervencija_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonOdustani.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOdustani.Location = new System.Drawing.Point(299, 290);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(74, 29);
            this.buttonOdustani.TabIndex = 13;
            this.buttonOdustani.Text = "ODUSTANI";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.BackgroundImage = global::KorisnickiInterfejs.Properties.Resources.Screenshot_8;
            this.buttonSnimi.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSnimi.Location = new System.Drawing.Point(221, 290);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(72, 29);
            this.buttonSnimi.TabIndex = 12;
            this.buttonSnimi.Text = "SNIMI";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.buttonSnimi_Click);
            // 
            // buttonUnos
            // 
            this.buttonUnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUnos.BackgroundImage")));
            this.buttonUnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUnos.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnos.Image")));
            this.buttonUnos.Location = new System.Drawing.Point(12, 290);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(64, 29);
            this.buttonUnos.TabIndex = 11;
            this.buttonUnos.Text = "UNOS";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // textBoxNazivIntervencije
            // 
            this.textBoxNazivIntervencije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNazivIntervencije.Location = new System.Drawing.Point(111, 60);
            this.textBoxNazivIntervencije.Name = "textBoxNazivIntervencije";
            this.textBoxNazivIntervencije.Size = new System.Drawing.Size(167, 20);
            this.textBoxNazivIntervencije.TabIndex = 10;
            // 
            // textBoxPacijentJmbg
            // 
            this.textBoxPacijentJmbg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPacijentJmbg.Location = new System.Drawing.Point(111, 31);
            this.textBoxPacijentJmbg.Name = "textBoxPacijentJmbg";
            this.textBoxPacijentJmbg.Size = new System.Drawing.Size(167, 20);
            this.textBoxPacijentJmbg.TabIndex = 9;
            this.textBoxPacijentJmbg.TextChanged += new System.EventHandler(this.textBoxPacijentJmbg_TextChanged);
            // 
            // labelNazivIntervencije
            // 
            this.labelNazivIntervencije.AutoSize = true;
            this.labelNazivIntervencije.Location = new System.Drawing.Point(8, 64);
            this.labelNazivIntervencije.Name = "labelNazivIntervencije";
            this.labelNazivIntervencije.Size = new System.Drawing.Size(92, 13);
            this.labelNazivIntervencije.TabIndex = 8;
            this.labelNazivIntervencije.Text = "Naziv Intervencije";
            // 
            // labelPacijentJmbg
            // 
            this.labelPacijentJmbg.AutoSize = true;
            this.labelPacijentJmbg.Location = new System.Drawing.Point(8, 35);
            this.labelPacijentJmbg.Name = "labelPacijentJmbg";
            this.labelPacijentJmbg.Size = new System.Drawing.Size(36, 13);
            this.labelPacijentJmbg.TabIndex = 7;
            this.labelPacijentJmbg.Text = "JMBG";
            // 
            // formEvidencijaIzvrsenihIntervencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 445);
            this.Controls.Add(this.groupBoxUnosIntervencije);
            this.Controls.Add(this.groupBoxPrikazIntervencije);
            this.DoubleBuffered = true;
            this.Name = "formEvidencijaIzvrsenihIntervencija";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Evidencija Izvrsenih Intervencija";
            this.Load += new System.EventHandler(this.formEvidencijaIzvrsenihIntervencija_Load);
            this.groupBoxPrikazIntervencije.ResumeLayout(false);
            this.groupBoxPrikazIntervencije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpisakIntervencija)).EndInit();
            this.groupBoxUnosIntervencije.ResumeLayout(false);
            this.groupBoxUnosIntervencije.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrikazIntervencije;
        private System.Windows.Forms.Button buttonExportXML;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label labelNazivIntervencijeFilter;
        private System.Windows.Forms.Button buttonSve;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.DataGridView dataGridViewSpisakIntervencija;
        private System.Windows.Forms.Button buttonBrisanje;
        private System.Windows.Forms.GroupBox groupBoxUnosIntervencije;
        private System.Windows.Forms.Button buttonIzmena;
        private System.Windows.Forms.DateTimePicker dateTimePickerVreme;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxKomentarIntervencije;
        private System.Windows.Forms.TextBox textBoxStomatologPrezime;
        private System.Windows.Forms.Label labelKomentarIntervencije;
        private System.Windows.Forms.Label labelStomatologPrezime;
        private System.Windows.Forms.TextBox textBoxPacijentIme;
        private System.Windows.Forms.TextBox textBoxPacijentPrezime;
        private System.Windows.Forms.Label labelPacijentIme;
        private System.Windows.Forms.Label labelPacijentPrezime;
        private System.Windows.Forms.Label labelVremeIntervencije;
        private System.Windows.Forms.Label labelDatumIntervencije;
        private System.Windows.Forms.Label labelPozicija;
        private System.Windows.Forms.Button buttonPoslednji;
        private System.Windows.Forms.Button buttonSledeci;
        private System.Windows.Forms.Button buttonPrethodni;
        private System.Windows.Forms.Button buttonPrvi;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.TextBox textBoxNazivIntervencije;
        private System.Windows.Forms.TextBox textBoxPacijentJmbg;
        private System.Windows.Forms.Label labelNazivIntervencije;
        private System.Windows.Forms.Label labelPacijentJmbg;
    }
}