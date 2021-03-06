﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EsteEs.Models
{
    public partial class IglesiaDBContext : IdentityDbContext
    {
        public IglesiaDBContext()
        {
        }

        public IglesiaDBContext(DbContextOptions<IglesiaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatosAcademicos> DatosAcademicos { get; set; }
        public virtual DbSet<DatosEclesiasticos> DatosEclesiasticos { get; set; }
        public virtual DbSet<DatosFamiliares> DatosFamiliares { get; set; }
        public virtual DbSet<DatosLaborales> DatosLaborales { get; set; }
        public virtual DbSet<Integrantes> Integrantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=DESKTOP-KKCEL8F;database=IglesiaDB; persist security info =True; Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

           

            

           
            modelBuilder.Entity<DatosAcademicos>(entity =>
            {
                entity.ToTable("datos_academicos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Expulsado)
                    .HasColumnName("expulsado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdIntegrante).HasColumnName("id_integrante");

                entity.Property(e => e.NivelEstudio)
                    .HasColumnName("nivel_estudio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIntegranteNavigation)
                    .WithMany(p => p.DatosAcademicos)
                    .HasForeignKey(d => d.IdIntegrante)
                    .HasConstraintName("FK_datos_academicos_Integrantes");
            });

            modelBuilder.Entity<DatosEclesiasticos>(entity =>
            {
                entity.ToTable("datos_eclesiasticos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CongregacionAnterior)
                    .HasColumnName("congregacion_anterior")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Denominacion)
                    .HasColumnName("denominacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Disciplinado)
                    .HasColumnName("disciplinado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisciplinadoCausas)
                    .HasColumnName("disciplinado_causas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisciplinadoVeces)
                    .HasColumnName("disciplinado_veces")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechaAceptado)
                    .HasColumnName("fecha_aceptado")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaBautismo)
                    .HasColumnName("fecha_bautismo")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaConversion)
                    .HasColumnName("fecha_conversion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Funciones)
                    .HasColumnName("funciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdIntegrante).HasColumnName("id_integrante");

                entity.Property(e => e.Metas)
                    .HasColumnName("metas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ministerios)
                    .HasColumnName("ministerios")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MinisteriosLlamado)
                    .HasColumnName("ministerios_llamado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MinisteriosMayorFruto)
                    .HasColumnName("ministerios_mayor_fruto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIglesia)
                    .HasColumnName("nombre_iglesia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pastor)
                    .HasColumnName("pastor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Respaldo)
                    .HasColumnName("respaldo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIntegranteNavigation)
                    .WithMany(p => p.DatosEclesiasticos)
                    .HasForeignKey(d => d.IdIntegrante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_datos_eclesiasticos_Integrantes");
            });

            modelBuilder.Entity<DatosFamiliares>(entity =>
            {
                entity.ToTable("datos_familiares");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("estado_civil")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hijos)
                    .HasColumnName("hijos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdIntegrante).HasColumnName("id_integrante");

                entity.HasOne(d => d.IdIntegranteNavigation)
                    .WithMany(p => p.DatosFamiliares)
                    .HasForeignKey(d => d.IdIntegrante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relacion Integrantes/Familiares");
            });

            modelBuilder.Entity<DatosLaborales>(entity =>
            {
                entity.ToTable("datos_laborales");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdIntegrante).HasColumnName("id_integrante");

                entity.Property(e => e.NombreEmpresa)
                    .HasColumnName("nombre_empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ocupacion)
                    .HasColumnName("ocupacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profesion)
                    .HasColumnName("profesion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIntegranteNavigation)
                    .WithMany(p => p.DatosLaborales)
                    .HasForeignKey(d => d.IdIntegrante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tabla Laboral/Integrante");
            });

            modelBuilder.Entity<Integrantes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadNacimiento)
                    .HasColumnName("ciudad_nacimiento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadResidencia)
                    .HasColumnName("ciudad_residencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocIdentidad)
                    .HasColumnName("doc_identidad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imagen).HasColumnType("text");

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaisNacimiento)
                    .HasColumnName("pais_nacimiento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaisResidencia)
                    .HasColumnName("pais_residencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocIdentidad)
                    .HasColumnName("tipo_doc_identidad")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
