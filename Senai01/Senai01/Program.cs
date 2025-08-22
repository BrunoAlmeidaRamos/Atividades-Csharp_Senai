using System.Runtime.Serialization;

Console.WriteLine("CALCULADORA");

Console.WriteLine("===================================================");

Console.WriteLine("Digite seu primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("===================================================");

Console.WriteLine("Escolha: ");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - subtracao");
Console.WriteLine("3 - divisao");
int opcao = int.Parse(Console.ReadLine());

Console.WriteLine("===================================================");

if (opcao == 1)
{
    int soma = num1 + num2;
    Console.WriteLine($"A soma dos numeros e: {soma}");
};

if (opcao == 2)
{
    int subtracao = num1 - num2;
    Console.WriteLine($"A subtracao dos sumeros e: {subtracao}");
}

if (opcao == 3)
{
    int divisao = num1 / num2;
    Console.WriteLine($"A divisao dos numeros e: {divisao}");
}

Console.WriteLine("===================================================");

Console.WriteLine("Digite seu nome: ");
string name  = Console.ReadLine();

Console.WriteLine("===================================================");

Console.WriteLine("Digite sua idade: ");
int idade =  int.Parse(Console.ReadLine());

Console.WriteLine("===================================================");

Console.WriteLine("Digite sua altura: ");
double altura  = double.Parse(Console.ReadLine());

Console.WriteLine("===================================================");

Console.WriteLine($"Prazer {name}! sua idade e {idade} anos e sua altura e {altura}.");
