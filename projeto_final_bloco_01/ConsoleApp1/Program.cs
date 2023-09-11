using ComerceGames.Classes;
using ComerceGames.Controller;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = 0, id, genero, classificacao;
            string nome, plataforma;
            decimal preco, nota;

            GamesController jogos = new();

           

            while (true)
            {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("                                             ");
            Console.WriteLine("         VGS - Virtual Games Service         ");
            Console.WriteLine("                                             ");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("                                             ");
            Console.WriteLine("          1- Criar Produto                   ");
            Console.WriteLine("          2- Lista dos Produtos              ");
            Console.WriteLine("          3- Consultar por Número            ");
            Console.WriteLine("          4- Atualizar Produto               ");
            Console.WriteLine("          5- Deletar Produto                 ");
            Console.WriteLine("          6- Sair                            ");
            Console.WriteLine("                                             ");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("Entre com a opção desejada:                  ");
            Console.WriteLine("                                             ");
            Console.ResetColor();
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVGS - vários mundos na palma da sua mão!");
                Console.ResetColor();
                System.Environment.Exit(0);
            }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Nome do Jogo:");
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite o Genero do Jogo:");
                        Console.WriteLine("1 -Terror " +
                            "  /2 - Hack'n slash" +
                            " /3 - Esportes"+
                            " /4 - Rpg" +
                            " /5 - Aventura" +
                            " /6 - Diversão familiar" +
                            " /7 - Estratégia" +
                             " /8 - Outros");
                        genero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Preço do Jogo");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite a Classificação do Jogo");
                        classificacao = Convert.ToInt32(Console.ReadLine());
                    
                        Console.WriteLine("Digite a Nota do Jogo");
                        nota = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite a Plataforma do Jogo:");
                        plataforma = Console.ReadLine();
                        jogos.CriarProduto(new Plataforma(nome, jogos.GerarId(), genero, preco, classificacao, nota, plataforma));

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lista dos Produtos: \n");
                        Console.ResetColor();

                        jogos.ListarProdutos();

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar por Id: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        jogos.ConsultarporId(id);

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var jogo = jogos.BuscarNaCollection(id);

                        if (jogo is not null)
                        {
                            Console.WriteLine("Digite o Nome do Jogo:");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite o Genero do Jogo:");
                            Console.WriteLine("Digite o Genero do Jogo:");
                            Console.WriteLine("1 -Terror " +
                                "  /2 - Hack'n slash" +
                                " /3 - Esportes" +
                                " /4 - Rpg" +
                                " /5 - Aventura" +
                                " /6 - Diversão familiar" +
                                " /7 - Estratégia" +
                                 " /8 - Outros");
                            genero = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o Preço do Jogo");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite a Classificação do Jogo");
                            classificacao = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite a Nota do Jogo");
                            nota = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite a Plataforma do Jogo:");
                            plataforma = Console.ReadLine();
                            jogos.AtualizarProduto(new Plataforma(nome, id, genero, preco, classificacao, nota, plataforma));
                        }



                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Deletar Produto: \n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o id do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        jogos.DeletarProduto(id);

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção inválida");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        KeyPress();
                        Console.ResetColor();
                        break;

                        static void KeyPress()
                        {
                            do
                            {
                                Console.WriteLine("Pressione enter para continuar!");
                                consoleKeyInfo = Console.ReadKey();
                            } while (consoleKeyInfo.Key != ConsoleKey.Enter);


                        }
                }
                
            }



        }
    }
  
}