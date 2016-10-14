using System.Collections.Generic;

namespace EFCOREDEMO.Models
{

    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        // public int UniversidadId { get; set; }
        // public Universidad Universidad {get; set;}
        // public int CarreraId {get; set;}
        // public Carrera Carreras {get;set;}
        // public virtual ICollection<Curso> Cursos {get; set;}
        public List<AlumnoCurso>  AlumnosCursos { get; set; }
    }
}