using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KlasePodataka
{
    public class IntervencijaClass
    // NAMENA:
    /* CRC karta - Class Responsibility Collaboration:  */
    //-----------------------------------------------------
    /* ODGOVORNOST: Klasa tipa pojedinac (ima samo atribute i property) za rad sa zvanjem */
    /* ZAVISNOST U ODNOSU NA DRUGE KLASE: nema
     */
    {
        #region ATRIBUTI

        private int _intervencija_id;
        private string _pacijent_jmbg;
        private string _naziv_intervencije;
        private string _datum_intervencije;
        private string _vreme_intervencije;
        private string _prezime_pacijent;
        private string _ime_pacijent;
        private string _prezime_stomatologa;
        private string _komentar_intervencije;

        #endregion ATRIBUTI

        #region PROPERTY

        // property
        public int intervencija_id
        {
            get { return _intervencija_id; }
            set { _intervencija_id = value; }
        }

        public string pacijent_jmbg
        {
            get
            {
                return _pacijent_jmbg;
            }
            set
            {
                if (this._pacijent_jmbg != value)
                    this._pacijent_jmbg = value;
            }
        }

        public string naziv_intervencije
        {
            get
            {
                return _naziv_intervencije;
            }
            set
            {
                if (this._naziv_intervencije != value)
                    this._naziv_intervencije = value;
            }
        }

        public string datum_intervencije
        {
            get
            {
                return _datum_intervencije;
            }
            set
            {
                if (this._datum_intervencije != value)
                    this._datum_intervencije = value;
            }
        }

        public string vreme_intervencije
        {
            get
            {
                return _vreme_intervencije;
            }
            set
            {
                if (this._vreme_intervencije != value)
                    this._vreme_intervencije = value;
            }
        }

        public string prezime_pacijent
        {
            get
            {
                return _prezime_pacijent;
            }
            set
            {
                if (this._prezime_pacijent != value)
                    this._prezime_pacijent = value;
            }
        }

        public string ime_pacijent
        {
            get
            {
                return _ime_pacijent;
            }
            set
            {
                if (this._ime_pacijent != value)
                    this._ime_pacijent = value;
            }
        }

        public string prezime_stomatologa
        {
            get
            {
                return _prezime_stomatologa;
            }
            set
            {
                if (this._prezime_stomatologa != value)
                    this._prezime_stomatologa = value;
            }
        }

        public string komentar_intervencije
        {
            get
            {
                return _komentar_intervencije;
            }
            set
            {
                if (this._komentar_intervencije != value)
                    this._komentar_intervencije = value;
            }
        }

        #endregion PROPERTY

        #region KONSTRUKTOR

        // konstruktor
        public IntervencijaClass()
        {
            _intervencija_id = 0;
            _pacijent_jmbg = "";
            _naziv_intervencije = "";
            _datum_intervencije = "";
            _vreme_intervencije = "";
            _prezime_pacijent = "";
            _ime_pacijent = "";
            _prezime_stomatologa = "";
            _komentar_intervencije = "";
        }

        #endregion KONSTRUKTOR

        // privatne metode

        // javne metode
    }
}