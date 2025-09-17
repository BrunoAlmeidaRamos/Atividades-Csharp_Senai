namespace jogo_da_velha;

internal class Jogador
{
    public string Nome { get; set; }
    public char Simbolo { get; private set; }

    public Jogador(string nome, char simbolo)
    {
        Nome = nome;
        Simbolo = simbolo;
    }   
}
