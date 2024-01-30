using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPENDENTE_COSTRUTTORI
{
    internal class Dipendente
    {
        private string nome;
        private string cognome;
        private int eta;
        private string dipartimento;

        public Dipendente() { }

        public Dipendente(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        public Dipendente(string nome, string cognome, int eta, string dipartimento = "Logistica")
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.dipartimento = dipartimento;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }

        public string Dipartimento
        {
            get { return dipartimento; }
            set { dipartimento = value; }
        }

        public string GetDettagli()
        {
            return $"{nome} {cognome} {eta} {dipartimento}";
        }


        public static void defineTriangle(int lato1, int lato2 , int lato3) {

            if ((lato1 == lato2) && (lato1 == lato3) && (lato3 == lato2))
            { Console.WriteLine("Il triangolo è Equilatero"); }

            else if ((lato1 != 0 && lato2 == lato3) || (lato2 != 0 && lato1 == lato3) || (lato3 != 0 && lato2 == lato1) || (lato1 == lato2) || (lato1 == lato3) || (lato3 == lato2)) {

                Console.WriteLine("Il triangolo è Isoscele");

            } else if ((lato1 != lato2) && (lato1 != lato3) && (lato2 != lato3)) {

                Console.WriteLine("Il triangolo è Scaleno");

            } else {

                Console.WriteLine("Non hai fornito i lati di un trinagolo");

            }
        
        
        
        }

    }
}
