using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// Pobiera klienta
        /// </summary>
        /// <param name="klientID"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            // Tworzymy instancję określonego klienta
            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();
            // tymczasowo zakodowane wartości aby zwrócić klienta
            // kod który pobiera określonego klienta
            if (klientId == 1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "FidoDido";
 
            }

            return klient;
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

        /// <summary>
        /// Metoda zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //
            return true;
        }

    }
}
