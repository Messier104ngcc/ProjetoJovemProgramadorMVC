using Microsoft.EntityFrameworkCore;
using ProjetoJovemProgramadorMVC.Date.Mapeamento;
using ProjetoJovemProgramadorMVC.Models;

namespace ProjetoJovemProgramadorMVC.Date
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=MESSIER104NGC\\\\SQLEXPRESS;Initial Catalog=WebSystem;Integrated Security=True;Trust Server Certificate=True");
        //}

        //public DbSet<Usuario> Usuarios { get; set; }
    }
}
