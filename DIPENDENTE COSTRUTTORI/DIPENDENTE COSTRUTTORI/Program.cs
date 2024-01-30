using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPENDENTE_COSTRUTTORI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dipendente dipendente1 = new Dipendente("Marco", "Perri", 30);
            Dipendente dipendente2 = new Dipendente("Giorgio", "Mastrotta", 44, "Amministrazione");
            Dipendente dipendente3 = new Dipendente("Aldo", "Baglio", 35);

            Console.WriteLine("\n");

            Console.WriteLine(dipendente1.Nome);
            Console.WriteLine(dipendente1.Cognome);
            Console.WriteLine(dipendente1.Eta);
            Console.WriteLine(dipendente1.Dipartimento);
            Console.WriteLine(dipendente1.GetDettagli());




            Console.WriteLine("\n");


            Console.WriteLine(dipendente2.Nome);
            Console.WriteLine(dipendente2.Cognome);
            Console.WriteLine(dipendente2.Eta);
            Console.WriteLine(dipendente2.Dipartimento);
            Console.WriteLine(dipendente2.GetDettagli());

            dipendente2.Dipartimento = "Distruzione";
            Console.WriteLine(dipendente2.GetDettagli());

            Console.WriteLine("\n");


            Console.WriteLine(dipendente3.Nome);
            Console.WriteLine(dipendente3.Cognome);
            Console.WriteLine(dipendente3.Eta);
            Console.WriteLine(dipendente3.Dipartimento);
            Console.WriteLine(dipendente3.GetDettagli());

            Console.WriteLine("\n");

            dipendente3.Dipartimento = "Vendite";
            Console.WriteLine(dipendente3.Dipartimento);
            Console.WriteLine(dipendente3.GetDettagli());


            Console.WriteLine("Indica la lunghezza del primo lato !");
            int lato1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Indica la lunghezza del secondo lato !");
            int lato2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Indica la lunghezza del terzo lato !");
            int lato3 = Convert.ToInt16( Console.ReadLine());

            Dipendente.defineTriangle(lato1, lato2, lato3);





            Console.ReadLine();
        }
    }
}
