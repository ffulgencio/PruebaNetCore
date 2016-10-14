using EFCOREDEMO.Models;
using Microsoft.EntityFrameworkCore;

namespace  EFCOREDEMO{

    public class AppDBContext:DbContext
    {
       public DbSet<Alumno> Alumnos { get; set; }
       public DbSet<Universidad> Universidades { get; set; }
       public DbSet<Carrera> Carreras { get; set; }
       public DbSet<Curso> Cursos { get; set; }
       public DbSet<Profesor> Profesores { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
           optionBuilder.UseSqlite("Filename=./inscripcion.db");

       }
    
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnoCurso>()
                .HasKey(t => new { t.AlumnoId, t.CursoId });

            modelBuilder.Entity<AlumnoCurso>()
                .HasOne(pt => pt.Alumno)
                .WithMany(p => p.AlumnosCursos)
                .HasForeignKey(pt => pt.AlumnoId);

            modelBuilder.Entity<AlumnoCurso>()
                .HasOne(pt => pt.Curso)
                .WithMany(t => t.AlumnosCursos)
                .HasForeignKey(pt => pt.CursoId);
            
        }
    }
}