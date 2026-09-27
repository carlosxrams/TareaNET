using Microsoft.EntityFrameworkCore;
namespace TareaNET.Models;

public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options) : base(options)
    {
    }
    public DbSet<Clientes> Clientes { get; set; }
}