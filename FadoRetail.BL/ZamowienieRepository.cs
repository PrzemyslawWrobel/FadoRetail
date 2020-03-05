using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class ZamowienieRepository
    {

        /// <summary>
        /// Pobiera jedno zamówienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);
            // kod który pobiera określone zamówienie

            //Tymczasowo zakodowane
            if (zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2020, 3, 4, 11, 00, 00, new TimeSpan(7, 0, 0));

            }

            return zamowienie;
        }

        /// <summary>
        /// Pobiera wszystkie zamówienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> PobierzWszystkich()
        {
            // kod który pobiera wszystkie zamówienia
            return new List<Zamowienie>();
        }

        /// <summary>
        /// Metoda zapisuje zmówienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // zapisuje zdefiniowane zamówienie
            return true;
        }

        /// <summary>
        /// Pobierz jedno zamowienie do wyświetlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyświetlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();
            // Kod który pobiera zdefiniowane pola zamowienia

            //Tymczasowa zakodowane dane na stałe

            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Jacek";
                wyswietlanieZamowienia.Nazwisko = "Pitu";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2020, 3, 4, 12, 00, 00, new TimeSpan(5, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Fiołków",
                    Miasto = "Bielsko-Białą",
                    Kraj = "PL",
                    KodPocztowy = "43-300"
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniasLista = new List<WyswietlaniePozycjiZamowienia>();
                // Kod który pobiera elementy zamowienia

                //Tymczasowa zakodowane dane na stałe

                if (zamowienieId == 10)
                {
                    var wyswietleniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stół",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniasLista.Add(wyswietleniePozycjiZamowienia);

                    wyswietleniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Krzesłp",
                        CenaZakupu = 300.50M,
                        Ilosc = 8
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniasLista.Add(wyswietleniePozycjiZamowienia);
                }

            }
            return wyswietlanieZamowienia;
        }
    }
}
