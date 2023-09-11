using ComerceGames.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComerceGames.Repository
{
    public interface IGame
    {

        public void CriarProduto(Jogo jogo);
        public void ListarProdutos();
        public void ConsultarporId (int id);
        public void AtualizarProduto(Jogo jogo);
        public void DeletarProduto(int nota);

    }
}
