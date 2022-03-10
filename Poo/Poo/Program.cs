using Poo; // para acessar classes internas de Poo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme("Rambo 1", "O Resgate", 1979, "Universal");
            Filme eraDoGelo = new Filme("Era do gelo 1", "bebê", 2002, "Pixar");

            // Console.WriteLine(eraDoGelo.nome);
            // Console.WriteLine(eraDoGelo.desc);

            /*
            eraDoGelo.atores.Add("Eduardo Herrera");
            // deixar lista atores null
            eraDoGelo.atores = null;
            // apagar a lista atores de eraDogelo
            eraDoGelo.atores.Clear();
            */

            // Métodos publicos adicionando informações em atributos privados da classe Filme
            // eraDoGelo.AddAtor("Eduardo Herrera");
            // eraDoGelo.ExibirAtores();




            // Acessar a variável static "plataforma" da classe "Filme"
            // Filme.plataforma = "Amazon Prime";

            // Acessar o método static Pausar()
            // Filme.Pausar();

            Aluno a = new Aluno("Vespertino", "Eduardo", "edumapri@gmail.com", "Pir123"); ;
            /*
            a.nome = "Eduardo";
            a.email = "edumapri@gmail.com";
            a.senha = "poly123";
            */
            // Acesso especificos da classe Aluno
            // a.turno = "Vespertino";
            // Acesso ao método "logar()" da classe pai "Usuario"
            // a.Logar();

            a.Exibir();

            

            Zelador z = new Zelador("Lira", "lira@outlook.com", "Br123");
            /*
            z.nome = "Lira";
            z.email = "lira@outlook.com";
            z.senha = "Br123";
            */
            z.Exibir();


            // Polimorfismo
            Usuario p = new Aluno("Vespertino", "Igor", "igor@gmail.com", "Tir123");
            Usuario p2 = new Zelador("Lira", "lira@outlook.com", "Br123");

            // Casting de variáveis do tipo pai para fiho
            Console.WriteLine(((Aluno)p).turno);

            p.Exibir();
            p2.Exibir();

            // Polimorfismo de sobrecarga
            // Logar(string, string)
            a.Logar("seven@gmail.com", "sssssssssssss");
            // Logar(int, string)
            a.Logar(123, "six@gmail.com");



            // Poliformismo de sobreposição
            a.Exibir();

            Console.ReadLine();

        }
    }
}
