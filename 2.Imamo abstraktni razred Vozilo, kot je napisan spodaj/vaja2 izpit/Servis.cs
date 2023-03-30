using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja2_izpit
{
     class Servis
    {
        private double cenaServisa;
        private DateTime datumServisa;
        private string pooblaščenec;
        private int štKm;

        public Servis(DateTime datumServisa, string pooblaščenec, int štKm, double cenaServisa)
        {
            this.datumServisa = datumServisa;
            this.pooblaščenec = pooblaščenec;
            this.štKm = štKm;
            this.cenaServisa = cenaServisa;
        }

        public string IzpišiEnServis()
        {
            return $"Datum servisa: {datumServisa.ToShortDateString()}, Pooblaščenec: {pooblaščenec}, Število prevoženih km: {štKm}, Cena servisa: {cenaServisa} EUR";
        }
    }
}
