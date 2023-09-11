using ComerceGames.Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = 0, id, tipo;

            Plataforma j2 = new Plataforma("Super Mário", 6, 145, 0, 8.9, "Nintendo switch");

            j2.Visualizar();

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

                    Console.ForegroundColor = ConsoleColor.Green;
                    KeyPress();
                    Console.ResetColor();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Lista dos Produtos: \n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    KeyPress();
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Consultar por Id: \n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    KeyPress();
                    Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Atualizar Produto: \n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    KeyPress();
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Deletar Produto: \n");
                    Console.ResetColor();

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