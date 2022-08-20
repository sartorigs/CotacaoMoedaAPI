using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Entidades
{
    public class BaseEntity
    {
        [Required,Key]
        public long Id { get; set; }
    }
}
