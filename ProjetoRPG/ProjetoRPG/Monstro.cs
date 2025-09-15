using static ProjetoRPG.entidade;

namespace ProjetoRPG;

    public class Monstro : Entidade
    {
        public string Tipo { get; set; }

        public Monstro(string nome, string tipo, int vida, int ataque)
        {
            Nome = nome;
            Tipo = tipo;
            PontosDeVida = vida;
            Ataque = ataque;
        }

        public override void ReceberDano(int dano)
        {
            base.ReceberDano(dano);
            Console.WriteLine($"{Nome} grita: 'RAWR! Você vai pagar por isso!'");
        }
    }


