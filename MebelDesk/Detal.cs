using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebelDesk
{

    public class Detal
    {
        int x;
        int y;
        int kol;
        public Detal(int x, int y, int kol)
        {
            this.x = x;
            this.y = y;
            this.kol = kol;
        }
        public string getX()
        {
            return x.ToString();
        }
        public string getY()
        {
            return y.ToString();
        }
        public string getKol()
        {
            return kol.ToString();
        }
    }
}
