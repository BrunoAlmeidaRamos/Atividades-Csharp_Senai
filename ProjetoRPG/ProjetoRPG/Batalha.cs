namespace ProjetoRPG;

internal class Batalha
{
    public class batalha
    {
        private Personagem heroi;
        private Monstro monstro;

        public void IniciarBatalha(Personagem heroi, Monstro monstro)
        {
            this.heroi = heroi;
            this.monstro = monstro;

            Console.WriteLine("A batalha começou!");
            Console.WriteLine($"{heroi.Nome} (Classe: {heroi.Classe}) VS {monstro.Nome} (Tipo: {monstro.Tipo})");
            Console.WriteLine();

            while (heroi.EstaVivo && monstro.EstaVivo)
            {
                // Turno do jogador
                Console.WriteLine("\n--- Seu Turno ---");
                Console.WriteLine($"Seu HP: {heroi.PontosDeVida} | HP do Monstro: {monstro.PontosDeVida}");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Curar");
                Console.Write("Escolha sua ação: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    heroi.Atacar(monstro);
                }
                else if (escolha == "2")
                {
                    heroi.Curar();
                }
                else
                {
                    Console.WriteLine("Ação inválida. Você perde o turno.");
                }

                if (!monstro.EstaVivo)
                    break;

                // Turno do monstro
                Console.WriteLine("\n--- Turno do Monstro ---");
                monstro.Atacar(heroi);
            }

            // Resultado
            Console.WriteLine("\n--- Fim da Batalha ---");
            if (heroi.EstaVivo)
            {
                Console.WriteLine($"{heroi.Nome} venceu a batalha!");
            }
            else
            {
                Console.WriteLine($"{monstro.Nome} venceu a batalha!");
            }
        }
    }

}
