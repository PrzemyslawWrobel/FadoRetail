using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace CommonTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {

            // Arrange (przygotuj test)

            var zrodlo = "StółOgrodowy";
            var oczekiwana = "Stół Ogrodowy";
            //Act (działaj)

            var aktualna = ObslugaStringa.WstawSpacje(zrodlo);
            Assert.AreEqual(oczekiwana, aktualna);
            //Asert (potwierdź)

        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {

            // Arrange (przygotuj test)

            var zrodlo = "Stół Ogrodowy";
            var oczekiwana = "Stół Ogrodowy";
            //Act (działaj)

            var aktualna = ObslugaStringa.WstawSpacje(zrodlo);
            Assert.AreEqual(oczekiwana, aktualna);
            //Asert (potwierdź)

        }

        //dopisać resztę testów np na duże litery albo pusty string
    }
}
