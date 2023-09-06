
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoWebJovemProgramador.Models;

namespace ProjetoWebJovemProgramador.Data.Mapeamento
{
    public class LoginMapeamento : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Usuario");



            builder.HasKey(t => t.Id);



            builder.Property(t => t.Usuario).HasColumnType("varchar(150)");
            builder.Property(t => t.Senha).HasColumnType("varchar(35)");
        }
    }
}
