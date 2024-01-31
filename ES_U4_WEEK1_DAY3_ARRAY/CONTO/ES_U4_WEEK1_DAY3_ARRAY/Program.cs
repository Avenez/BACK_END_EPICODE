using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ES_U4_WEEK1_DAY3_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            //------------------------------------------------- Esercizio 1 ------------------------------------------------


            // Inizializzo l'algoritmo con un semplice y/n
            Console.WriteLine("desideri creare un conto ? y/n");
            string risposta = Console.ReadLine();



            // In caso di risposta positiva creo le variabili che inserirò nel costruttore del conto
            if (risposta != "n")
            {
                long saldo;
                string nome;
                string cognome;

                Console.WriteLine("Inserisci il tuo Nome");
                nome = Console.ReadLine();
                Console.WriteLine("Inserisci il tuo Cognome");
                cognome = Console.ReadLine();



                // Coontrollo che il saldo iniziale sia di almeno 1000€
                bool saldoBaseCorretto = true;
                saldo = 0;

                while (saldoBaseCorretto)
                {
                    Console.WriteLine("Devi effettuare un primo deposito di almeno 1000 euro per poter aprire un conto " +
                        "\nQuanto desideri versare ?");
                    saldo = Convert.ToInt64(Console.ReadLine());
                    if (saldo < 1000)
                    {
                        Console.WriteLine("Non puoi aprire un conto con meno di 1000 Euro");
                    }
                    else
                    {

                        saldoBaseCorretto = false;
                    }

                }



                //Se tutto è  andato a buon fine creo il conto con il costruttore che assegnerà un _id univoco

                ContoCorrente conto1 = new ContoCorrente(nome, cognome, saldo);
                Console.WriteLine("Il tuo conto è stato creato");
                Console.WriteLine("Qui i tuoi dettagli");
                conto1.Dettagli();




                // Simulo la volontà di vole effettuare una operazione tramite i metodi creati nella classe
                Console.WriteLine("Vuoi effettuare delle operazioni sul tuo conto ? y/n");
                string scelta = Console.ReadLine();
                if (scelta == "y") {
                    bool controlloOperazioni = true;

                    while (controlloOperazioni)
                    {
                        Console.WriteLine("Che tipo di operazione vuoi effettuare?");
                        Console.WriteLine("1: Prelievo \n2:Versamento");
                        string operazione = Console.ReadLine();
                        switch (operazione)
                        {
                            case "1":
                                conto1.Prelievo();
                                controlloOperazioni = false;
                                break;

                            case "2":
                                conto1.Versamento();
                                controlloOperazioni = false;
                                break;

                            default: Console.WriteLine("Non hai scelto una operazione valida");
                                break;

                        }
    
                }

                }
               

            // in caso non si voglia creare un conto il programma esce ma non si chiude fino alla pressione di un tasto
            }
            else {
                Console.WriteLine("Allora grazie e buone giornata !");
            }

            

                Console.ReadLine();
            }
    }
}
