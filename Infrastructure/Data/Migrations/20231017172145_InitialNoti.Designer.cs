﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(NotiAppContext))]
    [Migration("20231017172145_InitialNoti")]
    partial class InitialNoti
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Auditoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DesAccion")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("auditoria", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Blockchain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("HasGenerado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdAuditoria")
                        .HasColumnType("int");

                    b.Property<int>("IdHiloRespuestaNotificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoNotificacion")
                        .HasColumnType("int");

                    b.Property<int?>("TipoNotificacionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAuditoria");

                    b.HasIndex("IdHiloRespuestaNotificacion");

                    b.HasIndex("TipoNotificacionesId");

                    b.ToTable("blockchain", (string)null);
                });

            modelBuilder.Entity("Core.Entities.EstadoNotificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreNotificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("estadonotificacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Formato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreFormato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("formato", (string)null);
                });

            modelBuilder.Entity("Core.Entities.GenericovsSubmodulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdMaestrovsSubmodulo")
                        .HasColumnType("int");

                    b.Property<int>("IdPermisosGenericos")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMaestrovsSubmodulo");

                    b.HasIndex("IdPermisosGenericos");

                    b.HasIndex("IdRol");

                    b.ToTable("genericovssubmodulo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.HiloRespuestaNotificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("hilorespuestanotificacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.MaestrovsSubmodulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdModuloMaestro")
                        .HasColumnType("int");

                    b.Property<int>("IdSubmodulo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdModuloMaestro");

                    b.HasIndex("IdSubmodulo");

                    b.ToTable("maestrovssubmodulo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ModuloMaestro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreModulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("modulomaestro", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ModuloNotificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AsuntoNotificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdEstadoNotificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdFormato")
                        .HasColumnType("int");

                    b.Property<int>("IdHiloRespuestaNotificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdRadicados")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoNotificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoRequerimiento")
                        .HasColumnType("int");

                    b.Property<string>("TextoNotificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoNotificacion");

                    b.HasIndex("IdFormato");

                    b.HasIndex("IdHiloRespuestaNotificacion");

                    b.HasIndex("IdRadicados");

                    b.HasIndex("IdTipoNotificacion");

                    b.HasIndex("IdTipoRequerimiento");

                    b.ToTable("modulonotificacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.PermisosGenerico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("MyProperty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("permisosgenerico", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Radicado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("radicados", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("Core.Entities.RolvsMaestro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdModuloMaestro")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdModuloMaestro");

                    b.HasIndex("IdRol");

                    b.ToTable("rolvsmaestro", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Submodulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreSubmodulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("submodulos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoNotificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tiponotificacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoRequerimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreRequerimiento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tiporequerimiento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Blockchain", b =>
                {
                    b.HasOne("Core.Entities.Auditoria", "Auditorias")
                        .WithMany("Blockchains")
                        .HasForeignKey("IdAuditoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.HiloRespuestaNotificacion", "HiloRespuestaNotificaciones")
                        .WithMany("Blockchains")
                        .HasForeignKey("IdHiloRespuestaNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoNotificacion", "TipoNotificaciones")
                        .WithMany("Blockchains")
                        .HasForeignKey("TipoNotificacionesId");

                    b.Navigation("Auditorias");

                    b.Navigation("HiloRespuestaNotificaciones");

                    b.Navigation("TipoNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.GenericovsSubmodulo", b =>
                {
                    b.HasOne("Core.Entities.MaestrovsSubmodulo", "MaestrovsSubmodulos")
                        .WithMany("GenericovsSubmodulos")
                        .HasForeignKey("IdMaestrovsSubmodulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.PermisosGenerico", "PermisosGenericos")
                        .WithMany("GenericovsSubmodulos")
                        .HasForeignKey("IdPermisosGenericos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Rol", "Roles")
                        .WithMany("GenericovsSubmodulos")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaestrovsSubmodulos");

                    b.Navigation("PermisosGenericos");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Core.Entities.MaestrovsSubmodulo", b =>
                {
                    b.HasOne("Core.Entities.ModuloMaestro", "ModuloMaestros")
                        .WithMany("MaestrovsSubmodulos")
                        .HasForeignKey("IdModuloMaestro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Submodulo", "Submodulos")
                        .WithMany("MaestrovsSubmodulos")
                        .HasForeignKey("IdSubmodulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuloMaestros");

                    b.Navigation("Submodulos");
                });

            modelBuilder.Entity("Core.Entities.ModuloNotificacion", b =>
                {
                    b.HasOne("Core.Entities.EstadoNotificacion", "EstadoNotificaciones")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdEstadoNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Formato", "Formatos")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdFormato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.HiloRespuestaNotificacion", "HiloRespuestaNotificaciones")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdHiloRespuestaNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Radicado", "Radicados")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdRadicados")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoNotificacion", "TipoNotificaciones")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdTipoNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoRequerimiento", "TipoRequerimientos")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdTipoRequerimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoNotificaciones");

                    b.Navigation("Formatos");

                    b.Navigation("HiloRespuestaNotificaciones");

                    b.Navigation("Radicados");

                    b.Navigation("TipoNotificaciones");

                    b.Navigation("TipoRequerimientos");
                });

            modelBuilder.Entity("Core.Entities.RolvsMaestro", b =>
                {
                    b.HasOne("Core.Entities.ModuloMaestro", "ModuloMaestros")
                        .WithMany("RolvsMaestros")
                        .HasForeignKey("IdModuloMaestro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Rol", "Roles")
                        .WithMany("RolvsMaestros")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuloMaestros");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Core.Entities.Auditoria", b =>
                {
                    b.Navigation("Blockchains");
                });

            modelBuilder.Entity("Core.Entities.EstadoNotificacion", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.Formato", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.HiloRespuestaNotificacion", b =>
                {
                    b.Navigation("Blockchains");

                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.MaestrovsSubmodulo", b =>
                {
                    b.Navigation("GenericovsSubmodulos");
                });

            modelBuilder.Entity("Core.Entities.ModuloMaestro", b =>
                {
                    b.Navigation("MaestrovsSubmodulos");

                    b.Navigation("RolvsMaestros");
                });

            modelBuilder.Entity("Core.Entities.PermisosGenerico", b =>
                {
                    b.Navigation("GenericovsSubmodulos");
                });

            modelBuilder.Entity("Core.Entities.Radicado", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.Rol", b =>
                {
                    b.Navigation("GenericovsSubmodulos");

                    b.Navigation("RolvsMaestros");
                });

            modelBuilder.Entity("Core.Entities.Submodulo", b =>
                {
                    b.Navigation("MaestrovsSubmodulos");
                });

            modelBuilder.Entity("Core.Entities.TipoNotificacion", b =>
                {
                    b.Navigation("Blockchains");

                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.TipoRequerimiento", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
