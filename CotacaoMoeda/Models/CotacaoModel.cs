using System;
using System.Text.Json.Serialization;

namespace CotacaoMoeda.Models
{
    public class CotacaoModel
    {
        public long Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data{ get; set; }
        public long MoedaId { get; set; }
        [JsonIgnore]
        public MoedaModel Moeda { get; set; }
    }
}
