using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa1
{
    internal class Esaldia
    {
        public String Esaldiak { get; set; }
        public String EsaldiakLotuta { get; set;}

        public void Batu()
        {
            EsaldiakLotuta += "" + Esaldiak;
        }
    }
}
