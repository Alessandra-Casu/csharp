//Definire una classe UTENTE
//definire questi attributi privati al suo interno:
// -id (stringa)
// -nome (stringa)
// -cognome (stringa)
// -annoIscrizione (intero)
// definire un costruttore pubblico al suo interno che prenda in input
// -id
// -nome
// -cognome
// -annoIscrizione
//definire un metodo pubblico che ritorna DENOMINAZIONE dell'utente

//Definire una classe LIBRO
//definire questi attributi privati al suo interno:
// -id (stringa)
// -titolo (stringa)
// -autore (stringa)
// -utente (Utente)
// definire un costruttore pubblico al suo interno che prenda in input
// -id
// -titolo
// -autore
//definire un metodo pubblico che ritorna DESCRIZIONE del libro
//definire un metodo pubblico che ritorna PRESTITO del libro
//definire un metodo pubblico che ritorna RESTITUZIONE del libro


//Definire una classe BIBLIOTECA
//Main
//  crea un primo utente
//  crea un secondo utente
//  crea un libro
//  presta il libro al primo utente
//  prova a prestare il libro al secondo
//  restituisci il libro
//  presta il libro al secondo utente

using System;

namespace Biblioteca 
{
    public class Utente{
        private string id;
        private string nome;
        private string cognome;
        private int annoIscrizione;

         public Utente(string id, string nome, string cognome, int annoIscrizione){
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.annoIscrizione = annoIscrizione;
        }

        public string Denominazione(){
            return this.nome + " " + this.cognome;
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
                Console.WriteLine($"Titolo è già in prestito a  {this.utente.Denominazione()}");
                return;
            }
            this.utente = utente;
            Console.WriteLine($"Titolo prestatoo a {this.utente.Denominazione()}");
        }

        public void Restituzione(){
            Console.WriteLine($"{this.utente.Denominazione()} ha eseguito la restituzione");
            this.utente = null;
        }
    }

    public class Biblioteca{
        public static void Main(string[] args){
            Utente utente1 = new Utente("0001", "Mario", "Rossi", 2015);
            Console.WriteLine(utente1.Denominazione());

            Utente utente2 = new Utente("0002", "Giuseppe", "Verdi", 2010);
            Console.WriteLine(utente2.Denominazione());

            Libro libro = new Libro("L001", "Isola Misteriosa", "Giulio Verne");
            Console.WriteLine(libro.Descrizione());

            libro.Prestito(utente1);
            libro.Prestito(utente2);
            libro.Restituzione();
            libro.Prestito(utente2);
        }
    }
}