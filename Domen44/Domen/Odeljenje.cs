﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Odeljenje
    {
        public string Id_odeljenja { get; set; }
        public string Razredni { get; set; }
        public string Smer { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id_odeljenja, Razredni, Smer);
        }
    }
}
