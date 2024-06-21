using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Finale_S1
{
    internal class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public Genere Sesso { get; set; }
        public string CodiceFiscale { get; set; }
        public string ComuneResidenza { get; set; }
        public int RedditoAnnuo { get; set; }

        public Contribuente(string nome, string cognome, DateTime dataNascita, Genere sesso, string codiceFiscale, string comuneResidenza, int redditoAnnuo)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            Sesso = sesso;
            CodiceFiscale = codiceFiscale;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuo = redditoAnnuo;
        }

        public decimal CalcolaImposta()
        {
            decimal imposta = 0;

            switch (RedditoAnnuo)
            {
                case <= 15000:  
                        imposta = RedditoAnnuo * 0.23m; 
                        break;

                case <= 28000:
                    imposta = 3450 + (RedditoAnnuo - 15000) * 0.27m;
                    break;

                case <= 55000:
                    imposta = 6960 + (RedditoAnnuo - 28000) * 0.38m;
                    break;

                case <= 75000:
                    imposta = 17220 + (RedditoAnnuo - 55000) * 0.41m;
                    break;

                case > 75000:
                    imposta = 25420 + (RedditoAnnuo - 75000) * 0.43m;
                    break;
            }
            return imposta;
        }
        public void Details()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {Nome} {Cognome},");
            Console.WriteLine($"nato il {DataNascita:dd/MM/yyyy} ({Sesso}),");
            Console.WriteLine($"residente in {ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {RedditoAnnuo}$");
            Console.WriteLine($"IMPOSTA DA VERSARE: {CalcolaImposta()}$");
        }
    }
}

