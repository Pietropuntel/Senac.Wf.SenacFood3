
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senac.Foods;

public class ComandaItem
{
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
public int Id { get; set; }
    public int ComandaId { get; set; }
    public int Comanda { get; set; }


}
