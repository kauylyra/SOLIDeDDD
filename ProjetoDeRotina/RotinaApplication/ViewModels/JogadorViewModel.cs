using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace RotinaApplication.ViewModels
{
    public class JogadorViewModel
    {
        [Key]
        public Guid Id_Jogador { get; set; }
        public String Nome { get; set; }
        public string Nome_Time { get; set; }
        public string Estado { get; set; }
        public int Salario { get; set; }
    }
}
