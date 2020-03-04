using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {
        }
        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        #region Właściwości
        public int ZamowienieId { get; private set; }

        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjaZamowienias { get; set; }
        public int KlientID { get; set; }
        public int AdresDostawyId { get; set; }
        #endregion
        #region Metody
        /// <summary>
        /// Sprawdza dane zamówienia
        /// </summary>
        /// <returns> </returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
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
        /// Pobiera jedno zamówienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // kod który pobiera określone zamówienie
            return new Zamowienie();
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
    }
#endregion
}
