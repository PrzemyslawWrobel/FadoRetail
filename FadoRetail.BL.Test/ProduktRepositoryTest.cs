using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FadoRetail.BL.Test
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProduktTest()
        {
            // Arrange (przygotuj test)

            var produktRepository = new ProduktRepository();
            var oczekiwana = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 89.89M,
            };
            //Avt (działaj)
            var aktualne = produktRepository.Pobierz(5);


            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana.ProduktId, aktualne.ProduktId);
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualne.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis, aktualne.Opis);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualne.AktualnaCena);
        }
    }
}
