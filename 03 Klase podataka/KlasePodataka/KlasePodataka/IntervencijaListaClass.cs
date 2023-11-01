using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KlasePodataka
{
    public class IntervencijaListaClass
    /* CRC karta - Class Responsibility Collaboration:  */
    //-----------------------------------------------------
    /* ODGOVORNOST: Klasa tipa liste koja sadrzi kao elemente objekte klase tipa pojedinac ZvanjeClass */
    /* ZAVISNOST U ODNOSU NA DRUGE KLASE:
     Standardna klasa iz System.Collections.Generic - List
     Sopstvena klasa iz ove biblioteke - ZvanjeClass
     */
    {
        #region ATRIBUTI

        private List<IntervencijaClass> _listaIntervencija;

        #endregion ATRIBUTI

        #region PROPERTY

        // property
        public List<IntervencijaClass> ListaIntervencija
        {
            get
            {
                return _listaIntervencija;
            }
            set
            {
                if (this._listaIntervencija != value)
                    this._listaIntervencija = value;
            }
        }

        #endregion PROPERTY

        #region KONSTRUKTOR

        public IntervencijaListaClass()
        {
            _listaIntervencija = new List<IntervencijaClass>();
        }

        #endregion KONSTRUKTOR

        // privatne metode

        #region JAVNE METODE

        public void DodajElementListe(IntervencijaClass NovaIntervencijaParametar)
        {
            _listaIntervencija.Add(NovaIntervencijaParametar);
        }

        public void ObrisiElementListe(IntervencijaClass IntervencijaZaBrisanjeParametar)
        {
            _listaIntervencija.Remove(IntervencijaZaBrisanjeParametar);
        }

        public void ObrisiElementNaPoziciji(int pozicija)
        {
            _listaIntervencija.RemoveAt(pozicija);
        }

        public void IzmeniElementListe(IntervencijaClass objStaraIntervencijaParametar, IntervencijaClass NovaIntervencijaParametar)
        {
            int indexStareIntervencije = 0;
            indexStareIntervencije = _listaIntervencija.IndexOf(objStaraIntervencijaParametar);
            _listaIntervencija.RemoveAt(indexStareIntervencije);
            _listaIntervencija.Insert(indexStareIntervencije, NovaIntervencijaParametar);
        }

        #endregion JAVNE METODE
    }
}