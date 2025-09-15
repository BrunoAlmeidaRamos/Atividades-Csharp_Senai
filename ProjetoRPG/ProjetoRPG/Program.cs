using ProjetoRPG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao RPG!");

        Console.Write("Digite o nome do seu herói: ");
        string nomeHeroi = Console.ReadLine();

        Personagem heroi = new Personagem(nomeHeroi, "Guerreiro", 100, 25);
        Monstro monstro = new Monstro("Gorgul", "Orc", 80, 20);

        Batalha batalha = new Batalha();
        batalha.IniciarBatalha(heroi, monstro);

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
