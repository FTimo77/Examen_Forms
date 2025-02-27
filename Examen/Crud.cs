using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Crud
    {
        public List<Alumno> lista = new List<Alumno>();

        public void Agregar(Alumno obj)
        {
            lista.Add(obj);
        }
        public List<Alumno> ObtenerAlumnos() // Método para obtener la lista de alumnos
        {
            return lista;
        }
        public List<Alumno> ObtenerAprobados() // Método para obtener la lista de alumnos aprobados
        {
            return lista.Where(alumno => alumno.Calificacion == "AP" || alumno.Calificacion == "NT" || alumno.Calificacion == "SB").ToList();
        }
        public List<Alumno> ObtenerReprobados() // Método para obtener la lista de alumnos reprobados
        {
            return lista.Where(alumno => alumno.Calificacion == "SS").ToList();
        }

        public List<Alumno> ObtenerMH() // Método para obtener la lista de alumnos con la máxima nota
        {
            int maxNota = lista.Max(alumno => alumno.Nota);
            return lista.Where(alumno => alumno.Nota == maxNota).ToList();
        }

        public Alumno ObtenerAlumnoPorDni(int dni) // Método para obtener un alumno por su DNI
        {
            return lista.FirstOrDefault(a => a.Dni == dni);
        }
        public bool ExisteAlumnoConDni(int dni) // Método para verificar si existe un alumno con un DNI específico
        {
            return lista.Any(alumno => alumno.Dni == dni);
        }
        public void EliminarAlumno(int dni) // Método para eliminar un alumno de la lista
        {
            var alumno = lista.FirstOrDefault(a => a.Dni == dni);
            if (alumno != null)
            {
                lista.Remove(alumno);
            }
        }
        public void ModificarAlumno(int dni, int nuevaNota)
        {
            var alumno = lista.FirstOrDefault(a => a.Dni == dni);
            if (alumno != null)
            {
                alumno.Nota = nuevaNota;
                alumno.Calificacion = nuevaNota switch
                {
                    < 5 => "SS",
                    >= 5 and < 7 => "AP",
                    >= 7 and < 9 => "NT",
                    >= 9 and <= 10 => "SB",
                    _ => alumno.Calificacion // Mantener la calificación actual si la nota no es válida
                };
            }
        }
    }
}
