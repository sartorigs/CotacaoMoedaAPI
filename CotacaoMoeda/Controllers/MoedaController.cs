using CotacaoMoeda.Entidades;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoedaController : ControllerBase
    {
        private readonly IMoedaRepository _moedaRepository;
        public MoedaController(IMoedaRepository moedaRepository)
        {
            _moedaRepository = moedaRepository;
        }

        [HttpPost]
        [Route("salvar-moeda")]
        public bool SalvarMoeda([FromBody] MoedaModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var moeda = new Moeda()
                    {
                        Id = model.Id,
                        Nome = model.Nome,
                        Sigla = model.Sigla,
                        Pais = model.Pais
                        
                    };
                    return _moedaRepository.Salvar(moeda);
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
        [Route("pegar-moedas")]
        public List<Moeda> BuscarMoedas()
        {
            return _moedaRepository.BuscarMoedas();
        }




    }
}
