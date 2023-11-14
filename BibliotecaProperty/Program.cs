using System;

namespace BibliotecaProperty 
{
    public class Utente{
        // private string id;
        // private string nome;
        // private string cognome;
        // private int annoIscrizione;

        //Abbiamo trasformato gli attributi con delle property auto-implementate
        public string Id { get; set;}
        public string Nome { get; set;}
        public string Cognome { get; set;}
        public int AnnoIscrizione { get; set;}

        //  public Utente(string id, string nome, string cognome, int annoIscrizione){
        //     this.id = id;
        //     this.nome = nome;
        //     this.cognome = cognome;
        //     this.annoIscrizione = annoIscrizione;
        // }
        //Abbiamo eliminato il costruttore

        // public string Denominazione(){
        //     return this.nome + " " + this.cognome;
        //     }

        //Abbiamo covertito il metodo Descrizione con una corrispondente property read-only
        public string Denominazione {
            get{
                return Nome + " " + Cognome;
            }
        }
    }

    public class Libro{
        private string id;
        private string titolo;
        private string autore;
        private Utente utente;
        
        public Libro(string id, string titolo, string autore){
            this.id = id;
            this.titolo = titolo;
            this.autore = autore;
            this.utente = null;
        }

        public string Descrizione(){
            return this.titolo + " di " + this.autore; 
        }

        public void Prestito(Utente utente){
            if ( this.utente != null ){
                Console.WriteLine($"Titolo è già in prestito a  {this.utente.Denominazione}");
                return;
            }
            this.utente = utente;
            Console.WriteLine($"Titolo prestatoo a {this.utente.Denominazione}");
        }

        public void Restituzione(){
            Console.WriteLine($"{this.utente.Denominazione} ha eseguito la restituzione");
            this.utente = null;
        }
    }

    public class Biblioteca{
        public static void Main(string[] args){
            Utente utente1 = new Utente(){Id = "0001", Nome =  "Mario", Cognome = "Rossi", AnnoIscrizione = 2015};
            Console.WriteLine(utente1.Denominazione);

            Utente utente2 = new Utente(){Id = "0002", Nome = "Giuseppe", Cognome = "Verdi", AnnoIscrizione = 2010};
            Console.WriteLine(utente2.Denominazione);

            Libro libro = new Libro("L001", "Isola Misteriosa", "Giulio Verne");
            Console.WriteLine(libro.Descrizione());

            libro.Prestito(utente1);
            libro.Prestito(utente2);
            libro.Restituzione();
            libro.Prestito(utente2);
        }
    }
}