using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2
{
    internal class Zenbakiak
    {
        public float a{get;set;}
        public float b { get; set; }
        public float c{ get; set; }
        public float d { get; set; }

        public float eragiketa { get; set; }

        public float eragiketaluzea()
        {
            return eragiketa += (a + 2 * b + 3 * c + 4 * .d) / 4;
                
        }
    }
}
