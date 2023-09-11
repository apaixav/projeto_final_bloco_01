using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComerceGames.Classes
{
    public class Plataforma : Jogo
    {

        string plataforma;
        public Plataforma(string nome,int id, int genero, decimal preco, int classificacao, decimal nota, string plataforma)
            : base(nome,id, genero, preco, classificacao, nota)
        {
            this.plataforma = plataforma;
        }

        public string GetPlataforma()
        {
            return plataforma;
        }

        public void SetPeças(string plataforma)
        {
            this.plataforma = plataforma;
        }
        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine($"O console que rodará o jogo é :{this.plataforma}");

        }
    }
}
