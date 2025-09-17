using jogo_da_velha;

bool jogarNovamente;

do
{
    Tabuleiro tabuleiro = new Tabuleiro();
    Jogador jogador1 = new Jogador("Jogador 1", 'X');
    Jogador jogador2 = new Jogador("Jogador 2", 'O');
    Jogador jogadorAtual = jogador1;

    bool fimDeJogo = false;

    while (!fimDeJogo)
    {
        tabuleiro.Desenho();

        Console.WriteLine($"\n{jogadorAtual.Nome}, é a sua vez. Escolha uma posição (1-9): ");
        int posicao = int.Parse(Console.ReadLine());

        if (tabuleiro.MarcarJogada(posicao, jogadorAtual.Simbolo))
        {
            if (tabuleiro.verificarVencedor(posicao, jogadorAtual.Simbolo))
            {
                tabuleiro.Desenho();
                Console.WriteLine($"\nParabéns {jogadorAtual.Nome}, você venceu!");
                fimDeJogo = true;
            }
            else if (tabuleiro.VerificarEmpate())
            {
                tabuleiro.Desenho();
                Console.WriteLine("\n==== EMPATE ====");
                fimDeJogo = true;
            }
            else
            {
                jogadorAtual = jogadorAtual == jogador1 ? jogador2 : jogador1;
            }
        }
        else
        {
            Console.WriteLine("Jogada inválida! Pressione Enter para tentar novamente.");
            Console.ReadKey();
        }
    }

    // Pergunta se quer jogar novamente
    bool decisaoValida = false;
    do
    {
        Console.WriteLine("Quer jogar novamente? [S] ou [N]");
        string continuar = Console.ReadLine().ToUpper();

        if (continuar == "S")
        {
            jogarNovamente = true;
            decisaoValida = true;
        }
        else if (continuar == "N")
        {
            jogarNovamente = false;
            decisaoValida = true;
        }
        else
        {
            Console.WriteLine("Opção inválida. Digite apenas 'S' ou 'N'.");
        }
    } while (!decisaoValida);

} while (jogarNovamente);
