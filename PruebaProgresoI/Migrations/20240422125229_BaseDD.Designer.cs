﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaProgresoI.Data;

#nullable disable

namespace PruebaProgresoI.Migrations
{
    [DbContext(typeof(PruebaProgresoIContext))]
    [Migration("20240422125229_BaseDD")]
    partial class BaseDD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaProgresoI.Models.Carrera", b =>
                {
                    b.Property<int>("CarreraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarreraID"));

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nsemestres")
                        .HasColumnType("int");

                    b.Property<string>("campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarreraID");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("PruebaProgresoI.Models.LCando", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarreraID")
                        .HasColumnType("int");

                    b.Property<bool>("EstaActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarreraID");

                    b.ToTable("LCando");
                });

            modelBuilder.Entity("PruebaProgresoI.Models.LCando", b =>
                {
                    b.HasOne("PruebaProgresoI.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });
#pragma warning restore 612, 618
        }
    }
}