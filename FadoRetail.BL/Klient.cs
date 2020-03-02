using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class Klient
    {
        // właściwości
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

        public int KlientID { get; private set; }

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


    }
}
