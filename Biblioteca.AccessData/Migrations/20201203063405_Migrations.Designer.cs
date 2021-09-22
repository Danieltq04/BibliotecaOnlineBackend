﻿// <auto-generated />
using System;
using Biblioteca.AccessData.BibliotecaDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.AccessData.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20201203063405_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.Domain.Entities.Alquiler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoDeAlquilerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaAlquiler")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaReserva")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoDeAlquilerId");

                    b.HasIndex("ISBN");

                    b.ToTable("Alquileres");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellido = "Garcia",
                            DNI = "12345678",
                            Email = "pepegarcia@gmail.com",
                            Nombre = "Pepe"
                        });
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.EstadoDeAlquiler", b =>
                {
                    b.Property<int>("EstadoDeAlquilerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("EstadoDeAlquilerId");

                    b.ToTable("EstadoDeAlquiler");

                    b.HasData(
                        new
                        {
                            EstadoDeAlquilerId = 1,
                            Descripcion = "Reservado"
                        },
                        new
                        {
                            EstadoDeAlquilerId = 2,
                            Descripcion = "Alquilado"
                        },
                        new
                        {
                            EstadoDeAlquilerId = 3,
                            Descripcion = "Cancelado"
                        });
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Libro", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Edicion")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("ISBN");

                    b.ToTable("Libro");

                    b.HasData(
                        new
                        {
                            ISBN = "970-24-0779-6",
                            Autor = "Gabriela Campbell",
                            Edicion = "1ra",
                            Editorial = "Grupo Editorial Patria",
                            Imagen = "http://fantifica.com/wp-content/uploads/2017/02/El-cielo-roto-Portada-340x544.jpg",
                            Stock = 7,
                            Titulo = "Crónicas Del Fin - El Cielo Roto"
                        },
                        new
                        {
                            ISBN = "968-880-205-0",
                            Autor = "Thelma Carr",
                            Edicion = "2da",
                            Editorial = "Person Education",
                            Imagen = "https://s3.amazonaws.com/virginia.webrand.com/virginia/344/LEqKdMKtOj8/c9e74d28a1a2e698f62446b8e5345254.jpg",
                            Stock = 15,
                            Titulo = "Monsters"
                        },
                        new
                        {
                            ISBN = "978-84-205-4462-5",
                            Autor = "Lucas Lloyd",
                            Edicion = "5ta",
                            Editorial = "Prentice Hall",
                            Imagen = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/sci-fi-book-cover-template-a1ec26573b7a71617c38ffc6e356eef9_screen.jpg?ts=1561547637",
                            Stock = 0,
                            Titulo = "The Arrivals"
                        },
                        new
                        {
                            ISBN = "0-13-24310-9",
                            Autor = "Pilar Mayo",
                            Edicion = "8va",
                            Editorial = "Christianna Lee",
                            Imagen = "https://i.pinimg.com/236x/9c/ef/63/9cef638f1327bed70d7f15fa71c0b79f.jpg",
                            Stock = 11,
                            Titulo = "Los abrazos robados"
                        },
                        new
                        {
                            ISBN = "84-7829-074-5",
                            Autor = "J. K. Rowling",
                            Edicion = "7ma",
                            Editorial = "Pearson Education",
                            Imagen = "https://juanjelopezponeletras.files.wordpress.com/2017/04/harry-potter-olly-moss-goblet-of-fire.png",
                            Stock = 4,
                            Titulo = "Harry Potter y el Caliz de Fuego"
                        },
                        new
                        {
                            ISBN = "0-8053-5340-2",
                            Autor = "Lola Sutton",
                            Edicion = "2da",
                            Editorial = "ADDISON-WESLEY",
                            Imagen = "https://s3.amazonaws.com/virginia.webrand.com/virginia/344/KCVmVk4cdl7/202852714dec217e579db202a977be70.jpg",
                            Stock = 9,
                            Titulo = "Surviving the Abyss"
                        },
                        new
                        {
                            ISBN = "978-0-13-607373-4",
                            Autor = "J. K. Rowling",
                            Edicion = "8va",
                            Editorial = "Prentice Hall",
                            Imagen = "https://juanjelopezponeletras.files.wordpress.com/2017/04/harry-potter-olly-moss-prisoner-of-azkabanefe.png",
                            Stock = 10,
                            Titulo = "Harry Potter y el Prisionero de Azkaban"
                        },
                        new
                        {
                            ISBN = "978-84-9035-528-2",
                            Autor = "Gabriela Campbell",
                            Edicion = "7ma",
                            Editorial = "Pearson Education",
                            Imagen = "http://www.esferalibros.com/uploads/imagenes/libros/principal/201804/principal-portada-cronicas-del-fin-es_med.jpg",
                            Stock = 12,
                            Titulo = "Crónicas del fin - Una grieta en el cielo"
                        },
                        new
                        {
                            ISBN = "978-8432432",
                            Autor = "Angelina Aludo",
                            Edicion = "7ma",
                            Editorial = "Pearson Education",
                            Imagen = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/contemporary-fiction-night-time-book-cover-design-template-1be47835c3058eb42211574e0c4ed8bf_screen.jpg?ts=1594616847",
                            Stock = 7,
                            Titulo = "Memory"
                        },
                        new
                        {
                            ISBN = "932442342343",
                            Autor = "Jimmie Collins",
                            Edicion = "7ma",
                            Editorial = "Pearson Education",
                            Imagen = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/sci-fi-kindle-book-cover-design-template-bd12cf83a9f9d72327e372c5db1d2883_screen.jpg?ts=1561443942",
                            Stock = 6,
                            Titulo = "The Invasion Of The Zombie Aliens"
                        });
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Alquiler", b =>
                {
                    b.HasOne("Biblioteca.Domain.Entities.Cliente", "Cliente")
                        .WithMany("AlquilerNavigator")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Domain.Entities.EstadoDeAlquiler", "EstadoDeAlquiler")
                        .WithMany("AlquilerNavigator")
                        .HasForeignKey("EstadoDeAlquilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Domain.Entities.Libro", "Libros")
                        .WithMany("AlquilerNavigator")
                        .HasForeignKey("ISBN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
