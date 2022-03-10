using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;

        // variável privada, somente ativo na classe
        private string teste = "teste";

        // variavel protect, pode ser usada pela classe pai (Usuario) e classes filhas (Aluno e Zelador)
        protected string teste2 = "teste2";

        // Construtor da classe pai Usuario
        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        // Assinatura desse método Logar(void)
        public void Logar()
        {
            Console.WriteLine(teste);
            Console.WriteLine("Logando...");
        }

        // Polimorfismo sobrecarga - Assinatura desse método Logar(string)
        public void Logar(string codigo)
        {
            Console.WriteLine("Logando com cod...");
        }

        // Polimorfismo sobrecarga - Assinatura desse método Logar(string, string)
        public void Logar(string email, string senha)
        {
            Console.WriteLine("Logando com email e senha...");
        }

        // Polimorfismo sobrecarga - Assinatura desse método Logar(string, int)
        public void Logar(string email, int pin)
        {
            Console.WriteLine("Logando com email e pin...");
        }

        // Polimorfismo sobrecarga - Assinatura desse método Logar(int,string)
        public void Logar(int pin, string email)
        {
            Console.WriteLine("Logando com pin e email...");
        }

        // Polimorfismo, sobreposição com o uso de "virtual"
        public virtual void Exibir()
        {
            Console.WriteLine($"Email: {email}\n");
            Console.WriteLine($"Nome: {nome}\n");
            Console.WriteLine($"Senha: {senha}\n");
            Console.WriteLine("=============================\n");
        }

        /*
        public void Exibir()
        {
            Console.WriteLine($"Email: {email}\n");
            Console.WriteLine($"Nome: {nome}\n");
            Console.WriteLine($"Senha: {senha}\n");
            Console.WriteLine("=============================\n");
        }
        */
    }
}
