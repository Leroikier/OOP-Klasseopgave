using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klasseopgave
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public string Adresse;
        public int Tlfnr;

        public static Person Opretperson(string Fnavn, string Enavn, string  Adr, int Tlf)
        {
            Person p = new Person {Fornavn = Fnavn, Efternavn = Enavn, Adresse = Adr, Tlfnr = Tlf };
            return p;
        }

        public static Person Udskrivperson(string Fnavn, string Enavn, string Adr, int Tlf)
        {
            Person p = new Person { Fornavn = Fnavn, Efternavn = Enavn, Adresse = Adr, Tlfnr = Tlf };
            return p;
            Console.WriteLine();
        }
    }
}
