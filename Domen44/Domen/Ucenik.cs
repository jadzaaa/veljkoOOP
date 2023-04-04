using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domen
{
    public class Ucenik
    {
        [Browsable(false)]
        public int Jmbg { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Mesto Mesto { get; set; }
        public Odeljenje Odeljenje { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} ", Ime, Prezime, Mesto, Odeljenje);
        }
    }
}
