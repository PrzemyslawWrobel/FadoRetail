using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FadoRetail.BL.Test
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            // Arrange (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "FidoDido"
            };
            //Avt (działaj)

            var aktualna = klientRepository.Pobierz(1);
            //Asert (potwierdź)
            //Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
        }
        [TestMethod]
        public void PobierzKlientaZadresamiTest()
        {
            // Arrange (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "FidoDido",
                ListaAdresow = new List<Adres>()
                {
                    new Adres()
                    {
                        AdresTyp = 1,
                        Ulica = "Tuwima",
                        Miasto = "Bielsko-Biała",
                        Kraj = "PL",
                        KodPocztowy = "43-300"
                    },
                    new Adres(3)
                    {
                        AdresTyp = 3,
                        Ulica = "Kwiatowa",
                        Miasto = "Bielsko-Biała",
                        Kraj = "PL",
                        KodPocztowy = "43-300"
                    }
                }
            };
            //Avt (działaj)

            var aktualna = klientRepository.Pobierz(1);
            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
            }
        }
    }
}
// Arrange (przygotuj test)
//Avt (działaj)
//Asert (potwierdź)