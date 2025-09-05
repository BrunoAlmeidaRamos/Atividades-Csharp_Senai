
namespace Projeto_Estoque;

public class ProdutoEletronico : Produto
{
    public string Marca { get; set; }
    public double Peso { get; set; }
    public bool Bateria { get; set; }
    public ProdutoEletronico(string marca, double peso,bool bateria,string nome, double preco, int quantidade, string sku) : base(nome, preco, quantidade, sku)
    {
        Marca = marca;
        Peso = peso;
        Bateria = bateria;
    }
}
