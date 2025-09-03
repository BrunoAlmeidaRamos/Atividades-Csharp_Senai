using System.Security.Cryptography;


Pessoa p = new Pessoa();
p.nome = "bruno";
p.idade = 22;
p.Apresentar();

public class Pessoa
{
    public string? nome;
    public int idade;

    public void Apresentar()
    {
        Console.WriteLine($"ola, meu nome e {nome} e tenho {idade} anos.");
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {nome}, Idade: {idade}");
    }

    public void AlterarIdade()
    {
        if (idade >= 0)
        {
            Console.Write("Digite sua idade: ");
            int NovaIdade = Convert.ToInt32( Console.ReadLine() );
        }
        else
        {
            Console.WriteLine("Numero invalido! Tente novamente...");
        }
    }
}
