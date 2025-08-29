using System;

List<string> tarefas = new List<string>();
List<bool> statusTarefas = new List<bool>();

void ExibirMenu()
{
    Console.WriteLine("=============== ASSISTENTE PESSOAL =============");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Marcar tarefa como concluida");
    Console.WriteLine("4 - Excluir tarefa");
    Console.WriteLine("5 - Exibir resumo das tarefas");
    Console.WriteLine("0 - saida");
    Console.WriteLine("Escolher uma opcao");
}

void CadastrarTarefa()
{
    Console.Write("Digite uma nova tarefa: ");
    string novaTarefa = Console.ReadLine();

    tarefas.Add(novaTarefa);
    statusTarefas.Add(false);

    Console.WriteLine("Tarefa adicionada!!");
}

void ListarTarefas()
{
    if(tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada");
        return;
    }

    Console.WriteLine("======== LISTA DE COMPRAS ========");

    for(int i = 0; i < tarefas.Count; i++)
    {
        bool status = statusTarefas[i];

        string chek;

        if(status == true)
        {
            chek = "[X]";
        }
        else
        {
            chek = "[ ]";
        }

        Console.WriteLine(tarefas[i]);
    }
}

void Concluido()
{
    ListarTarefas();

    Console.Write("Informe o numero da tarefa a ser concluida: ");
    int numTarefa = int.Parse(Console.ReadLine()!) - 1;

    if(numTarefa >= 0 && numTarefa < tarefas.Count)
    {
        statusTarefas[numTarefa] = true;
        Console.WriteLine("Tarefa marcada como concluido!");
    }
    else
    {
        Console.WriteLine("Numero invalido. Essa tarefa nao existe...");
    }
}

void excluir()
{
    ListarTarefas();

    Console.Write("Informe o numero da tarefa a ser concluida: ");
    int numTarefa = int.Parse(Console.ReadLine()!) - 1;

    if (numTarefa >= 0 && numTarefa <= tarefas.Count)
    {
        tarefas.RemoveAt(numTarefa);
        statusTarefas.RemoveAt(numTarefa);
        Console.WriteLine("Tarefa removida com sucesso!");
    }
    else
    {
        Console.WriteLine("Numero invalido. Essa tarefa nao existe...");
    }
}

void ExibirTarefa()
{
    int TotalTarefas = tarefas.Count;
    //int TarefasConcluidas = statusTarefas.Count;
    int tarefasConcluidas = statusTarefas.FindAll(x => x).Count();
    int TarefasPendentes = TotalTarefas - tarefasConcluidas;

    Console.WriteLine("====== RESUMO ====");
    Console.WriteLine($"Total tarefas: {TotalTarefas}");
    Console.WriteLine($"Total tarefas concluida: {tarefasConcluidas} ");
    Console.WriteLine($"Total taferas pendentes: {TarefasPendentes}");
}

do
{

    ExibirMenu();
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            CadastrarTarefa();
            break;
        case "2":
            ListarTarefas();
            break;
        case "3":
            Concluido();
            break;
        case "4":
            excluir();
            break;
        case "5":
            ExibirTarefa();
            break;
        case "0":
            Console.WriteLine("tchau lua ");
            return;
        default:
            Console.WriteLine("Opcao invalida! Tente novamente");
            break;
    }
} while (true);
