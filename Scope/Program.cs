// Esempio SCOPE

public class Persona{
    private string nome;   //CLASS SCOPE
    private string cognome;//CLASS SCOPE

    public Persona(string nome) : this("Mario", cognome)
    {
        
    }
    public Persona(string nome, string cognome) //METHOD SCOPE
    {
        if (nome == "Mario") {
            string s = "Ciao Mario!"; //BLOCK SCOPE
            Console.WriteLine(s);
        }
        this.nome = nome;
        this.cognome = cognome;
    }

}
