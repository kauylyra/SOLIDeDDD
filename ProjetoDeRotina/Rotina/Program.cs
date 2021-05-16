using ProjetoDeRotina.Domain.Entities;
using ProjetoDeRotina.Domain.Services;
using System;

namespace Rotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string nome_Time = "";
            string estado = "";
            int salario = 0;
            Console.WriteLine("Programa para incluir um Jogador ao time");
            Console.WriteLine("Informe o NOME do jogador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o NOME do time que joga: ");
            nome_Time = Console.ReadLine();
            Console.WriteLine("Informe qual o estado do time:  ");
            estado = Console.ReadLine();
            Console.WriteLine("Informe qual o salário que o jogador ganha. ");
            salario = int.Parse(Console.ReadLine());
            Jogador jogador = new Jogador()
            {
                Nome = nome,
                Nome_Time = nome_Time,
                Estado = estado,
                Salario = salario
            };
            JogadorService jogadorService = new JogadorService();
            var addJogador = jogadorService.Adicionar(jogador);
            Console.WriteLine(addJogador);
            Console.ReadKey();
        }
    }
}
