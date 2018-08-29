using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klasseopgave
{
    class Ansat
    {
        public string Fornavn;
        public string Efternavn;
        public string Adresse;
        public int Tlfnr;
        public double Løn;
        public double Provsion;

        public double UdskrivProvision()
        {
            double ProvisionLøn = Løn * Provsion;
            return ProvisionLøn;
        }

        public double UdskrivTotalLøn()
        {
            double TotalLøn = Løn + (Løn * Provsion);
            return TotalLøn;
        }
    }
}
