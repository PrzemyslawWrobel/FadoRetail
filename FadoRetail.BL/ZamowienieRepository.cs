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
            if(zamowienieId == 10)
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


    }
}
