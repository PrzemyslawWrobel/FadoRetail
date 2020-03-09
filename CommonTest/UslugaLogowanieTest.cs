using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using FadoRetail.BL;

namespace CommonTest
{
    /// <summary>
    /// Summary description for UslugaLogowanieTest
    /// </summary>
    [TestClass]
    public class UslugaLogowanieTest
    {


        [TestMethod]
        public void PiszDoPlikuTest()
        {
            // Arrange (przygotuj test)

            var zmienioneElementy = new List<ILogowanie>();
            var klient = new Klient()
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "FidoDido",
                ListaAdresow = null
            };

            zmienioneElementy.Add(klient as ILogowanie);

            var produkt = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 89.89M
            };

            var zamowienie = new Zamowienie(20)
            {
                DataZamowienia = new DateTime(2020, 3, 12, 11, 0, 0)
            };
            zmienioneElementy.Add(zamowienie as ILogowanie);

            zmienioneElementy.Add(produkt as ILogowanie);
            //Avt (działaj)

            UslugaLogowanie.PiszDoPliku(zmienioneElementy);
            //Asert (potwierdź)
        }
    }
}
