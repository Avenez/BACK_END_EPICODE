using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Atleta atleta1 = new Atleta("Mario", "Rossi", "Calcio" );

            atleta1.saluta();
            atleta1.salta(50);
            Console.WriteLine(atleta1.dichiaraSport());
            Console.WriteLine("\n");

            atleta1.Nome = "Carlo";
            atleta1.Cognome = "Verdi";
            atleta1.Sport = "Rugby";

            atleta1.saluta();
            atleta1.salta(100);
            Console.WriteLine(atleta1.dichiaraSport());
            Console.WriteLine("\n");


            Dipendente dipendente1 = new Dipendente("Mauro", "Giallo", "Scatolatore");

            dipendente1.saluta();
            Console.WriteLine(dipendente1.dichiaraMansione());


            Console.WriteLine("\n");


            Animale animale1 = new Animale("Giorgio", "Leone", "Ruggito");
            animale1.saluta();
            Console.WriteLine(animale1.versaIlVerso());
            Console.WriteLine(animale1.Verso);


            Console.WriteLine("\n");


            Veicolo veicolo1 = new Veicolo("Subaru", "Baracca", 100000);
            Console.WriteLine(veicolo1.Marca + "\n" + veicolo1.Nome + "\n" + veicolo1.Kilometri );
            veicolo1.accelera(100);


            Console.WriteLine("\n");







            Console.ReadLine();





        }
    }
}




