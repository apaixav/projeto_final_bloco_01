using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComerceGames.Classes
{
    public abstract class Jogo
    {
        private string nome;
        private int genero;
        private int id;
        private decimal preco;
        private int classificacao;
        private decimal nota;

        public Jogo(string nome,int id, int genero, decimal preco, int classificacao, decimal nota)
        {
            this.nome = nome;
            this.id = id;
            this.genero = genero;
            this.preco = preco;
            this.classificacao = classificacao;
            this.nota = nota;
        }
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public decimal GetPreço()
        {
            return preco;
        }

        public void SetPreço(decimal preco)
        {
            this.preco = preco;
        }

        public int GetClassificação()
        {
            return classificacao;
        }

        public void SetClassificação(int classificacao)
        {
            this.classificacao = classificacao;
           
        }        
            public decimal GetNota()
        {
            return nota;
        }

        public void SetNota(decimal nota)
        {
            this.nota = nota;
        }


        public int GetGenero()
        {
            return genero;
        }

        public void SetGenero(int genero)
        {
            this.genero = genero;
        }

        public virtual void Visualizar()
        {
            string genero = "";

            switch (this.genero)
            {
                case 1:
                    genero = "Terror";
                    break;
                case 2:
                    genero = "Hack'n slash";
                    break;
                case 3:
                    genero = "Esportes";
                    break;
                case 4:
                    genero = "Rpg";
                    break;
                case 5:
                    genero = "Aventura";
                    break;
                case 6:
                    genero = "Diversão familiar";
                    break;
                case 7:
                    genero = "Estratégia";
                    break;
                default:
                    genero = "Outros";
                    break;

            }
            Console.WriteLine("*******************************");
            Console.WriteLine("Dados do Jogo");
            Console.WriteLine("*******************************");
            Console.WriteLine($"Nome do Jogo:{this.nome} ");
            Console.WriteLine($"Nuúmero de identificação:{this.id} ");
            Console.WriteLine($"Genero do Jogo: {genero} ");
            Console.WriteLine($"Preço do Jogo: " + (this.preco).ToString(format: "C"));
            if(classificacao == 0)
            {
                Console.WriteLine($"Classificação do Jogo:" + "Livre");
            }
            else
            {
                Console.WriteLine($"Classificação do Jogo:" + this.classificacao);
            }
            Console.WriteLine($"Nota do Jogo: {this.nota}" + "/10");

        }
    }
}
