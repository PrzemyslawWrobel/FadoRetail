using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FadoRetail.BL.Test
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            // Arrange (przygotuj test)

            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2020, 3, 4, 11, 00, 00, new TimeSpan(7, 0, 0))
            };
            //Avt (działaj)
            var aktualne = zamowienieRepository.Pobierz(10);


            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualne.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualne.DataZamowienia);
        }

        [TestMethod]
        public void PobierzZamowienieDoWyświetleniaTest()
        {
            // Arrange (przygotuj test)
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Jacek",
                Nazwisko = "Pitu",
                DataZamowienia = new DateTimeOffset(2020, 3, 4, 12, 00, 00, new TimeSpan(5, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Fiołków",
                    Miasto = "Bielsko-Białą",
                    Kraj = "PL",
                    KodPocztowy = "43-300"
                },
                WyswietlaniePozycjiZamowieniasLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                   new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stół",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    },


                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Krzesłp",
                        CenaZakupu = 300.50M,
                        Ilosc = 8
                    }
                }
            };
            //Act (działaj)
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyświetlenia(10);
            //Asert (potwierdź)

            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniasLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniasLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniasLista[i].Ilosc, aktualna.WyswietlaniePozycjiZamowieniasLista[i].Ilosc);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniasLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniasLista[i].CenaZakupu);
            }
        }

    }

    // Arrange (przygotuj test)
    //Act (działaj)
    //Asert (potwierdź)
}
