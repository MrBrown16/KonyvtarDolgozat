using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarNo2Library.Models
{
    public class Kolcsonzes
    {
        public int Id { get; set; }
        public int KolcsonzoId { get; set; }
        public string Iro { get;  set; }
        public string Mufaj { get; set;}
        public string Cim { get; set;}
        //KolcsonzoId;Író;Műfaj;Cím

        public Kolcsonzes() { }
        public Kolcsonzes(string sor)
        {

            string[] adatok = sor.Split(';');
            KolcsonzoId = Int32.Parse(adatok[0]);
            Iro = adatok[1];
            Mufaj = adatok[2];
            Cim = adatok[3];


        }

    }
}
