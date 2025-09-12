using Projeto_Biblioteca;

static void Main(string[] args)
{
    Biblioteca biblioteca = new Biblioteca();

    livros livro1 = new livros("1984", "George Orwell", 1949);
    livros livro2 = new livros("Dom Casmurro", "Machado de Assis", 1899);

    biblioteca.AdicionarLivro(livro1);
    biblioteca.AdicionarLivro(livro2);

    Console.WriteLine("\nCatálogo:");
    biblioteca.ListarLivros();

    Console.WriteLine("\nPesquisando por autor 'Machado':");
    var resultados = biblioteca.PesquisarPorAutor("Machado");
    foreach (var livro in resultados)
    {
        Console.WriteLine(livro);
    }

    Console.WriteLine("\nEmprestando '1984':");
    biblioteca.EmprestarLivro("1984");

    Console.WriteLine("\nTentando emprestar novamente:");
    biblioteca.EmprestarLivro("1984");

    Console.WriteLine("\nDevolvendo '1984':");
    biblioteca.DevolverLivro("1984");

    Console.WriteLine("\nRemovendo 'Dom Casmurro':");
    biblioteca.RemoverLivro("Dom Casmurro");

    Console.WriteLine("\nCatálogo Atualizado:");
    biblioteca.ListarLivros();
}
