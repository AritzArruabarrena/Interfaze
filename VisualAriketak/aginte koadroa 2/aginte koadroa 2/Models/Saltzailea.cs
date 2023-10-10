using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aginte_koadroa_2.Models
{
    public partial class Saltzailea
    {
        [Key]
        public string id { get; set; }
        public string Izena { get; set; }
        public string Taldea { get; set; }
        public virtual List<Bezeroa> Bezeroa { get; set; }
    }
}
