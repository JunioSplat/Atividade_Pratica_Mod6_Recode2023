using JuninViagens.Model;
using Microsoft.EntityFrameworkCore;

namespace JuninViagens.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
new Cliente { Id = 1, cepCli = "85960000", EmailCli = "junio@gmail", enderecoCli = "Rua Amilton 13", nomeCli = "Junio Henrique" },

        new Cliente { Id = 2, cepCli = "85960000", EmailCli = "anaclara@gmail", enderecoCli = "Rua das Flores 130", nomeCli = "Ana Clara" },

        new Cliente { Id = 3, cepCli = "85960000", EmailCli = "mduarda@gmail", enderecoCli = "Rua XV de Novembro 4545", nomeCli = "Maria Eduarda" },

        new Cliente { Id = 4, cepCli = "85960000", EmailCli = "carlosfernando@gmail", enderecoCli = "Rua Santana 4545", nomeCli = "Carlos Fernando" }
            );

        }

    }
}