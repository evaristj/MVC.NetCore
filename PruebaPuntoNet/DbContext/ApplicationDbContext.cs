using Microsoft.EntityFrameworkCore;
using PruebaPuntoNet.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de la relación uno a muchos entre Departamento y Empleado
        modelBuilder.Entity<Departamento>()
            .HasMany(d => d.Empleados)
            .WithOne(e => e.Departamento)
            .HasForeignKey(e => e.DepartamentoId);
    }
}
