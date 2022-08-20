using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CotacaoMoeda.Entidades
{
    public class Cotacao : BaseEntity
    {
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
        
        public long MoedaId { get; set; }
        [JsonIgnore]
        public Moeda Moeda { get; set; }
    }
}
