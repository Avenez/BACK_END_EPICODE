using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {

        public string nome;
        public string cognome;
        public string sport;

        public Atleta(string nome, string cognome, string sport) {

            this.nome = nome;
            this.cognome = cognome;
            this.sport = sport;
        }

        public string Nome {
            get {
                return nome;

            }

            set {
            
                nome= value;

            }

        }


        public string Cognome
        {
            get
            {
                return cognome;

            }

            set
            {

                cognome = value;

            }

        }


        public string Sport
        {
            get
            {
                return sport;

            }

            set
            {

                sport = value;

            }

        }


        public void salta(int metri) {

            Console.WriteLine($"L'atleta {Nome} salta {metri} metri");
        
        }

        public void saluta() {
            Console.WriteLine($"Ciao io sono {Nome} {Cognome} e gioco a {Sport}");
        }


        public string dichiaraSport() {
            return Sport;
                }

    }
}
