// 1. Crea una classe Persona
// 2. Porta nella classe Persona:
//     1. Gli attributi Nome e Cognome della classe Utente
//     2. La proprietà Denominazione della classe Utente
// 3. Elimina gli stessi attributi e la proprieta dalla classe Utente
// 4. Rendi la classe Utente una sottoclasse di Persona
// 5. Verifica che l'output del programma rimanga invariato

using System;

namespace BibliotecaProperty 
{
    public class Persona{
        public string Nome { get; set;}
        public string Cognome { get; set;}

        public string Denominazione {
            get{
                return Nome + " " + Cognome;
            }
        }
    }
    public class Utente : Persona{
        
        public string Id { get; set;}
        
        public int AnnoIscrizione { get; set;}

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