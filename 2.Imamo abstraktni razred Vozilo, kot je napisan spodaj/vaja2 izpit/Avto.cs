using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja2_izpit
{
    class Avto : Vozilo
    {
        public Avto(string a, string b, int c, DateTime d) : base(a, b, 10, d)
        {
        }

        public override string Izpis()
        {
            string servisiIzpis = "";
            foreach (var servis in servisi)
            {
                if (servis != null)
                {
                    servisiIzpis += "\n" + servis.IzpišiEnServis();
                }
            }

            return $"Lastnik: {lastnik}, Registrska št.: {registrskaŠt}, Datum nakupa: {datumNakupa.ToShortDateString()}, Servisi: {servisiIzpis}";
        }

        public override void SpremeniLastnika(string novLastnik, DateTime datum)
        {
            lastnik = novLastnik;
            datumNakupa = datum;
        }
    }
    }
