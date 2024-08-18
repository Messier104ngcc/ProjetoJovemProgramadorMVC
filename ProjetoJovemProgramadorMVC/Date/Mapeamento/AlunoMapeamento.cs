using Microsoft.EntityFrameworkCore;
using ProjetoJovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoJovemProgramadorMVC.Date.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Matricula).HasColumnType("varchar(20)");
            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");
        }
    }
}
