using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    class AdresRepository
    {
        /// <summary>
        /// Pobiera jeden adres po ID
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            // Tworzymy instancję klasy Adres i przekazujemy żądany identyfikator
            Adres adres = new Adres(adresId);
            // Kod który pobiera zdefiniowany adres

            //Tymczasowo zakodowane wartości do zwrócenia adresu
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Bielsko-Biała";
                adres.Kraj = "PL";
                adres.KodPocztowy = "43-300";
            }

            return adres;
        }
        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta o przekaznym Id
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            // Kod który pobiera zdefiniowane adresy dla klienta

            //Tymczasowo zakodowane wartości do zwrócenia, zestaw adresów

            var listaAdresow = new List<Adres>();
            Adres adres = new Adres(2)
            {
                AdresTyp = 1,
                Ulica = "Tuwima",
                Miasto = "Bielsko-Biała",
                Kraj = "PL",
                KodPocztowy = "43-300"
            };
            listaAdresow.Add(adres);

           adres = new Adres(3)
            {
                AdresTyp = 3,
                Ulica = "Kwiatowa",
                Miasto = "Bielsko-Biała",
                Kraj = "PL",
                KodPocztowy = "43-300"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        /// <summary>
        /// Zapisuje aktualny adres
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            //Kod, który zapisuje zdefiniowany adres.

            return true;

        }
    }
}
