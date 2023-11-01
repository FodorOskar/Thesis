using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// dodatno ukljuceno
using System.Data;
using DBUtils;

namespace KlasePodataka
{
    public class IntervencijaDBClass : TabelaClass

    /* CRC karta - Class Responsibility Collaboration:  */
    //-----------------------------------------------------
    /* ODGOVORNOST: realizacija CRUD operacija nad tabelom Zvanje u bazi podataka */
    /* ZAVISNOST U ODNOSU NA DRUGE KLASE:
     Standardna klasa iz System.Data - DataSet
     Sopstvena klasa iz DBUtils - TabelaClass (bazna klasa)
     */
    {
        #region ATRIBUTI

        // imamo protected atribut Konekcija iz bazne klase
        // imamo sve iz bazne klase tabela

        #endregion ATRIBUTI

        // ne postavljamo property, jer postoji rizik da ostane prazan string konekcije, a bez njega ne moze
        // zato obavezujemo da se vrednost obezbedi kroz konstruktor

        #region KONSTRUKTOR

        public IntervencijaDBClass() : base()
        {
            // ovo je obavezan dodatak, jer u baznom konstruktoru bez parametara se ostvaruje konekcija
            this.NazivTabele = "Intervencija";
        }

        public IntervencijaDBClass(string nazivTabeleParametar) : base(nazivTabeleParametar)
        // izvrsava se konstruktor bazne klase, znaci istovremeno se instancira sve kao za objekat klase TabelaClass
        // ovde se u okviru ovakvog konstruktora bazne klase instancira objekat za konekciju i mi sada raspolazemo sa time
        // sada raspolazemo sa time i pisemo this.NAZIVI METODA ILI ATRIBUTA OD TE KLASE TabelaClass
        {
            // OVDE PISEMO KOD KOJI SE IZVRSAVA NAKON OSNOVNOG IZVRSAVANJA KONSTRUKTORA BAZNE KLASE
        }

        public IntervencijaDBClass(KonekcijaClass konekcijaParametar, string nazivTabeleParametar) : base(konekcijaParametar, nazivTabeleParametar)
        // izvrsava se konstruktor bazne klase, znaci istovremeno se instancira sve kao za objekat klase TabelaClass
        // _tabelaObject = new TabelaClass(_konekcijaObject, "Zvanje");
        // sada raspolazemo sa time i pisemo this.NAZIVI METODA ILI ATRIBUTA OD TE KLASE TabelaClass
        {
            // OVDE PISEMO KOD KOJI SE IZVRSAVA NAKON OSNOVNOG IZVRSAVANJA KONSTRUKTORA BAZNE KLASE
        }

        #endregion KONSTRUKTOR

        // privatne metode

        #region JAVNE METODE

        public DataSet DajSveIntervencije()
        {
            DataSet podaciDataSet = new DataSet();
            podaciDataSet = this.DajPodatke("Select * from Intervencija");
            return podaciDataSet;
        }

        public string DajNazivIntervencijePremaJmbg(string jmbgParametar)
        {
            string nazivIntervencije = "";

            DataSet podaciDataSet = new DataSet();
            podaciDataSet = this.DajPodatke("Select naziv_intervencije from intervencija where pacijent_jmbg=" + jmbgParametar + "");
            try
            {
                if (podaciDataSet.Tables[0].Rows.Count > 0)
                {
                    nazivIntervencije = podaciDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    nazivIntervencije = "";
                }
            }
            catch (Exception greska)
            {
                nazivIntervencije = "";
            }
            return nazivIntervencije;
        }

        public string DajJmbgPremaNazivuIntervencije(string nazivIntervencijeParametar)
        {
            string jmbgIntervencije = "";

            DataSet podaciDataSet = new DataSet();
            podaciDataSet = this.DajPodatke("Select pacijent_jmbg from intervencija where naziv_intervencije='" + nazivIntervencijeParametar + "'");
            try
            {
                if (podaciDataSet.Tables[0].Rows.Count > 0)
                {
                    jmbgIntervencije = podaciDataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    jmbgIntervencije = "";
                }
            }
            catch (Exception greska)
            {
                jmbgIntervencije = "";
            }
            return jmbgIntervencije;
        }

        public DataSet DajSveIntervencijePoDeluNaziva(string deoPrezimenaPacijentaParametar)
        {
            DataSet podaciDataSet = new DataSet();
            string upit = "Select * from intervencija where prezime_pacijent like '%" + deoPrezimenaPacijentaParametar + "%'";
            podaciDataSet = this.DajPodatke(upit);
            return podaciDataSet;
        }

        public bool SnimiNovuIntervenciju(IntervencijaClass novaIntervencijaObjectParametar)
        {
            bool uspeh = false;
            uspeh = this.IzvrsiAzuriranje("INSERT INTO intervencija(pacijent_jmbg, naziv_intervencije, datum_intervencije, vreme_intervencije, prezime_pacijent, ime_pacijent, prezime_stomatologa, komentar_intervencije) VALUES (" + novaIntervencijaObjectParametar.pacijent_jmbg + ", '" + novaIntervencijaObjectParametar.naziv_intervencije + "', '" + novaIntervencijaObjectParametar.datum_intervencije + "','" + novaIntervencijaObjectParametar.vreme_intervencije + "', '" + novaIntervencijaObjectParametar.prezime_pacijent + "', '" + novaIntervencijaObjectParametar.ime_pacijent + "', '" + novaIntervencijaObjectParametar.prezime_stomatologa + "', '" + novaIntervencijaObjectParametar.komentar_intervencije + "')");
            return uspeh;
        }

        public bool ObrisiIntervenciju(int intervencijaZaBrisanjeObjectParametar)
        {
            bool uspeh = false;
            uspeh = this.IzvrsiAzuriranje("DELETE FROM intervencija where intervencija_id=" + intervencijaZaBrisanjeObjectParametar + "");
            return uspeh;
        }

        public bool IzmeniIntervenciju(int staraIntervencijaObjectParametar, IntervencijaClass novaIntervencijaObjectParametar)
        {
            bool uspeh = false;
            string upit = "";
            upit = "UPDATE intervencija SET pacijent_jmbg=" + novaIntervencijaObjectParametar.pacijent_jmbg + ", naziv_intervencije='" + novaIntervencijaObjectParametar.naziv_intervencije + "', datum_intervencije='" + novaIntervencijaObjectParametar.datum_intervencije + "', vreme_intervencije='" + novaIntervencijaObjectParametar.vreme_intervencije + "', prezime_pacijent='" + novaIntervencijaObjectParametar.prezime_pacijent + "', ime_pacijent='" + novaIntervencijaObjectParametar.ime_pacijent + "', prezime_stomatologa='" + novaIntervencijaObjectParametar.prezime_stomatologa + "', komentar_intervencije='" + novaIntervencijaObjectParametar.komentar_intervencije + "' WHERE intervencija_id=" + staraIntervencijaObjectParametar + "";
            uspeh = this.IzvrsiAzuriranje(upit);
            return uspeh;
        }

        public DataSet DajSelektovanuIntervenciju(int ID)
        {
            DataSet podaciDataSet = new DataSet();
            podaciDataSet = this.DajPodatke("Select * from Intervencija where intervencija_id =" + ID + "");
            return podaciDataSet;
        }



        #endregion JAVNE METODE
    }
}