using CotacaoMoeda.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Context
{
    public class CotacaoContext : DbContext
    {
        public CotacaoContext(DbContextOptions<CotacaoContext> options) : base(options) { }

        public DbSet<Moeda> Moedas { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
