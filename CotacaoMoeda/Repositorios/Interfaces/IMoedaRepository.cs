using CotacaoMoeda.Entidades;
using System.Collections.Generic;

namespace CotacaoMoeda.Repositorios.Interfaces
{
    public interface IMoedaRepository
    {
        bool Salvar(Moeda moeda);
        List<Moeda> BuscarMoedas();
    }
}
