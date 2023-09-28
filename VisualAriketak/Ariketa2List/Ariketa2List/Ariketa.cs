using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2List
{
    internal class Ariketa
    {

        public string Label { get; set; }
        public double Zenbakia { get; set; }
        public Ariketa(double zenbakia)
        {
            this.Zenbakia = zenbakia;
        }


        public static double Eragiketa(List<Ariketa> objetuak)
        {
            double emaitza = (objetuak[0].Zenbakia + (2 * objetuak[1].Zenbakia) + (3 * objetuak[2].Zenbakia) + (4 * objetuak[3].Zenbakia)) / 4;
            return emaitza;
        }
    }
}
