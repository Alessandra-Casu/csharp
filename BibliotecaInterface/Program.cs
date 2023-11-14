// 1. Crea una interface IUtente con:
//     1. stringa ID (get, set)
//     2. intero AnnoIscrizione (get, set)
//     3. stringa Denominazione(get)
// 2. Crea una classe Persona che implementa IUtente
//     1. due propert Nome e COgnome (get, set)
//     2. Denominazione = Id + Nome + COgnome
// 3. Crea una classe Organizzazione che implementa IUtente
//     1. una property stringa RagioneSociale (get, set)
//     2. Denominazione = Id + RagioneSociale
// 4. Crea una classe Biblioteca
//     1. un attributo statico utenti, array di interface IUtente
//     2. un metodo statico stampaUtente che visualizza l'elenco degli utenti
// 5. Nel metodo Main() di Biblioteca  
//     1. crea una persona ed una organizzazione come utenti della Biblioteca
//     2. usa il metodo stampautente() per visualizzare i due utenti

using System;

namespace BibliotecaInterface
{
    public interface IUtente
    {
        string Id {get; set;}
        int AnnoIscrizione {get; set;}
        string Denominazione {get;}
       
    }

    public class Persona : IUtente
    {
        public string Id {get; set;}
        public int AnnoIscrizione {get; set;}
        public string Nome {get; set;}
        public string Cognome {get; set;}
        public string Denominazione 
        {
            get{
                return Id + " " + Nome + " " + Cognome;
            }
        }
    }

    public class Organizzazione : IUtente
    {
        public string Id {get; set;}
        public int AnnoIscrizione {get; set;}

        public string RagioneSociale {get; set;}
        
        public string Denominazione 
        {
            get{
                return Id + " " + RagioneSociale;
            }
        }
    }

    public class Biblioteca
    {
        static IUtente[] utenti;

        public static void Main(string[] args){
            Persona persona = new Persona();
            persona.Id = "001";
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";
            persona.AnnoIscrizione = 2016;

            Organizzazione org = new Organizzazione();
            org.Id = "002";
            org.RagioneSociale = "Grandi elettori srl";
            org.AnnoIscrizione = 2010;

            utenti = new IUtente[] {persona, org};
            stampaUtenti();
        }

        static void stampaUtenti()
        {
            foreach(IUtente ute in utenti){
                Console.WriteLine(ute.Denominazione);
            }
        }

    }
}