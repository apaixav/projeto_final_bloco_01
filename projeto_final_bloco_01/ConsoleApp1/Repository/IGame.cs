using ComerceGames.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComerceGames.Model.Repository
{
    internal interface IGame
    {

        public void CriarProduto(Jogo jogo);
        public void ListarProdutos();
        public void ConsultarporNota(int nota);
        public void AtualizarProduto(Jogo jogo);
        public void DeletarProduto(int nota);

    }
}
