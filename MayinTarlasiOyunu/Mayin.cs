using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasiOyunu
{
    public class Mayin
    {
        Point loc;
        bool dolu;
        bool bakildiMi;

        public Mayin(Point loca)
        {
            dolu = false;
            loc = loca;
        }


        public Point konumAl
        {
            get { return loc; }
        }


        public bool mayinVarmi
        {
            get { return dolu; }
            set { dolu = value; }
        }


        public bool BakildiMi
        {
            get { return bakildiMi; }
            set { bakildiMi = value; }
        }





    }
}
