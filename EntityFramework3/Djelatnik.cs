using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
   public class Djelatnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public  string Prezime { get; set; }
        public int OIB { get; set; }

        //navigation property
        public virtual DetaljiZaposlenika Detalji { get; set; }
    }
}
