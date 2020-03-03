using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class Klient
    {

        // konstruktor bezparametrowy - domyślny
        public Klient()
        {

        }

        public Klient(int klientId)
        {
            this.KlientId = klientId;      
        }
        // właściwości
        #region właściwości
        public static int Licznik { get; set; }

        private string _nazwisko;

        public string Nazwisko {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwizko
        {
            get
            {
                string imieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if(!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }
        #endregion 
        
        // Metody

        /// <summary>
        /// Sprawdza czy wprowadzono dane
        /// </summary>
        /// <returns> </returns>
        public bool Zwaliduj()
        {
            var  poprawne = true;
            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;

            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;


            return poprawne;
        }

        /// <summary>
        /// Metoda zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //
            return true;
        }

        /// <summary>
        /// Pobiera klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            // kod który pobiera określonego klienta
            return new Klient();
        }

        /// <summary>
        /// Pobiera wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> PobierzWszystkich()
        {
            // kod który pobiera wszystkich klientów
            return new List<Klient>();
        }

    }
}
