using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOA_D_P_TV
{
    public class TV
    {
        public string Modello;
        public string Marca;
        public int Dimensione;
        public int Consumo;
        public int Prezzo;
        public int Volume;
        public int Canale;
        public bool Stato;

        public TV(string modello, string marca, int dimensione, int consumo, int prezzo)
        {
            Modello = modello;
            Marca = marca;
            Dimensione = dimensione;
            Consumo = consumo;
            Prezzo = prezzo;
            Stato = false;
            Volume = 0;
            Canale = 1;
        }

        public void Accendi()
        {
            Stato = true;
            Console.WriteLine("La TV è accesa.");
        }

        public void Spegni()
        {
            Stato = false;
            Console.WriteLine("La TV è spenta");
        }

        public void cambia_canale(int nuovo_canale)
        {
            if (Stato)
            {
                Canale = nuovo_canale;
                Console.WriteLine("Canale: " + Canale);
            }
            else
            {
                Console.WriteLine("La TV è spenta");
            }
        }

        public void aumenta_diminuisci_canale(int incremento)
        {
            if (Stato)
            {
                Canale += incremento;
                Console.WriteLine("Il canale è " + Canale);
            }
            else
            {
                Console.WriteLine("La tv è spenta");
            }
        }
        public void alza_abbassa_volume(int incremento)
        {
            if (Stato)
            {
                Volume += incremento;
                Console.WriteLine("Il volume è " + Volume);
            }
            else
            {
                Console.WriteLine("La tv è spenta");
            }
        }
        public void cambia_volume(int volume_nuovo)
        {
            if (Stato)
            {
                Volume = volume_nuovo;
                Console.WriteLine("Il volume è " + Volume);
            }
            else
            {
                Console.WriteLine("La tv è spenta");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                TV s1 = new TV("Marca1", "Modello1", 100, 37, 300);
                TV s2 = new TV("Marca2", "Modello2", 120, 51, 500);

                s1.Accendi();
                s1.cambia_canale(5);
                s1.cambia_volume(3);

                s2.Accendi();
                s2.cambia_canale(10);
                s2.cambia_volume(10);

                Console.WriteLine("TV s1: Canale " + s1.Canale + ", volume " + s1.Volume);
                Console.WriteLine("TV s2: Canale " + s2.Canale + ", volume " + s2.Volume);

                Console.ReadLine();


            }
        }
    }
}
           