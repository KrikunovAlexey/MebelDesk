using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelDesk
{
    public class Stol_dveri
    {
        public Detal stoika;
        public Detal dnishe;
        public Detal carga;
        public Detal polka;
        public Detal dveri;
        public Stol_dveri(Detal stoika, Detal dnishe, Detal carga, Detal polka, Detal dveri)
        {
            this.stoika = stoika;
            this.dnishe = dnishe;
            this.carga = carga;
            this.polka = polka;
            this.dveri = dveri;
        }
    }
}
