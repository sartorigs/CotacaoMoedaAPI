using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CotacaoMoeda.Repositorios
{
    public class CotacaoRepository : ICotacaoRepository
    {
        private readonly CotacaoContext _context;

        public CotacaoRepository(CotacaoContext context)
        {
            _context = context;
        }

        public bool Salvar(Cotacao cotacao)
        {
            try
            {
                if(cotacao.Id == 0)
                    _context.Cotacoes.Add(cotacao);
                else
                    _context.Cotacoes.Update(cotacao);
                _context.SaveChanges();
                return true;
            }catch
            {
                return false;
            }

        }

        public Cotacao BuscarCotacao(long moedaId, DateTime data)
        {

           return _context.Cotacoes.Where(c => c.MoedaId == moedaId && c.Data == data)
                                   .FirstOrDefault();
        }



    }
}
