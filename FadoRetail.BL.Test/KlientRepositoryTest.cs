using System;
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
    }
}
// Arrange (przygotuj test)
//Avt (działaj)
//Asert (potwierdź)