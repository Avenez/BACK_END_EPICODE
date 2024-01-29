using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animale
    {
        public string nome;
        public string razza;
        public string verso;

        public Animale(string nome, string razza, string verso) { 
        
            this.nome = nome;
            this.razza = razza; 
            this.verso = verso;

        }

        public string Nome { 
        
            get { return nome; }
            set { nome = value; }
        }


        public string Razza
        {

            get { return razza; }
            set { razza = value; }
        }

        public string Verso
        {

            get { return verso; }
            set { verso = value; }
        }

        public void saluta() {
            Console.WriteLine($"Ciao io sono {Nome} e sono un {Razza} ed il mio verso è {Verso}");


        } 
    
        public string versaIlVerso ()
        {
            return verso;
        }
    
    }
}
