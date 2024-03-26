using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarNo2Library.Models
{
    public class Kolcsonzo
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string SzulIdo { get; set; }
        public ICollection<Kolcsonzes> Kolcsonzes { get; set; }
        //Név;Születési dátum

        public Kolcsonzo() { }
        public Kolcsonzo(string sor)
        {
            string[] adatok = sor.Split(';');

            Nev = adatok[0];
            SzulIdo = adatok[1];
        }
    }
}
