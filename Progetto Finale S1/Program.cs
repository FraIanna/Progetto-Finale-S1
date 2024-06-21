namespace Progetto_Finale_S1
{
    enum Genere
    {
        Uomo, Donna
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i dati del contribuente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Data di nascita (gg/mm/aaaa): ");
            DateTime dataNascita = DateTime.Parse(Console.ReadLine());

            Console.Write("Sesso (Uomo/Donna): ");
            Genere sesso = (Genere)Enum.Parse(typeof(Genere), Console.ReadLine(), true);

            Console.Write("Codice Fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Comune di Residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Reddito Annuo: ");
            int redditoAnnuo = int.Parse(Console.ReadLine());

            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, sesso, codiceFiscale, comuneResidenza, redditoAnnuo);

            contribuente.Details();
        }
    }
}
