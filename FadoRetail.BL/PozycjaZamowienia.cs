using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {
                
        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }
        public int PozycjaZamowieniaId { get; private set; }

        public int Ilosc { get; set; }

        public int ProduktId { get; set; }

        public decimal? CanaZakupu { get; set; }

        // Metody

        /// <summary>
        /// Sprawdza dane pozycji zamówienia
        /// </summary>
        /// <returns> </returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CanaZakupu == null)
                poprawne = false;
            return poprawne;
        }

        /// <summary>
        /// Metoda element zmówienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // zapisuje element zmówienia
            return true;
        }

        /// <summary>
        /// Pobiera jeden element zmówienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            // kod który pobiera określone zamówienie
            return new PozycjaZamowienia();
        }
    }
}