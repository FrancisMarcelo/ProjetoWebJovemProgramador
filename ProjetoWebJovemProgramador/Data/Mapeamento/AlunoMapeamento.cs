
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");



            builder.HasKey(t => t.Id);



            builder.Property(t => t.Nome).HasColumnType("varchar(150)");
            builder.Property(t => t.Email).HasColumnType("varchar(150)");
            builder.Property(t => t.Cep).HasColumnType("varchar(15)");
            builder.Property(t => t.Idade).HasColumnType("int");
        }
    }
}
