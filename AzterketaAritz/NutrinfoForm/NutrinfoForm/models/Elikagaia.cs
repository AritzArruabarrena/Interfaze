﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.models
{
    internal class Elikagaia
    {
        [Key]
        public int Id { get; set; }
        public string Izena { get; set; }
        public string Marka { get; set; }

    }
}
