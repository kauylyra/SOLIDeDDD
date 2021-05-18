using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRotinaModelo.ViewModel
{
    public class JogadorViewModel
    {
        [Key]
        public Guid Id_Jogador { get; set; }
        public String Nome { get; set; }
        public string Nome_Time { get; set; }
        public string Estado { get; set; }
        public int Salario { get; set; }
        public string Email { get; set; }
    }
}
