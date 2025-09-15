namespace ProjetoRPG;

internal class entidade
{
    public abstract class Entidade
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; protected set; }
        public int Ataque { get; protected set; }

        public bool EstaVivo => PontosDeVida > 0;

        public virtual void Atacar(Entidade alvo)
        {
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {Ataque} de dano!");
            alvo.ReceberDano(Ataque);
        }

        public virtual void ReceberDano(int dano)
        {
            PontosDeVida -= dano;
            if (PontosDeVida < 0) PontosDeVida = 0;
        }
    }
}
