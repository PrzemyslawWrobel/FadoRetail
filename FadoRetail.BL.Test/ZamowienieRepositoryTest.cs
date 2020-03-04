using System;
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
    }
}
