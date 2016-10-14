using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCOREDEMO;

namespace EfCoreDemo.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("AlumnoCurso", b =>
                {
                    b.Property<int>("AlumnoId");

                    b.Property<int>("CursoId");

                    b.HasKey("AlumnoId", "CursoId");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlumnoCurso");
                });

            modelBuilder.Entity("EFCOREDEMO.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("EFCOREDEMO.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Cedula");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("EFCOREDEMO.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Duracion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("EFCOREDEMO.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Cedula");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("EFCOREDEMO.Universidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Universidades");
                });

            modelBuilder.Entity("AlumnoCurso", b =>
                {
                    b.HasOne("EFCOREDEMO.Models.Alumno", "Alumno")
                        .WithMany("AlumnosCursos")
                        .HasForeignKey("AlumnoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFCOREDEMO.Models.Curso", "Curso")
                        .WithMany("AlumnosCursos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
