using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
   public class DetaljiZaposlenika
    {

        [ForeignKey("Djelatnik")]
        public int Id { get; set; }
        public float Placa { get; set; }
        public string Adresa { get; set; }
        public int Telefon { get; set; }

        //navigation property
        public  virtual Djelatnik Djelatnik { get; set; }
    }
}
