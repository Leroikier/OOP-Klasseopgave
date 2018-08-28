using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klasseopgave
{
    class Produkt
    {
        public double Pris;
        public double Kg;
        public string Stoerrelse;

        

        public double Moms()
        {
            Pris = Pris * 1.25;
            return Pris;
        }
    }
}
