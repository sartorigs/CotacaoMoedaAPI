using CotacaoMoeda.Entidades;
using System;

namespace CotacaoMoeda.Repositorios.Interfaces
{
    public interface ICotacaoRepository
    {
        bool Salvar(Cotacao cotacao);

        Cotacao BuscarCotacao(long moedaId, DateTime data);
    }
}
