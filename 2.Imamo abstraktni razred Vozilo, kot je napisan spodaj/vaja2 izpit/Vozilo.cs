using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja2_izpit
{
    abstract class Vozilo
    {
        protected string lastnik;
        protected string registrskaŠt;
        protected DateTime datumNakupa;
        public Servis[] servisi;
        protected int številoServisovDoSedaj;
        public Vozilo(string a, string b, int c, DateTime d)
        {
            lastnik = a;
            registrskaŠt = b;
            številoServisovDoSedaj = c;
            datumNakupa = d;
            servisi = new Servis[številoServisovDoSedaj];
        }
        public abstract string Izpis();
        public abstract void SpremeniLastnika(string novLastnik, DateTime datum);
    }

}
