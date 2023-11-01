using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//
using KlasePodataka;

namespace KorisnickiInterfejs
{
    public partial class formEvidencijaIzvrsenihIntervencija : Form
    {
        private string akcija = "";
        private List<IntervencijaClass> intervencijaLista = new List<IntervencijaClass>();

        // ------------ ATRIBUTI
        // #################################################
        private DataTable podaciDataTable;

        private DataSet podaciDataSet;
        public IntervencijaDBClass IntervencijaDBObject;
        int MaxRows;


        // ------------ METODE
        // #################################################

        // -----------------NASE PROCEDURE
        private void IsprazniKontrole()
        {
            textBoxPacijentJmbg.Text = "";
            textBoxNazivIntervencije.Text = "";
            textBoxPacijentIme.Text = "";
            textBoxPacijentPrezime.Text = "";
            textBoxStomatologPrezime.Text = "";
            textBoxKomentarIntervencije.Text = "";
            dateTimePickerDatum.Value = DateTime.Now;
            dateTimePickerVreme.Value = DateTime.Now;
        }

        private void AktivirajKontrole()
        {
            textBoxPacijentJmbg.Enabled = true;
            textBoxNazivIntervencije.Enabled = true;
            textBoxPacijentIme.Enabled = true;
            textBoxPacijentPrezime.Enabled = true;
            textBoxStomatologPrezime.Enabled = true;
            textBoxKomentarIntervencije.Enabled = true;
            dateTimePickerDatum.Enabled = true;
            dateTimePickerVreme.Enabled = true;
        }

        private void DeaktivirajKontrole()
        {
            textBoxPacijentJmbg.Enabled = false;
            textBoxNazivIntervencije.Enabled = false;
            textBoxPacijentIme.Enabled = false;
            textBoxPacijentPrezime.Enabled = false;
            textBoxStomatologPrezime.Enabled = false;
            textBoxKomentarIntervencije.Enabled = false;
            dateTimePickerDatum.Enabled = false;
            dateTimePickerVreme.Enabled = false;
        }

        private void PrikaziTabeluPodataka(DataTable podaciDataTable)
        {
            dataGridViewSpisakIntervencija.DataSource = podaciDataTable;
            dataGridViewSpisakIntervencija.Refresh();
        }

        private void PrikaziTabeluPodataka(DataSet podaciDataSet)
        {
            dataGridViewSpisakIntervencija.DataSource = podaciDataSet.Tables[0];
            dataGridViewSpisakIntervencija.Refresh();
        }

        private void SnimiXML(DataTable podaci, string putanja)
        {
            DataSet dsPodaciEksport = new DataSet();

            // s obzirom da smo dobili kroz parametar poziva ove procedure "podaci"
            // zapravo samo promenljivu koja sadrzi memorijsku lokaciju, pokazivac
            // ka podacima, javlja se problem kada ovaj isti DataTable "podaci"
            // vezemo sa drugim datasetom "dsPodaciExport" jer je taj DataTable
            // vec povezan sa dsPodaci u okviru procedure UcitajSve i UcitajTabelarno.
            // Zato moramo da radimo Copy, da kopiramo strukturu i podatke u NOVI DataTable.
            DataTable podaciZaEksport = new DataTable();
            podaciZaEksport = podaci.Copy();
            dsPodaciEksport.Tables.Add(podaciZaEksport);
            dsPodaciEksport.WriteXml(putanja);
        }

        // KONSTRUKTOR
        public formEvidencijaIzvrsenihIntervencija()
        {
            InitializeComponent();
            DeaktivirajKontrole();
            
        }
        //konfiguracija za datagrid view
        private void ConfigureDataGridView()
        {
            dataGridViewSpisakIntervencija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewSpisakIntervencija.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewSpisakIntervencija.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSpisakIntervencija.Columns["intervencija_id"].Width = 10; // Adjust the width as needed
            dataGridViewSpisakIntervencija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewSpisakIntervencija.RowHeadersVisible = false;
            dataGridViewSpisakIntervencija.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewSpisakIntervencija.DefaultCellStyle.BackColor = Color.White;
            dataGridViewSpisakIntervencija.Columns["komentar_intervencije"].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            //promena naziva headera


            dataGridViewSpisakIntervencija.Columns["intervencija_id"].HeaderText = "ID";
            dataGridViewSpisakIntervencija.Columns["pacijent_jmbg"].HeaderText = "JMBG";
            dataGridViewSpisakIntervencija.Columns["naziv_intervencije"].HeaderText = "Intervencija";
            dataGridViewSpisakIntervencija.Columns["datum_intervencije"].HeaderText = "Datum";
            dataGridViewSpisakIntervencija.Columns["vreme_intervencije"].HeaderText = "Vreme";
            dataGridViewSpisakIntervencija.Columns["prezime_pacijent"].HeaderText = "Prezime Pacijenta";
            dataGridViewSpisakIntervencija.Columns["ime_pacijent"].HeaderText = "Ime Pacijenta";
            dataGridViewSpisakIntervencija.Columns["prezime_stomatologa"].HeaderText = "Stomatolog";
            dataGridViewSpisakIntervencija.Columns["komentar_intervencije"].HeaderText = "Komentar";

        }


        // DOGADJAJI
        private void formEvidencijaIzvrsenihIntervencija_Load(object sender, EventArgs e)
        {
            // inicijalizacija globalne promenljive
            podaciDataSet = new DataSet();
            podaciDataTable = new DataTable();
            IntervencijaDBObject = new IntervencijaDBClass();
            dataGridViewPrikazTabele();
            ConfigureDataGridView();



        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            buttonUnos.Enabled = false;
            IsprazniKontrole();
            AktivirajKontrole();
            textBoxPacijentJmbg.Focus();
            akcija = "dodaj";
            ConfigureDataGridView();

        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewSpisakIntervencija.SelectedRows.Count > 0)
            {
                SelektovanaIntervencija();
                AktivirajKontrole();
                textBoxPacijentJmbg.Focus();
                akcija = "izmeni";
                buttonUnos.Enabled = false;
                ConfigureDataGridView();

            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
           
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            string poruka = "";

            // Dodavanje regularnih izraza za validaciju 
            string jmbgPattern = @"^\d{13}$"; // 13-cifreni broj
            string namePattern = @"^[A-ZČĆŠĐŽ][a-zčćšđž]*$"; // Samo slova i moraju da počinju sa velikim slovom

            if (!Regex.IsMatch(textBoxPacijentJmbg.Text, jmbgPattern))
            {
                poruka += "JMBG mora sadržati 13 cifara (0-9).\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxNazivIntervencije.Text))
            {
                poruka += "Naziv intervencije ne sme biti prazan.\n";
            }

            if (!Regex.IsMatch(textBoxPacijentPrezime.Text, namePattern))
            {
                poruka += "Prezime pacijenta mora početi velikim slovom i sadržati samo slova.\n";
            }

            if (!Regex.IsMatch(textBoxPacijentIme.Text, namePattern))
            {
                poruka += "Ime pacijenta mora početi velikim slovom i sadržati samo slova.\n";
            }

            if (!Regex.IsMatch(textBoxStomatologPrezime.Text, namePattern))
            {
                poruka += "Prezime stomatologa mora početi velikim slovom i sadržati samo slova.\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxKomentarIntervencije.Text))
            {
                poruka += "Komentar intervencije ne sme biti prazan.\n";
            }

            if (!string.IsNullOrEmpty(poruka))
            {
                MessageBox.Show("Zapis nije uspešan:\n" + poruka);
                return;
            }

            if (akcija == "dodaj")
            {
                //Kod za dodavanje
                // preuzimanje vrednosti sa korisnickog interfejsa
                IntervencijaClass IntervencijaObject = new IntervencijaClass();
                IntervencijaObject.pacijent_jmbg = textBoxPacijentJmbg.Text;
                IntervencijaObject.naziv_intervencije = textBoxNazivIntervencije.Text;
                string dan = dateTimePickerDatum.Value.Day.ToString();
                string mesec = dateTimePickerDatum.Value.Month.ToString();
                string godina = dateTimePickerDatum.Value.Year.ToString();
                IntervencijaObject.datum_intervencije = mesec + "/" + dan + "/" + godina;
                string sat = dateTimePickerVreme.Value.Hour.ToString();
                string minut = dateTimePickerVreme.Value.Minute.ToString();
                IntervencijaObject.vreme_intervencije = sat + ":" + minut + ":00";
                IntervencijaObject.prezime_pacijent = textBoxPacijentPrezime.Text;
                IntervencijaObject.ime_pacijent = textBoxPacijentIme.Text;
                IntervencijaObject.prezime_stomatologa = textBoxStomatologPrezime.Text;
                IntervencijaObject.komentar_intervencije = textBoxKomentarIntervencije.Text;

                bool uspehSnimanja = IntervencijaDBObject.SnimiNovuIntervenciju(IntervencijaObject);
                if (uspehSnimanja)
                {
                    poruka = "Uspesno snimljeno!";
                }
                else
                {
                    poruka = "Nije uspesno snimljeno!";
                }
                PrikaziTabeluPodataka(podaciDataTable);
            }
            else if (akcija == "izmeni")
            {
                // The rest of your code for updating an existing record
                int idSelektovanog = (int)dataGridViewSpisakIntervencija.SelectedRows[0].Cells["intervencija_id"].Value;

                IntervencijaClass IntervencijaObject = new IntervencijaClass();
                IntervencijaObject.pacijent_jmbg = textBoxPacijentJmbg.Text;
                IntervencijaObject.naziv_intervencije = textBoxNazivIntervencije.Text;
                string dan = dateTimePickerDatum.Value.Day.ToString();
                string mesec = dateTimePickerDatum.Value.Month.ToString();
                string godina = dateTimePickerDatum.Value.Year.ToString();
                IntervencijaObject.datum_intervencije = mesec + "/" + dan + "/" + godina;
                string sat = dateTimePickerVreme.Value.Hour.ToString();
                string minut = dateTimePickerVreme.Value.Minute.ToString();
                IntervencijaObject.vreme_intervencije = sat + ":" + minut + ":00";
                IntervencijaObject.prezime_pacijent = textBoxPacijentPrezime.Text;
                IntervencijaObject.ime_pacijent = textBoxPacijentIme.Text;
                IntervencijaObject.prezime_stomatologa = textBoxStomatologPrezime.Text;
                IntervencijaObject.komentar_intervencije = textBoxKomentarIntervencije.Text;

                bool uspehSnimanja = IntervencijaDBObject.IzmeniIntervenciju(idSelektovanog, IntervencijaObject);
                if (uspehSnimanja)
                {
                    poruka = "Uspesno snimljeno!";
                }
                else
                {
                    poruka = "Nije uspesno snimljeno!";
                }
                buttonUnos.Enabled = true;
            }

            /*if (akcija == "dodaj")
            {
                // preuzimanje vrednosti sa korisnickog interfejsa
                IntervencijaClass IntervencijaObject = new IntervencijaClass();
                IntervencijaObject.pacijent_jmbg = textBoxPacijentJmbg.Text;
                IntervencijaObject.naziv_intervencije = textBoxNazivIntervencije.Text;
                string dan = dateTimePickerDatum.Value.Day.ToString();
                string mesec = dateTimePickerDatum.Value.Month.ToString();
                string godina = dateTimePickerDatum.Value.Year.ToString();
                IntervencijaObject.datum_intervencije = mesec + "/" + dan + "/" + godina;
                string sat = dateTimePickerVreme.Value.Hour.ToString();
                string minut = dateTimePickerVreme.Value.Minute.ToString();
                IntervencijaObject.vreme_intervencije = sat + ":" + minut + ":00";
                IntervencijaObject.prezime_pacijent = textBoxPacijentPrezime.Text;
                IntervencijaObject.ime_pacijent = textBoxPacijentIme.Text;
                IntervencijaObject.prezime_stomatologa = textBoxStomatologPrezime.Text;
                IntervencijaObject.komentar_intervencije = textBoxKomentarIntervencije.Text;

                bool uspehSnimanja = IntervencijaDBObject.SnimiNovuIntervenciju(IntervencijaObject);
                if (uspehSnimanja)
                {
                    poruka = "Uspesno snimljeno!";
                }
                else
                {
                    poruka = "Nije uspesno snimljeno!";
                }
                PrikaziTabeluPodataka(podaciDataTable);
            }
            else if (akcija == "izmeni")
            {
                int idSelektovanog = (int)dataGridViewSpisakIntervencija.SelectedRows[0].Cells["intervencija_id"].Value;

                IntervencijaClass IntervencijaObject = new IntervencijaClass();
                IntervencijaObject.pacijent_jmbg = textBoxPacijentJmbg.Text;
                IntervencijaObject.naziv_intervencije = textBoxNazivIntervencije.Text;
                string dan = dateTimePickerDatum.Value.Day.ToString();
                string mesec = dateTimePickerDatum.Value.Month.ToString();
                string godina = dateTimePickerDatum.Value.Year.ToString();
                IntervencijaObject.datum_intervencije = mesec + "/" + dan + "/" + godina;
                string sat = dateTimePickerVreme.Value.Hour.ToString();
                string minut = dateTimePickerVreme.Value.Minute.ToString();
                IntervencijaObject.vreme_intervencije = sat + ":" + minut + ":00";
                IntervencijaObject.prezime_pacijent = textBoxPacijentPrezime.Text;
                IntervencijaObject.ime_pacijent = textBoxPacijentIme.Text;
                IntervencijaObject.prezime_stomatologa = textBoxStomatologPrezime.Text;
                IntervencijaObject.komentar_intervencije = textBoxKomentarIntervencije.Text;

                bool uspehSnimanja = IntervencijaDBObject.IzmeniIntervenciju(idSelektovanog, IntervencijaObject);
                if (uspehSnimanja)
                {
                    poruka = "Uspesno snimljeno!";
                }
                else
                {
                    poruka = "Nije uspesno snimljeno!";
                }
                

            }*/
            // snimanje

            DeaktivirajKontrole();
            MessageBox.Show(poruka);
            dataGridViewPrikazTabele();
            ConfigureDataGridView();
        }

        // prikaz vrednosti iz tabele u polja
        private void SelektovanaIntervencija()
        {
            int idSelektovanog = (int)dataGridViewSpisakIntervencija.SelectedRows[0].Cells["intervencija_id"].Value;

            DataSet selektovanaIntervencija = IntervencijaDBObject.DajSelektovanuIntervenciju(idSelektovanog);

            textBoxPacijentJmbg.Text = selektovanaIntervencija.Tables[0].Rows[0]["pacijent_jmbg"].ToString();
            textBoxNazivIntervencije.Text = selektovanaIntervencija.Tables[0].Rows[0]["naziv_intervencije"].ToString();
            dateTimePickerDatum.Text = selektovanaIntervencija.Tables[0].Rows[0]["datum_intervencije"].ToString();
            dateTimePickerVreme.Text = selektovanaIntervencija.Tables[0].Rows[0]["vreme_intervencije"].ToString();
            textBoxPacijentPrezime.Text = selektovanaIntervencija.Tables[0].Rows[0]["prezime_pacijent"].ToString();
            textBoxPacijentIme.Text = selektovanaIntervencija.Tables[0].Rows[0]["ime_pacijent"].ToString();
            textBoxStomatologPrezime.Text = selektovanaIntervencija.Tables[0].Rows[0]["prezime_stomatologa"].ToString();
            textBoxKomentarIntervencije.Text = selektovanaIntervencija.Tables[0].Rows[0]["komentar_intervencije"].ToString();
        }

        private void dataGridViewSpisakIntervencijaPrikazPolja()
        {
            if (dataGridViewSpisakIntervencija.CurrentRow != null)
            {
                dataGridViewSpisakIntervencija.Rows[dataGridViewSpisakIntervencija.CurrentRow.Index].Selected = true;

                SelektovanaIntervencija();
            }
        }

        private void dataGridViewSpisakIntervencija_CellClick(object sender, EventArgs e)
        {
            dataGridViewSpisakIntervencijaPrikazPolja();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            buttonUnos.Enabled = true;
            IsprazniKontrole();
            DeaktivirajKontrole();
            ConfigureDataGridView();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            podaciDataSet = IntervencijaDBObject.DajSveIntervencijePoDeluNaziva(textBoxFilter.Text);
            PrikaziTabeluPodataka(podaciDataSet);
        }

        private void dataGridViewPrikazTabele()
        {
            podaciDataSet = IntervencijaDBObject.DajSveIntervencije();
            PrikaziTabeluPodataka(podaciDataSet);
            dataGridViewSpisakIntervencija.Rows[0].Selected = true;
            dataGridViewSpisakIntervencija.CurrentCell = dataGridViewSpisakIntervencija.Rows[0].Cells[0];
            dataGridViewSpisakIntervencijaPrikazPolja();
        }
        private void buttonSve_Click(object sender, EventArgs e)
        {
            dataGridViewPrikazTabele();
            ConfigureDataGridView();
        }

        private void buttonExportXML_Click(object sender, EventArgs e)
        {
            SnimiXML(podaciDataSet.Tables[0], Parametri.putanjaXML);
            MessageBox.Show("Uspesno realizovan eksport podataka!");
        }

        private void buttonBrisanje_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpisakIntervencija.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete odabranu intervenciju?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idSelektovanog = (int)dataGridViewSpisakIntervencija.SelectedRows[0].Cells["intervencija_id"].Value;

                    IntervencijaDBObject.ObrisiIntervenciju(idSelektovanog);
                }
                PrikaziTabeluPodataka(podaciDataTable);
                IsprazniKontrole();
                dataGridViewPrikazTabele();
                ConfigureDataGridView();
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        
        

        private void dataGridViewSpisakIntervencijaRotacija()
        {
            if (MaxRows == -1)
            {
                MaxRows = dataGridViewSpisakIntervencija.Rows.Count - 2;
                dataGridViewSpisakIntervencija.Rows[MaxRows].Selected = true;
                dataGridViewSpisakIntervencija.CurrentCell = dataGridViewSpisakIntervencija.Rows[MaxRows].Cells[0];
            }
            else if (MaxRows > dataGridViewSpisakIntervencija.Rows.Count - 2)
            {
                MaxRows = 0;
                dataGridViewSpisakIntervencija.Rows[MaxRows].Selected = true;
                dataGridViewSpisakIntervencija.CurrentCell = dataGridViewSpisakIntervencija.Rows[MaxRows].Cells[0];
            }
            else
            {
                dataGridViewSpisakIntervencija.Rows[MaxRows].Selected = true;
                dataGridViewSpisakIntervencija.CurrentCell = dataGridViewSpisakIntervencija.Rows[MaxRows].Cells[0];
            }

        }



        private void buttonPrvaIntervencija_Click(object sender, EventArgs e)
        {

            dataGridViewSpisakIntervencija.ClearSelection();
            dataGridViewSpisakIntervencija.Rows[0].Selected = true;
            dataGridViewSpisakIntervencija.CurrentCell = dataGridViewSpisakIntervencija.Rows[0].Cells[0];
            MaxRows = 0;
            dataGridViewSpisakIntervencijaPrikazPolja();



        }



        private void buttonPrethodnaIntervencija_Click(object sender, EventArgs e)
        {

            dataGridViewSpisakIntervencija.ClearSelection();
            --MaxRows;
            dataGridViewSpisakIntervencijaRotacija();
            dataGridViewSpisakIntervencijaPrikazPolja();


        }



        private void buttonSledecaIntervencija_Click(object sender, EventArgs e)
        {
            dataGridViewSpisakIntervencija.ClearSelection();
            ++MaxRows;
            dataGridViewSpisakIntervencijaRotacija();
            dataGridViewSpisakIntervencijaPrikazPolja();


        }

        private void buttonPoslednjaIntervencija_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpisakIntervencija.SelectedRows[0].Index == 0)
            {
                dataGridViewSpisakIntervencija.Rows[0].Selected = false;
            }
            else
            {
                dataGridViewSpisakIntervencija.ClearSelection();
            }
            dataGridViewSpisakIntervencija.Rows[dataGridViewSpisakIntervencija.Rows.Count-2].Selected = true;
            dataGridViewSpisakIntervencija.CurrentCell = dataGridViewSpisakIntervencija.Rows[dataGridViewSpisakIntervencija.Rows.Count - 2].Cells[0];
            dataGridViewSpisakIntervencijaPrikazPolja();

        }

        private void textBoxPacijentJmbg_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxUnosIntervencije_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerVreme_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatum_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewSpisakIntervencija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelPacijentPrezime_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxPrikazIntervencije_Enter(object sender, EventArgs e)
        {

        }
    }
}