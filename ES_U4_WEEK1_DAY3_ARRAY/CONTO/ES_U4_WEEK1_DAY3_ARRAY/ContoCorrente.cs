using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_U4_WEEK1_DAY3_ARRAY
{
    internal class ContoCorrente
    {

        private int _id;
        private string nome;
        private string cognome;
        private long saldo;

        public ContoCorrente() { }
        public ContoCorrente(string nome, string cognome, long saldo) {
            this.nome = nome;
            this.cognome = cognome;
            this.saldo = saldo;


            Random random = new Random();
            int id = random.Next(10000, 100000);
            //genero un numero casuale e lo salvo in una variabile per poi aggiungerlo successivamente ad un
            //arrayList di controllo in una classe banca in modo da non assegnare sempre lo stesso id
            //In questo punto posso aggiungere una condizione di controllo che se trova l'id tra quelli salvati 
            //ne genera un altro e solo quando non lo trova lo assegna al conto e lo aggiunge all'arrayList di controllo

            this._id = id;
        }


        //getter e setter ---------------------------------
        public string Nome {
            get => this.nome;
            set => this.nome = value;
            }

        public string Cognome
        {
            get => this.cognome;
            set => this.cognome = value;
        }

        public long Saldo
        {
            get => this.saldo;
            set => this.saldo = value;
        }


        // metodo per ottenere i dettagli-----------------------------------
        public void Dettagli()
        {
            Console.WriteLine($" Nome:{nome} \n Cognome:{cognome} \n Saldo:{saldo} \n Id:{_id}");
        }

        // metodo per il versamento-----------------------------------------
        public void Versamento() {
            Console.WriteLine("Inserisci la cifra che desideri depositare");
            long versamento = Convert.ToInt64(Console.ReadLine());
            this.saldo += versamento;
            Console.WriteLine($"Hai depositato {versamento} Euro ");
            Console.WriteLine($"Grazie e Buona Giornata");
        }



        //metodo per il prelievo---------------------------------------------
        public void Prelievo()
        {
            bool controllo = true;


            while (controllo) {
                Console.WriteLine("Inserisci la cifra che desideri prelevare");
                long prelievo = Convert.ToInt64(Console.ReadLine());
                


                if (prelievo < this.saldo)
                {

                    this.saldo -= prelievo;
                    Console.WriteLine($"Hai prelevato {prelievo} Euro ");
                    Console.WriteLine($"Grazie e Buona Giornata");
                    controllo = false;
                }
                else
                {

                    Console.WriteLine("Non puoi prelevare più di quello che c'è sul tuo conto");
                    

                }

            }
  
        }
        
        }

    }

