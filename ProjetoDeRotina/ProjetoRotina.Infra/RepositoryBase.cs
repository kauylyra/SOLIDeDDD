using ProjetoDeRotina.Domain.Entities;
using ProjetoDeRotina.Domain.Interfaces.Repository;
using ProjetoRotina.Infra.Context;


namespace ProjetoRotina.Infra
{
    public class RepositoryBase : IRepositoryBase
    {
        private readonly ProjetoRotinaContext _context;
        public RepositoryBase(ProjetoRotinaContext context)
        {
            _context = context;
        }
        public Jogador Adicionar(Jogador jogador)
        {
           return _context.Adicionar(jogador);
        }

        public Jogador Alterar(Jogador jogador)
        {
           return _context.Alterar(jogador);
        }

        public void Remover(decimal id)
        {
            _context.Remover(id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Jogador ObterJogador()
        {
            return _context.ObterJogador();
        }
    }
}
/*Entry(jogador).State = EntityState.Modified;*/
