using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{
    public DateTime DPrestamo{get; set;}
    public DateTime DDevolucion {get; set;}

    public string? Devolucion {get; set;}

    public virtual Book? Book { get; set; } = default!;
    public virtual User? User { get; set; } = default!;


}
