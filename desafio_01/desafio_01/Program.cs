for (int i = 1; i <= 10; i++) // número base da tabuada
{
    Console.WriteLine($"Tabuada do {i}:");

    for (int j = 1; j <= 10; j++) // multiplicador
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }

} 

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();