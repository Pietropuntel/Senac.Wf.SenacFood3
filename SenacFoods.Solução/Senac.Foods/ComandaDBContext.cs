
using Microsoft.EntityFrameworkCore;

namespace Senac.Foods
{
    internal class ComandaDBContext:DbContext
    {
        public DbSet<usuario> usuario  { get; set; }
        public DbSet<C> Cs { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
    }
}
