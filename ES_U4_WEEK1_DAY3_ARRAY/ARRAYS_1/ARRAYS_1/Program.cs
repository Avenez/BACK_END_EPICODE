using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------- Esercizio 2 -------------------------------------------------
            string[] nomi = { "Marco", "Pietro", "Gaspare", "Giovanni", "Salvatore" };


            // creo un array di 5 nomi e inserisco i nomi
            string[] nomi2 = new string[5];
            Console.WriteLine("Inserisci 5 Nomi");

            for (int i = 0; i < nomi.Length; i++) {
                Console.WriteLine($"Inserisci in nome numero {i+1}");
                string nome = Console.ReadLine();
                nomi2[i] = nome;
            
            }




            // controllo che un nome sia nell'array con un ciclo ForEach e una confisione If
            Console.WriteLine("Inserisci il nome che stai cercando!");
            string nomeRicerca = Console.ReadLine();
            foreach (string nome in nomi2) 
            {
                if (nomeRicerca.ToLower() == nome.ToLower())
                {
                    Console.WriteLine("Il nome che stai cercando è presente nella lista");
                    Console.WriteLine($"{nome}");
                    break;
                }
                else
                {

                    Console.WriteLine("Il nome che stai cercando non è in questa lista");
                    break;
                }

            }


            //----------------------------------------- Esercizio 3 -------------------------------------------


            // Inserisco la lunghezza dell'array di numeri tramite input
            Console.WriteLine("Inserisci la lunghezza della lista desiderata!");
            int lunghezzaLista = Convert.ToInt32(Console.ReadLine());
            int[] numeri = new int[lunghezzaLista];


            // prendo i numeri in input con un ciclo for
            Console.WriteLine($"Inserisci {Convert.ToString(lunghezzaLista)} numeri a tua scelta");
            for (int i = 0; i < numeri.Length; i++) {
            
                int numDaInserire = Convert.ToInt32(Console.ReadLine());
                numeri[i] = numDaInserire;
            
            } ;


            // calco somma e media dei numeri nell'array con un foreach nel primo caso e un semplice calcolo nel secondo
            int somma = 0;

            foreach (int num in numeri) { 
            
                somma += num;
            
            }

            int media = somma/numeri.Length;

            Console.WriteLine($"Somma: {somma}");
            Console.WriteLine($"Media: {media}");






            Console.ReadLine();

        }
    }
}
