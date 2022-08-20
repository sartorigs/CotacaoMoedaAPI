using CotacaoMoeda.Entidades;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotacaoController : ControllerBase
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoController(ICotacaoRepository cotacaoRepository)
        {
            _cotacaoRepository = cotacaoRepository;
        }

        [HttpPost]
        [Route("salvar-cotacao")]
        public bool SalvarCotacao([FromBody] CotacaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cotacao = new Cotacao()
                    {
                        Id = model.Id,
                        Valor = model.Valor,
                        Data = model.Data,
                        MoedaId = model.MoedaId          
                    };
                    return _cotacaoRepository.Salvar(cotacao);

                }
                catch
                {
                    return false;
                }
            }
            else
                return false;
        }

        [HttpGet]
        [Route("pegar-cotacao")]
        public Cotacao BuscarCotacao(long id, DateTime data)
        {
            return _cotacaoRepository.BuscarCotacao(id, data);
        }
    }
}
