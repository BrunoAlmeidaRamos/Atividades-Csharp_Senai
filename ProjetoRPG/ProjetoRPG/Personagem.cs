using static ProjetoRPG.entidade;

namespace ProjetoRPG;

internal class Personagem
{
    public class Personagem : Entidade
    {
        public string Classe { get; set; }

        public Personagem(string nome, string classe, int vida, int ataque)
        {
            Nome = nome;
            Classe = classe;
            PontosDeVida = vida;
            Ataque = ataque;
        }

        public void Curar()
        {
            int cura = 20;
            PontosDeVida += cura;
            Console.WriteLine($"{Nome} se cura em {cura} pontos de vida!");
        }
    }

}
