

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senac.Foods
{
    public class Mesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int NumeroMesa { get; set; }
        // 0 - Livre, 1 - Ocupada, 2 - Reservada
        public int SituaçãoMesa { get; set; } 
    }
}
