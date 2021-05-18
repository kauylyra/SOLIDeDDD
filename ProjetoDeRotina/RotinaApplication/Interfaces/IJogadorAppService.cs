﻿using ProjetoDeRotina.Domain.Entities;
using System;


namespace RotinaApplication.Interfaces
{
    public interface IJogadorAppService : IDisposable
    {
        Jogador Adicionar(Jogador jogador);

        Jogador Alterar(Jogador jogador);

        void Remover(decimal id);

        Jogador ObterJogador();
    }
}
