using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Zelador : Usuario
    {
        // Construtor em herança
        public Zelador(string nome, string email, string senha) : base(nome, email, senha)
        {
        }
    }
}
