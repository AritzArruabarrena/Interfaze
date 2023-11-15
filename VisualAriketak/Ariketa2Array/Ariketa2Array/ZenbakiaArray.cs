using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2Array
{
    internal class ZenbakiaArray
    {
        float[] zenbakiak = new float[4];

        public float[] Zenbakiak
        {
            get
            { return zenbakiak;
            }
            set { 
                zenbakiak = value;
            }
        }
        public float eragiketa { get; set; }

        public float eragiketaluzea() {
            return eragiketa = (zenbakiak[0] + 2 * zenbakiak[1] + 3 * zenbakiak[2] + 4 * zenbakiak[3]) / 4 ;
        }
    }
}
