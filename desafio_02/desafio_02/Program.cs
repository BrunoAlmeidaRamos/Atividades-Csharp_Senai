//Console.WriteLine("========== Boletim de Viagem ==============");

//string destino = "Paris";
//double km = 2.000;
//double valor = 10.000;

//Console.WriteLine($"A viajem com o destino {destino}, vai ter a distância em {km}Km.O valor dessa passagem e de R${valor}");

//Console.WriteLine("====== temperatura =======");

//Console.WriteLine("Informe a temperatura: ");
//double temperatura = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"A temperatura de hoje e: {temperatura}");

//Console.WriteLine("========== salario ==============");

//Console.WriteLine("Informe seu salario: ");
//double salario = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Infome seu gasto do mes: ");
//double gasto = Convert.ToDouble(Console.ReadLine());

//double valor = salario - gasto;

//Console.WriteLine($"Seu salario e de R${salario}, suas despesa desse mes e de R${gasto}. Sobrou R${valor} do seu salario");

//Console.WriteLine("========= Conversor de Moedas =============");

//Console.WriteLine("R$ ");
//double reais = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Informe a cotação em dolar U$ ");
//double dolar = Convert.ToDouble(Console.ReadLine());

//double conversor = reais *  dolar;

//Console.WriteLine($"A conversao e de R$ {conversor}");

//Console.WriteLine("====== Cálculo de Desconto =======");

//Console.WriteLine("Informe o valor do produto R$ ");
//double ValorProduto = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("infome o Percentual do desconto: ");
//double DescontoProduto = Convert.ToDouble(Console.ReadLine());

//double ValorDesconto = ValorProduto - (ValorProduto * DescontoProduto / 100);

//Console.WriteLine($"O desconto do seu produto ficou de R${ValorDesconto}");

//Console.WriteLine("=============== Divisão de Conta ===================");

//Console.WriteLine("Informe o valor total da refeição R$ ");
//double ValorRefeicao = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Quantas pessoas vao dividir a conta: ");
//int DividirConta =  Convert.ToInt32(Console.ReadLine());

//double ValorConta = ValorRefeicao /  DividirConta;

//Console.WriteLine($"O valor sera de R${ValorConta} pra cada");

//Console.WriteLine("============= Velocidade da Via ================");

//Console.WriteLine("Informe a velocidade do carro");
//double VelocidadeVia = Convert.ToDouble(Console.ReadLine());

//if (VelocidadeVia <= 80)
//{
//    Console.WriteLine("Esta na velocidade Permitida");
//}
//else
//{
//    Console.WriteLine("Acima da media de velocidade Multa grave");
//} 

//Console.WriteLine("======= Categoria de Votação =========");

//Console.WriteLine("Informe sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >=18)
//{
//    Console.WriteLine("Votacao obrigatorio");
//}
//else
//{
//    Console.WriteLine("Voce nao tem idade pra votar ainda");
//}

//Console.WriteLine("=========== Classificação de Números ==============");

//Console.WriteLine("Informe um numero: ");
//int Classificacao = Convert.ToInt32(Console.ReadLine());

//if (Classificacao == 0)
//{
//    Console.WriteLine("Seu numero e zero");
//}
//else if (Classificacao < 0)
//{
//    Console.WriteLine("Seu numero e negativo");
//}
//else
//{
//    Console.WriteLine("Seu numero e positivo");
//}

//Console.WriteLine("=========== Validação de Senha ===============");

//Console.WriteLine("Informe sua senha: ");
//int senha = Convert.ToInt32(Console.ReadLine());

//int SenhaReal = 12245;

//if (senha == SenhaReal)
//{
//    Console.WriteLine("Acesso permitdo");
//} else
//{
//    Console.WriteLine("Acesso negado");
//}


//Console.WriteLine("=============== Contagem de Pares ===============");

//Console.WriteLine("Informe um numero: ");
//int ContagemPar = Convert.ToInt32(Console.ReadLine());

//if (ContagemPar % 2 == 0)
//{
//    Console.WriteLine("O numero e par");
//} else
//{
//    Console.WriteLine("O numero e impar");
//}

//Console.WriteLine("================== Quadrados de Números ===============");

//Console.WriteLine("Informe um numero: ");
//int NumQuadrado = Convert.ToInt32(Console.ReadLine());

//for  (int i = 0; i < NumQuadrado; i++)
//{
//    Console.WriteLine($"[{i + 1}]");
//}

//Console.WriteLine("============ Sequência de Fibonacci ==================");

//int n = 10; // Quantos termos você quer
//int a = 0, b = 1, temp;


//for (int i = 0; i < n; i++)
//{
//    Console.Write(a + " ");
//    temp = a;
//    a = b;
//    b = temp + b;

//}