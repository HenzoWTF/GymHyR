﻿// <auto-generated />
using System;
using GymHyR.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymHyR.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Library.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoriaNombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Library.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Cedula = "123",
                            Fecha = new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Gmail = "Vencida",
                            Nombre = "Génerico",
                            Telefono = "Diario"
                        });
                });

            modelBuilder.Entity("Library.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FecheDeCompra")
                        .HasColumnType("TEXT");

                    b.HasKey("CompraId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("Library.CompraDetalle", b =>
                {
                    b.Property<int>("CompraDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompraDetalleId");

                    b.HasIndex("CompraId");

                    b.ToTable("CompraDetalle");
                });

            modelBuilder.Entity("Library.Contactos", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ContactoId");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("Library.EstadoMembresias", b =>
                {
                    b.Property<int>("EstadoMembresiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("EstadoMembresiaId");

                    b.ToTable("EstadoMembresias");

                    b.HasData(
                        new
                        {
                            EstadoMembresiaId = 1,
                            Descripcion = "Activa"
                        },
                        new
                        {
                            EstadoMembresiaId = 2,
                            Descripcion = "Vencida"
                        });
                });

            modelBuilder.Entity("Library.Membresias", b =>
                {
                    b.Property<int>("MembresiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstadoMembresiaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaFechaFin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoMembresiaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MembresiaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoMembresiaId");

                    b.HasIndex("TipoMembresiaId");

                    b.ToTable("Membresias");
                });

            modelBuilder.Entity("Library.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("REAL");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("REAL");

                    b.Property<string>("Proveedores")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Library.ProveedorDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ContactoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("ContactoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("ProveedorDetalle");
                });

            modelBuilder.Entity("Library.Proveedores", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("RNC")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Library.TipoMembresias", b =>
                {
                    b.Property<int>("TipoMembresiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasDuracion")
                        .HasColumnType("INTEGER");

                    b.HasKey("TipoMembresiaId");

                    b.ToTable("TipoMembresias");

                    b.HasData(
                        new
                        {
                            TipoMembresiaId = 1,
                            Descripcion = "Mensual",
                            DiasDuracion = 30
                        },
                        new
                        {
                            TipoMembresiaId = 2,
                            Descripcion = "Semanal",
                            DiasDuracion = 5
                        },
                        new
                        {
                            TipoMembresiaId = 3,
                            Descripcion = "Diario",
                            DiasDuracion = 1
                        });
                });

            modelBuilder.Entity("Library.CompraDetalle", b =>
                {
                    b.HasOne("Library.Compra", null)
                        .WithMany("CompraDetalles")
                        .HasForeignKey("CompraId");
                });

            modelBuilder.Entity("Library.Membresias", b =>
                {
                    b.HasOne("Library.Clientes", null)
                        .WithMany("Membresias")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.EstadoMembresias", null)
                        .WithMany("Membresias")
                        .HasForeignKey("EstadoMembresiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.TipoMembresias", null)
                        .WithMany("Membresias")
                        .HasForeignKey("TipoMembresiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.ProveedorDetalle", b =>
                {
                    b.HasOne("Library.Contactos", null)
                        .WithMany("ProveedoresDetalleContactos")
                        .HasForeignKey("ContactoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Proveedores", null)
                        .WithMany("ProveedoresDetalle")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Clientes", b =>
                {
                    b.Navigation("Membresias");
                });

            modelBuilder.Entity("Library.Compra", b =>
                {
                    b.Navigation("CompraDetalles");
                });

            modelBuilder.Entity("Library.Contactos", b =>
                {
                    b.Navigation("ProveedoresDetalleContactos");
                });

            modelBuilder.Entity("Library.EstadoMembresias", b =>
                {
                    b.Navigation("Membresias");
                });

            modelBuilder.Entity("Library.Proveedores", b =>
                {
                    b.Navigation("ProveedoresDetalle");
                });

            modelBuilder.Entity("Library.TipoMembresias", b =>
                {
                    b.Navigation("Membresias");
                });
#pragma warning restore 612, 618
        }
    }
}
