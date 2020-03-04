﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class WyswietlanieZamowienia
    {
        #region Właściwości
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<WyswietlaniePozycjiZamowienia> WyswietlaniePozycjiZamowieniasLista { get; set; }
        public int ZamowienieId { get; set; }
        public Adres AdresDostawy { get; set; }
        #endregion
    }
}
