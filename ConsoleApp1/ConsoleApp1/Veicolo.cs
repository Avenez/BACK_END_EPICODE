using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Veicolo
    {
        public string marca;
        public string nome;
        public int kilometri;

        public Veicolo(string marca, string nome, int kilometri) { 
        
            this.marca = marca;
            this.nome = nome;
            this.kilometri = kilometri;
        }

        public string Marca { 
        
            get { return marca; }
            set { marca = value; }


        }

        public string Nome
        {

            get { return nome; }
            set { nome = value; }


        }

        public int Kilometri
        {

            get { return kilometri; }
            set { kilometri = value; }


        }


        public void accelera(int velocità) {
            Console.WriteLine($"La macchina ha accelerato a {velocità} Km/h");
        }


    }
}
