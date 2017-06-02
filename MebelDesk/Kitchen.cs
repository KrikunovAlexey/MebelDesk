using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelDesk
{
    class Kitchen
    {
        enum typeStol { Stol_dveri };
        List<Stol> stol;
        public Kitchen()
        {
            stol = new List<Stol>();
        }

        public void add(int sh, int ots, int dver, int kol_dver, int height, int pol, int kol_pol)
        {
            Detal stoika = new Detal(600 - 50 - ots, height - 16, 2);
            Detal dnishe = new Detal(sh, 600 - 50 - ots, 1);
            Detal carga = new Detal(sh - 32, 100, 2);
            Detal polka = null;
            Detal dveri = null;
            if (dver == 0)
            {
                if (pol == 0)
                {
                    polka = new Detal(sh - 32 - 2, 600 - 50 - ots - 10, kol_pol);
                }
                else
                {
                    polka = new Detal(sh - 32, 600 - 50 - ots - 10, kol_pol);
                }

                if (kol_dver == 0)
                {
                    dveri = new Detal(sh - 4, height - 6, 1);
                }
                else
                {
                    dveri = new Detal((sh - 8) / 2, height - 6, 2);
                }
            }
            else
            {
                if (pol == 0)
                {
                    polka = new Detal(sh - 32 - 2, 600 - 50 - ots - 40, kol_pol);
                }
                else
                {
                    polka = new Detal(sh - 32, 600 - 50 - ots - 40, kol_pol);
                }

                if (kol_dver == 0)
                {
                    dveri = new Detal(sh - 32 - 6, height - 32 - 6, 1);
                }
                else
                {
                    dveri = new Detal((sh - 32 - 8) / 2, height - 32 - 6, 2);
                }
            }
            Stol_dveri sd = new Stol_dveri(stoika, dnishe, carga, polka, dveri);
            stol.Add(new Stol((int)typeStol.Stol_dveri, sd));
        }

        public void show()
        {
            switch (stol[0].typeStol)
            {
                case (int)typeStol.Stol_dveri:
                    Stol_dveri sd = (Stol_dveri)stol[0].classStol;
                    new Show(sd).Show();
                    break;
            }
        }

        class Stol
        {
            public int typeStol;
            public object classStol;
            public Stol(int typeStol, object classStol)
            {
                this.typeStol = typeStol;
                this.classStol = classStol;
            }
        }
    }
}
