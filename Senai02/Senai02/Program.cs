using System.Runtime.Serialization;

    Console.WriteLine("CALCULADORA");

    Console.WriteLine("============================================");

    Console.WriteLine("Digite seu primeiro numero: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("============================================");

    Console.WriteLine("Escolha: ");
    Console.WriteLine("1 - [+]");
    Console.WriteLine("2 - [-]");
    Console.WriteLine("3 - [*]");
    Console.WriteLine("4 - [/]");

    int opcao = int.Parse(Console.ReadLine());

    Console.WriteLine("============================================");

    if (opcao == 1)
    {
        int soma = num1 + num2;
        Console.WriteLine($"A soma dos numeros e: {soma}");
    }

    else if (opcao == 2)
    {
        int subtracao = num1 - num2;
        Console.WriteLine($"A subtrcao dos numeros e: {subtracao}");
    }

    else if (opcao == 3)
    {
        int mutplicacao = num1 * num2;
        Console.WriteLine($"A mutplicacao dos numeros e: {mutplicacao}");
    }

    else if (opcao == 4)
    {
        int divisao = num1 / num2;
        Console.WriteLine($"A divisao dos numeros e: {divisao}");
    }

    Console.WriteLine("============================================");

