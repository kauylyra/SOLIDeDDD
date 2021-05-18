using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeRotina.Domain.Entities
{
    public class Jogador
    {
        public Jogador()
        {

        }
        public decimal ID_Jogador { get; set; }
        public String Nome { get; set; }
        public string Nome_Time { get; set; }
        public string Estado { get; set; }
        public int Salario { get; set; }
        //public string Email { get; set; }
    }
}
