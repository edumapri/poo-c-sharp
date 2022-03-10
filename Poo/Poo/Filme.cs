using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Filme
    {
        // Acessivel de todas as classes
        public string nome;
        public string desc;
        public int ano;
        public string studio;

        /*
        public List<string> atores = new List<string>();
        */
        // Só a classe "Filme" e seus métodos tem acesso a essa variável (EMCAPSULAMENTO)
        private List<string> atores = new List<string>();


        // Método Construtor "Filme"
        public Filme(string nome, string desc, int ano, string studio)
        {
            this.nome = nome;// Com o uso this estou trabalhando com atributo nome dessa classe
            this.desc = desc;
            this.ano = ano;
            this.studio = studio;
        }


        // Variável static, similar a uma varíavel Global
        static public string plataforma = "Prime Video";

        public void Executar()
        {
            Console.WriteLine(atores);//Uso da variável privada da classe
            Console.WriteLine("Rodando filme: " + nome);
        }

        // Conseguimos acessar esse método sem a necessidade de instanciar um objeto
        // Métodos static não podem acessar atributos de instância da classe, somente variáveis static
        static public void Pausar()
        {
            Console.WriteLine("\n" + plataforma); // acessamos "plataforma" por ela ser static
        }

        public void AddAtor(string nome)
        {
            if (nome != null)
            {
                if (nome.Length > 4)
                {
                    atores.Add(nome);
                }
            }
        }

        public void ExibirAtores()
        {
            foreach (string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }

    }
}