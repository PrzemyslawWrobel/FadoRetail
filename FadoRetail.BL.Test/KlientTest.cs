using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FadoRetail.BL.Test
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {


            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Piotr";
            klient.Nazwisko = "Lama";

            string oczekiwana = "Piotr, Lama";

            //Avt (działaj)
            string aktulna = klient.ImieNazwizko;

            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana, aktulna);

        }

        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {


            // Arrange (przygotuj test)
            Klient klient = new Klient();
           
            klient.Nazwisko = "Lama";

            string oczekiwana = "Lama";

            //Avt (działaj)
            string aktulna = klient.ImieNazwizko;

            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana, aktulna);

        }
        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {


            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Piotr";
          

            string oczekiwana = "Piotr";

            //Avt (działaj)
            string aktulna = klient.ImieNazwizko;

            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana, aktulna);

        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (przygotuj test)
            var kln1 = new Klient();
            kln1.Imie = "Jacek";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln1.Imie = "Maciek";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln1.Imie = "Irek";
            Klient.Licznik += 1;

            //Avt (działaj)


            //Asert (potwierdź)
            Assert.AreEqual(3, Klient.Licznik);

        }

        [TestMethod]
        public void ZwalidujTest()
        {
            // Arrange (przygotuj test)
            var klient = new Klient();
            klient.Nazwisko = "Kowal";
            klient.Email = "marcin@dev-hobby.pl";
            var oczekiwana = true;

            //Avt (działaj)
            var aktualna = klient.Zwaliduj();

            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujTestBrakNazwiska()
        {
            // Arrange (przygotuj test)
            var klient = new Klient();
            klient.Email = "marcin@dev-hobby.pl";
            var oczekiwana = false;

            //Avt (działaj)
            var aktualna = klient.Zwaliduj();

            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujTestBrakEmail()
        {
            // Arrange (przygotuj test)
            var klient = new Klient();
            klient.Nazwisko = "Kowal";
            var oczekiwana = false;

            //Avt (działaj)
            var aktualna = klient.Zwaliduj();

            //Asert (potwierdź)
            Assert.AreEqual(oczekiwana, aktualna);
        }


    }
}
