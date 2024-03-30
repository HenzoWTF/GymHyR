using Library.Models;
using Microsoft.EntityFrameworkCore;


namespace GymHyR.DAL
{
    public class Context : DbContext
    {

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Membresias> Membresias { get; set; }
        public DbSet<TipoMembresias> TipoMembresias { get; set; }
        public DbSet<EstadoMembresias> EstadoMembresias { get; set; }
        public DbSet<Visitas> Visitas { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoMembresias>().HasData(new TipoMembresias() { TipoMembresiaId = 1, Descripcion = "Mensual", DiasDuracion = 30, Precio = 1500 });
            modelBuilder.Entity<TipoMembresias>().HasData(new TipoMembresias() { TipoMembresiaId = 2, Descripcion = "Semanal", DiasDuracion = 5, Precio = 400 });
            modelBuilder.Entity<TipoMembresias>().HasData(new TipoMembresias() { TipoMembresiaId = 3, Descripcion = "Diario", DiasDuracion = 1, Precio = 150 });

            modelBuilder.Entity<EstadoMembresias>().HasData(new EstadoMembresias() { EstadoMembresiaId = 1, Descripcion = "Activa"});
            modelBuilder.Entity<EstadoMembresias>().HasData(new EstadoMembresias() { EstadoMembresiaId = 2, Descripcion = "Vencida" });

            modelBuilder.Entity<Clientes>().HasData(new Clientes() { Cedula = "402-0054036-0", Nombre = "Génerico",Gmail = "Vencida" , Fecha = DateTime.Today, Telefono = "Diario", });

            }
    }
}


