﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public class Adres

    {
        public Adres()
        {

        }
        public Adres(int adresId)
        {
            AdresId = adresId;
        }

        public int AdresId { get; private set; }

        public int AdresTyp { get; set; }

        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }


    }
}
