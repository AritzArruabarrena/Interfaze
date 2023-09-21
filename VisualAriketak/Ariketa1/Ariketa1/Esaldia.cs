using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa1
{
    internal class Esaldia
    {
        public string Esaldiak { get; set; }
        public string EsaldiakLotuta { get; set;}

        public void Batu()
        {
            EsaldiakLotuta += "" + Esaldiak;
        }
    }
}
