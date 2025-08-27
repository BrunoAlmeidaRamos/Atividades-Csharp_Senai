Console.WriteLine("================ Calculadora ================");

Console.Write("Digite o primeiro numero: ");
double num1 = ColetarValor();

Console.Write("Digite o segundo  numero: ");
double num2 = ColetarValor();

Console.Write($@"==============
| 1 - Soma
| 2 - Subtracao 
| 3 - Divisao
| 4 - Multiplicacao
>");

double operacao = ColetarValor();

switch(operacao)
{
    case 1:
        Soma(num1, num2);
        break;
    case 2:
        subtracao(num1, num2);
        break;
    case 3:
        divisao(num1, num2);
        break;
    case 4:
        mutiplicacao(num1, num2);
        break;
        
}
double ColetarValor()
{
    bool NumeroValido = false;
    double ValorColetado;

    while (!NumeroValido)
    {
        try
        {
            ValorColetado = Convert.ToDouble(Console.ReadLine());
            NumeroValido = true;

            return ValorColetado;
        }
        catch
        {
            Console.WriteLine("Entrada digitada invalida! Digite somente numeros...");
        }
        
    }
    return 0;
}

void Soma(double num1, double num2)
{
    double soma = num1 + num2;
    Console.WriteLine($"A soma dos numeros {num1} + {num2} = {soma}");
} 
void subtracao(double num1, double num2)
{
    double subtracacao = num1 - num2;
    Console.WriteLine($"A subtracacao {num1} - {num2} = {subtracacao}");
}
void divisao(double num1, double num2)
{
    double divisao = num1 / num2;
    Console.WriteLine($"A divisao {num1} / {num2} = {divisao}");
}
void mutiplicacao(double num1, double num2)
{
    double multplicacao = num1 * num2;
    Console.WriteLine($"A mutiplicacao {num1} x {num2} = {multplicacao}");
}

//Console.Write("Informe o primeiro Numero: ");
//try
//{
//    double num1 = Convert.ToDouble(Console.ReadLine());
//}
//catch
//{
//    Console.Write("Numero invalido! digite novamente: ");
//}