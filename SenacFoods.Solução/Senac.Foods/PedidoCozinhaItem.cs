

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senac.Foods;

public class PedidoCozinhaItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int PedadoCozinhaId { get; set; }
    public int ComandaItemId { get; set; }
}
