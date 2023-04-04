using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Mesto
    {
        public int PttBroj { get; set; }
        public string Naziv { get; set; }
        public double Udaljenost { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", PttBroj, Naziv, Udaljenost);
        }
    }
}
