using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Aluno : Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";


        // Construtor em herança
        public Aluno(string turno, string nome, string email, string senha) : base(nome, email, senha)
        {
            this.turno = turno;
        }

        // Polimorfismo - "override" é sobrepor da classe pai "Usuario"
        public override void Exibir()
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine("\nDados do aluno\n");
            base.Exibir();
            Console.WriteLine("Turno " + turno + "\n");
        }
    }

 

    
}
