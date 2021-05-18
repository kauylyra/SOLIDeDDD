using ProjetoDeRotina.Domain.Entities;
using ProjetoRotina.Infra;
using RotinaApplication.Interfaces;
using SimpleInjector;
using System;

namespace Rotina
{
    class Program
    {
        private static readonly Container container;
        static Program()
        {
            container = new Container();
            ServiceLocator.RegisterServices(container);

            container.Verify();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para incluir um Jogador ao time");
            Executar();
            Console.WriteLine("Fim.");
            Console.ReadKey();
        }

        static void Executar()
        {
            var app = container.GetInstance<IJogadorAppService>();
            Jogador jogador = new Jogador()
            {
                Nome = "bla",
                Nome_Time = "",
                Estado = "",
                Salario = 6000
            };
            app.Adicionar(jogador);
            var jogador2 = new Jogador()
            {
                Nome = "",
                Nome_Time = "",
                Estado = "",
                Salario = 4000
            };
            app.Adicionar(jogador2);
            app.Alterar(jogador2);
            app.Remover(jogador2.ID_Jogador);
            Console.WriteLine("E-mail enviado com Sucesso!");
        }
    }
}
