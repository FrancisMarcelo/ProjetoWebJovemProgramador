using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoWebJovemProgramador.Data.Mapeamento;
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginMapeamento());
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }
       
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
