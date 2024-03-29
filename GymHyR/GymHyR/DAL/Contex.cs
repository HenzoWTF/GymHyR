﻿using Library.Models;
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
            modelBuilder.Entity<TipoMembresias>().HasData(new TipoMembresias() { TipoMembresiaId = 1, Descripcion = "Mensual", DiasDuracion = 30, });
            modelBuilder.Entity<TipoMembresias>().HasData(new TipoMembresias() { TipoMembresiaId = 2, Descripcion = "Semanal", DiasDuracion = 5 });
            modelBuilder.Entity<TipoMembresias>().HasData(new TipoMembresias() { TipoMembresiaId = 3, Descripcion = "Diario", DiasDuracion = 1 });

            modelBuilder.Entity<EstadoMembresias>().HasData(new EstadoMembresias() { EstadoMembresiaId = 1, Descripcion = "Activa"});
            modelBuilder.Entity<EstadoMembresias>().HasData(new EstadoMembresias() { EstadoMembresiaId = 2, Descripcion = "Vencida" });

            modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 1, Nombre = "Génerico",Cedula = "123",Gmail = "Vencida" , Fecha = DateTime.Today, Telefono = "Diario", });

            }
    }
}


