using ComerceGames.Classes;
using ComerceGames.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComerceGames.Controller
{
    public class GamesController : IGame
    {

        private readonly List<Jogo> listaJogo = new();
        int id = 0;
        public void AtualizarProduto(Jogo jogo)
        {
            var buscaJogo = BuscarNaCollection(jogo.GetId());

            if (buscaJogo is not null)
            {
                var index = listaJogo.IndexOf(buscaJogo);

                listaJogo[index] = jogo;

                Console.WriteLine($"O Produto Id {jogo.GetId()}, foi atulizado com sucesso!");
            }
        }

        public void ConsultarporId(int id)
        {
            var jogo = BuscarNaCollection(id);

            if (jogo is not null)
            {
                jogo.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"O Produto de id {id}, não foi encontrado");
                Console.ResetColor();
            }
        }

        public void CriarProduto(Jogo jogo)
        {
            listaJogo.Add(jogo);
            Console.WriteLine($"O Produto de id {jogo.GetId()} foi criado com sucesso"); ;
        }

        public void DeletarProduto(int nota)
        {
            var jogo = BuscarNaCollection(id);

            if (jogo is not null)
            {
                if (listaJogo.Remove(jogo) == true)
                    Console.WriteLine($"O Produto de id {id} foi apagado com suceso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"O Produto de id {id}, não foi encontrado");
                Console.ResetColor();
            }
        }

        public void ListarProdutos()
        {
            foreach (var produto in listaJogo)
            {
                produto.Visualizar();
            }
        }

        public int GerarId()
        {
            return ++id;
        }

        public Jogo? BuscarNaCollection(int id)
        {
            foreach (var jogo in listaJogo)
            {
                if (jogo.GetId() == id)
                    return jogo;
            }

            return null;
        }
    }
}

