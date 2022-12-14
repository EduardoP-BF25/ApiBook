using WebApi.Models.Base;

namespace WebApi.Models;

public class User: Model
{
    public string? Name {get; set;}
    public string? LastName {get; set;}
    public string? Direcction {get; set;}
    public int? Cellphone {get; set;}
    public string? Email {get; set;}
    public DateTime? BirthDay {get; set;}
    
    public virtual IList<Prestamo>? Prestamos { get; set; } = default!;
}
