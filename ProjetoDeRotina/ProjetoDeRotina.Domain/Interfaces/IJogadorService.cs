using ProjetoDeRotina.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoDeRotina.Domain.Service
{
    public interface IJogadorService : IDisposable
    {
        Jogador Adicionar(Jogador jogador);
        Jogador Alterar(Jogador jogador);
        void Remover(decimal id);
        Jogador ObterJogador();
        //List<Jogador> ObterTodos(/*string nome, string nome_Time,string estado, int salario*/);
    }
}
