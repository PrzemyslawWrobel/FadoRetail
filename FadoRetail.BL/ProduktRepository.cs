using System.Collections.Generic;

namespace FadoRetail.BL
{
    public class ProduktRepository
    {
      
        /// <summary>
        /// Pobiera jeden  produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // tworzenie instancji produktu

            Produkt produkt = new Produkt(produktId);
            object mojobject = new object();
            System.Console.WriteLine("Obiekt : " + mojobject.ToString());
            System.Console.WriteLine( " obiekt : " + produkt.ToString() );

            // tymczasowo zakodowany produkt

            if(produktId ==5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.89M;
            }
            return produkt;
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

        /// <summary>
        /// Metoda zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // zapisuje zdefiniowany produkt
            return true;
        }

    }
}
