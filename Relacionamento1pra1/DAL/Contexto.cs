using Microsoft.EntityFrameworkCore;
using Relacionamento1pra1.Models;

namespace Relacionamento1pra1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoass { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Quando usarmos o FluentAPI colocaremos as referencias aqui de relacionamento
            modelBuilder.Entity<Pessoa>()
                   .HasOne(p => p.Endereco)
                   .WithOne(e => e.Pessoa)
                   .HasForeignKey<Endereco>(e => e.PessoaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
