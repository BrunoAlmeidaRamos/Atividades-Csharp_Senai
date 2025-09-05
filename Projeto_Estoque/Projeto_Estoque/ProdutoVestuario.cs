
namespace Projeto_Estoque;
public class ProdutoVestuario : Produto
{
    public string Cor {  get; set; }
    public string Tamanho { get; set; }
   

    public ProdutoVestuario(string cor, string tamanho, string nome, double preco, int quantidade, string sku) : base(nome, preco, quantidade, sku)
    {
        Cor = cor;
        Tamanho = tamanho;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome} | Preco: {preco} | Quantidade: {quantidade} | Sku: {sku}");
    }
}
