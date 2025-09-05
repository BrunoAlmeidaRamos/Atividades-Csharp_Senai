using System.Security.Cryptography.X509Certificates;

namespace Projeto_Estoque;

public class Produto
{
    public string nome { get; set; }
    public double preco { get; set; }
    public int quantidade { get; set; }
    public string sku { get; set; }

    public Produto(string nome, double preco, int quantidade, string sku)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
        this.sku = sku;
    }
}
