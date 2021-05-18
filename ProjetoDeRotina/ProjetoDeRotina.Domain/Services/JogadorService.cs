using ProjetoDeRotina.Domain.Entities;
using ProjetoDeRotina.Domain.Interfaces.Repository;
using ProjetoDeRotina.Domain.Service;
using System;
using System.Collections.Generic;

namespace ProjetoDeRotina.Domain.Services
{
    public class JogadorService : IJogadorService 
    {
        private readonly IRepositoryBase _repositoryBase;
        public JogadorService(IRepositoryBase jogadorRepository)
        {
            _repositoryBase = jogadorRepository;
        }
        public Jogador Adicionar(Jogador jogador)
        {
            return _repositoryBase.Adicionar(jogador);
        }

        public Jogador Alterar(Jogador jogador)
        {
           return _repositoryBase.Alterar(jogador);
        }

        public void Remover(decimal id)
        {
            _repositoryBase.Remover(id);
        }

        public Jogador ObterJogador()
        {
            return _repositoryBase.ObterJogador();
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

       
    }
}
