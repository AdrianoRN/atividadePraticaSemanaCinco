public class Jogador
{
    private string nome;

    private int idade;

    public Jogador()
    {
        
    }

    public Jogador(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return this.nome;
    }

    public void setIdade(int idade)
    {
        this.idade = idade;
    }

    public int getIdade()
    {
        return this.idade;
    }
}