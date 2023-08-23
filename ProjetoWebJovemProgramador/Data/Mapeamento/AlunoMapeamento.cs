using Microsoft.AspNetCore.Mvc;
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



            builder.Property(t => t.Nome).HasColumnType("varchar(50)");


        }
    }
}
