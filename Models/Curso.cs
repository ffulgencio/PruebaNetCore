using System.Collections.Generic;

namespace EFCOREDEMO.Models
{

    public class Curso
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        // public int AlumnoId { get; set; }
        // public Alumno Alumno { get; set; }
        // public List<Alumno> Alumnos { get; set; }
        // public List<Profesor> Profesores  { get; set; }
        // public virtual ICollection<Alumno> Alumnos {get; set;}
        public List<AlumnoCurso> AlumnosCursos { get; set; }
    }
}