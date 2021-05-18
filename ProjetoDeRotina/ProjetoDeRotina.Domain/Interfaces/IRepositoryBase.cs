using ProjetoDeRotina.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoDeRotina.Domain.Interfaces.Repository
{
    public interface IRepositoryBase :IDisposable
    {
        Jogador Adicionar(Jogador jogador);
        Jogador Alterar(Jogador jogador);
        void Remover(decimal id);
        //Jogador ObterJogador();
        void Dispose();
    }
}
