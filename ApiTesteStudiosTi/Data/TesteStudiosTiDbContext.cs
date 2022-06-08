using ApiTesteStudiosTi.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTesteStudiosTi.Data
{
    public class TesteStudiosTiDbContext : DbContext
    {
        public TesteStudiosTiDbContext(DbContextOptions<TesteStudiosTiDbContext> options) : base(options)
        {

        }
        public DbSet<Profissional> profissionais { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Profissional>().ToTable("tb_profissionais");
            builder.Entity<Profissional>().HasKey(p => p.Id);
            builder.Entity<Profissional>().Property(p => p.Id).HasColumnName("id").IsRequired();
            builder.Entity<Profissional>().Property(p => p.NomeCompleto).HasColumnName("nomeCompleto").IsRequired();
            builder.Entity<Profissional>().Property(p => p.Telefone).HasColumnName("telefone").IsRequired();
            builder.Entity<Profissional>().Property(p => p.Rg).HasColumnName("rg").IsRequired();
            builder.Entity<Profissional>().Property(p => p.Endereco).HasColumnName("endereco").IsRequired();
            builder.Entity<Profissional>().Property(p => p.Salario).HasColumnName("salario").IsRequired();
        }
    }
}
