
namespace Projeto_Biblioteca;

internal class Biblioteca 
{
    private List<livros> catalogo;

    public Biblioteca()
    {
        catalogo = new List<livros>();
    }

    public void AdicionarLivro(livros livro)
    {
        catalogo.Add(livro);
        Console.WriteLine($"Livro \"{livro.Titulo}\" adicionado ao catálogo.");
    }

    public void RemoverLivro(string titulo)
    {
        livros livro = catalogo.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            catalogo.Remove(livro);
            Console.WriteLine($"Livro \"{titulo}\" removido do catálogo.");
        }
        else
        {
            Console.WriteLine($"Livro \"{titulo}\" não encontrado no catálogo.");
        }
    }

    public List<livros> PesquisarPorTitulo(string titulo)
    {
        return catalogo.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<livros> PesquisarPorAutor(string autor)
    {
        return catalogo.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void EmprestarLivro(string titulo)
    {
        livros livro = catalogo.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livro.Emprestar();
        }
        else
        {
            Console.WriteLine($"Livro \"{titulo}\" não encontrado no catálogo.");
        }
    }

    public void DevolverLivro(string titulo)
    {
        livros livro = catalogo.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine($"Livro \"{titulo}\" não encontrado no catálogo.");
        }
    }

    public void ListarLivros()
    {
        if (catalogo.Count == 0)
        {
            Console.WriteLine("O catálogo está vazio.");
        }
        else
        {
            foreach (var livro in catalogo)
            {
                Console.WriteLine(livro);
            }
        }
    }

}
