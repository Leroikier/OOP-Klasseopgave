using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klasseopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //Der oprettes en masse personer
            Person p1 = new Person { Fornavn = "Abraham", Efternavn = "Lincoln", Adresse = "Istedgade 24b", Tlfnr = 72188942 };
            Person p2 = new Person { Fornavn = "Gilbert", Efternavn = "Skysovs", Adresse = "Friheden 99", Tlfnr = 32578913 };
            Person p3 = new Person { Fornavn = "Flomme", Efternavn = "Blomme", Adresse = "Æblevang", Tlfnr = 777334576 };
            Person p4 = new Person { Fornavn = "Biver", Efternavn = "Bjarnesen", Adresse = "Amagerbrogade 72", Tlfnr = 96130242 };
            Person p5 = new Person { Fornavn = "Alexandre", Efternavn = "The great", Adresse = "Tuborggade 12d", Tlfnr = 96130242 };

            Kunde k1 = new Kunde { Fornavn = "Niller", Efternavn = "Nielsen", Adresse = "Bagermagerstræde 22", Rabatgruppe = "RG1", Totalindkøb = 4 };

            Ansat a1 = new Ansat { Fornavn = "Jim", Efternavn = "Jones", Adresse = "Karlmarstræde", Tlfnr = 76524829, Løn = 24000, Provsion = 0.15 };
            
            //Der oprettes et nyt produkt
            Produkt pr1 = new Produkt { Pris = 100, Kg = 4, Stoerrelse = "2.1M" };

            //Produkets pris + Metoden moms bliver kaldt her - Opg 8
            Console.WriteLine(pr1.Moms() + "\n");

            //Her gives der parametre til den nye person som skal oprettes - Opg 9.1
            Person p6 = Person.Opretperson("Geroge", "Mofo", "Julemandsstræde", 88888888);
                                                                 
            //Udskrivning af den "nye" Person "p6" - Opg 9.1
            Console.WriteLine(p6.Fornavn + " " + p6.Efternavn + " " + p6.Adresse + " " + p6.Tlfnr + "\n");

            //Udskrivning af  metoden "Udskrivperson" som udskriver p3 - Opg 9.2
            Person.Udskrivperson(p3);
            Console.WriteLine();

            Console.WriteLine("Din provision = " + a1.UdskrivProvision() + " Kr." + "\n");

            Console.WriteLine("Din Total løn = " + a1.UdskrivTotalLøn() + " Kr."  + "\n");

            Console.ReadKey();
        }
    }
}
