using Microsoft.EntityFrameworkCore;
using WebApi.Models;

/*      Aplicaciones Web Orientada a Servicios

        CUATRIMESTRE 4
        SEGUNDO PARCIAL

        API BOOK

        Profesor: 
        I.S.C. Ruth Betsaida Martínez Domínguez

        Alumno:
        ANGEL EDUARDO PUC BARRERA
        
        Fecha de entrega
        20 Octubre 2022

 */
namespace WebApi.Data;
public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base (options) {

    }   

    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Book>()
            .HasOne(e => e.Author)
            .WithMany(e => e.Books)
            .IsRequired(false);

        builder.Entity<Book>()
            .HasOne(e => e.Editorial)
            .WithMany(e => e.Books)
            .IsRequired(false);

        builder.Entity<User>()
            .HasMany(e => e.Prestamos)
            .WithOne(e => e.User)
            .IsRequired(false);
          
    }



    public DbSet<Book> Books { get; set; } = default!;
    public DbSet<Author> Authors { get; set; } = default!;
    public DbSet<Editorial> Editorials { get; set; } = default!;
    public DbSet<User> Users { get; set; } = default!;
    public DbSet<Prestamo> Prestamos { get; set; } = default!;



}