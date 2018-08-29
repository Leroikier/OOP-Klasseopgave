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

        //Metode til og oprette person. Stringsne er midlertidlige parametre
        public static Person Opretperson(string Fnavn, string Enavn, string  Adr, int Tlf)
        {
            //Opretter en ny person, som tar Fornavn feks og ligger den i den midlertidlige variabel
            Person p = new Person {Fornavn = Fnavn, Efternavn = Enavn, Adresse = Adr, Tlfnr = Tlf };
            return p;
        }


        //Metode til og udskrive en person fra objektet "Person" der oprettes en midlertidlig "Person" variabel "mP1"
        public static void Udskrivperson(Person mP1)
        {
            Console.WriteLine(mP1.Fornavn + " " + mP1.Efternavn + " " + mP1.Adresse + " " + mP1.Tlfnr);
        }
    }
}
