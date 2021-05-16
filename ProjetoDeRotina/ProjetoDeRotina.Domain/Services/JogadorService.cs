using ProjetoDeRotina.Domain.Entities;
using ProjetoDeRotina.Domain.Interfaces.Repository;
using ProjetoDeRotina.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeRotina.Domain.Services
{
    public class JogadorService : IJogadorService
    {
        private readonly IJogadorService _jogadorService;
        public Jogador Adicionar(Jogador jogador)
        {
            return _jogadorService.Adicionar(jogador);
        }

        public Jogador ObterPorId(Guid id)
        {
            return _jogadorService.ObterPorId(id);
        }

        public void Remover(Guid id)
        {
            _jogadorService.Remover(id);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
