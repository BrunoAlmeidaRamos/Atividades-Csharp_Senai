
namespace Projeto_Biblioteca;

internal class livros
{
    public string Titulo {  get; set; }
    public string Autor {  get; set; }
    public int AnoPublicado { get; set; }
    public bool EstaEmprestado { get; set; }

    public livros(string titulo, string autor, int anoPublicado)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicado = anoPublicado;
        EstaEmprestado = true;
    }

    public void Emprestar()
    {
        if (EstaEmprestado is true)
        {
            Console.WriteLine($"livro {Titulo} foi emprestado com sucesso");
        }
        else
        {
            Console.WriteLine($"O livro {Titulo} esta emprestado ja");
        }
    }

    public void Devolver()
    {
        if (!EstaEmprestado is true)
        {
            Console.WriteLine($"O livro {Titulo} foi devolvido com sucesso");
        }
        else
        {
             Console.WriteLine($"O livro {Titulo} nao foi devolvido ainda");
        }
    }
    
    public override string ToString()
    {
        string status = EstaEmprestado ? "Disponível" : "Emprestado";
        return $"\"{Titulo}\" por {Autor} ({AnoPublicado}) - {status}";
    }
}
