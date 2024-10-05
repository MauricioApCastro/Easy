using System.Data.Entity;

namespace Easy.Models
{
    public class MeuContexto : DbContext
    {
        // DbSet para a entidade Exercício
        public DbSet<Exercicio> Exercicios { get; set; }

        public MeuContexto() : base("name=MinhaConexao") // Nome da string de conexão
        {
        }

        // Configurações adicionais podem ser feitas aqui
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurações de mapeamento, se necessário
        }
    }
}

