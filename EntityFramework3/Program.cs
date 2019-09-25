using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework3
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreContext db = new StoreContext();
            Djelatnik a = new Djelatnik();
            a.Ime = "Katarina";
            a.Prezime = "jos";

            DetaljiZaposlenika aDetalji = new DetaljiZaposlenika();
            aDetalji.Adresa = "adresa";
            aDetalji.Placa = 3000f;
            aDetalji.Telefon = 123456;
            a.Detalji = aDetalji;
            db.Djelatnici.Add(a);
            db.SaveChanges();

            foreach (var x in db.Djelatnici) {
                Console.WriteLine(x.Ime + " " + x.Detalji.Placa);
            }
            Console.Read();
        }
    }
}
