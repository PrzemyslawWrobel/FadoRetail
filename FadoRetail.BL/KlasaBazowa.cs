using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadoRetail.BL
{
    public abstract class KlasaBazowa
    {

        public bool JestNowy { get; set; }

        public bool MaZmiany { get; set; }

        public StanObjektuOpcje StanObjektu { get; set; }

        public bool DanePrawidlowe
        {
            get
            {
                return true;
            }
        }
    }
        public enum StanObjektuOpcje
        {
            Aktywny,
            Usuniety
        }


    }

