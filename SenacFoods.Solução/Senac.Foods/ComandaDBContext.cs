
using Microsoft.EntityFrameworkCore;

namespace Senac.Foods
{
    public class ComandaDBContext:DbContext
    {
        private object serverVersion;
        private object conexao;

        public ComandaDBContext():base()
        {
            
        }
        // configurar conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "Server=localhost;Database=SenacFoocs;User=root;Password=";

            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Usuario> Usuario  { get; set; }
        public DbSet<C> Cs { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public required Dbste<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
        public required DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
    }
}
