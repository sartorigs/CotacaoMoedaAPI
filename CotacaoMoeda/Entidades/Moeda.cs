using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CotacaoMoeda.Entidades
{
    public class Moeda : BaseEntity
    {
        [Required,MaxLength(60)]
        public string Nome { get; set; }
        [Required,MaxLength(10)]
        public string Sigla { get; set; }
        [MaxLength(80)]
        public string Pais { get; set; }
        [JsonIgnore]
        public List<Cotacao> Cotacoes { get; set; }

    }
}
