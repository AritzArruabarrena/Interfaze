using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriketaAzterketa.Models
{
    internal class Errezeta
    {
        [Key]
        public int Id {  get; set; }
        public string Izena { get; set; }
        public string Deskribapena { get; set; }

    }
}
