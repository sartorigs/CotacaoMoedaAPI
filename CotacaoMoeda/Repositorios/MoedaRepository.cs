using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CotacaoMoeda.Repositorios
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly CotacaoContext _context;
        public MoedaRepository(CotacaoContext context)
        {
            _context = context;
        }

        public bool Salvar(Moeda moeda)
        {
            try
            {
                if(moeda.Id == 0)
                    _context.Moedas.Add(moeda);
                else
                {
                    _context.Moedas.Update(moeda);
                }

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Moeda> BuscarMoedas()
        {
            return _context.Moedas.ToList();
        }

    }
}
