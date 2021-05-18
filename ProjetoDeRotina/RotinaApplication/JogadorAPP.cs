using ProjetoDeRotina.Domain.Entities;
using ProjetoDeRotina.Domain.Service;
using RotinaApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaApplication
{
    public class JogadorAPP : IJogadorAppService
    {
        private readonly IJogadorService _jogadorService;
        public JogadorAPP(IJogadorService jogadorService)
        {
            _jogadorService = jogadorService;
        }
        public Jogador Adicionar(Jogador jogador)
        {
           return  _jogadorService.Adicionar(jogador);
        }

        public Jogador Alterar(Jogador jogador)
        {
           return _jogadorService.Alterar(jogador);
        }
        public void Remover(decimal id)
        {
            _jogadorService.Remover(id);
        }

        public Jogador ObterJogador()
        {
            return _jogadorService.ObterJogador();
        }

        public void Dispose()
        {
            _jogadorService.Dispose();
        }

        
    }
}
