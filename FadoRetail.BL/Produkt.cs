using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class Produkt : KlasaBazowa
    {
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            this.ProduktId = produktId;
        }

        public int ProduktId { get; private set; }

        public Decimal? AktualnaCena { get; set; }

        public string Opis { get; set; }

        private string _NazwaProduktu;
        public string NazwaProduktu
        {
            get
            {
                return ObslugaStringa.WstawSpacje(_NazwaProduktu);
            }
            set { _NazwaProduktu = value; }
        }

        // Metody

        /// <summary>
        /// Sprawdza cdane produktu
        /// </summary>
        /// <returns> </returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;

            if (AktualnaCena == null)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Metoda zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // zapisuje zdefiniowany produkt
            return true;
        }

        /// <summary>
        /// Pobiera jeden  produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // kod który pobiera określony produkt
            return new Produkt();
        }

        /// <summary>
        /// Pobiera wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> PobierzWszystkich()
        {
            // kod który pobiera wszystkic
            return new List<Produkt>();
        }


        public override string ToString()
        {
            return NazwaProduktu;
        }


    }
}
