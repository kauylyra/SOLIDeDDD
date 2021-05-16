using ProjetoDeRotina.Domain.Entities;
using System;

namespace ProjetoDeRotina.Domain.Service
{
    public interface IJogadorService : IDisposable
    {
        Jogador Adicionar(Jogador jogador);
        Jogador ObterPorId(Guid id);
        void Remover(Guid id);
    }
}
