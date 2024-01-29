using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
    {
        public string nome;
        public string cognome;
        public string mansione;


        public Dipendente(string nome, string cognome, string mansione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.mansione = mansione;
        }


        public string Nome
        {

            get { return nome; }

            set
            {

                nome = value;

            }
        }

        public string Cognome
        {

            get { return cognome; }

            set
            {

                cognome = value;

            }


        }

        public string Mansione
        {

            get { return mansione; }

            set
            {

                mansione = value;

            }


        }


        public void saluta() {

            Console.WriteLine($"Ciao io sono {Nome} {Cognome} e svolgo la mansione di {Mansione}");
        
        }


        public string dichiaraMansione() {

            return mansione;
        }

    }



}
