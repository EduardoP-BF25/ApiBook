using WebApi.Models.Base;

namespace WebApi.Models;

public class Editorial: Model
{
    public string? Name {get; set;}
    public string? ISBN {get; set;}
    public string? City {get; set;}
    public string? Email {get; set;}
    public virtual IList<Book>? Books { get; set; } = default!;
    
    public virtual IList<Editorial>? Editorials { get; set; } = default!;



}
