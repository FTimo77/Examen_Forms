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
        public List<Alumno> ObtenerAlumnos()
        {
            return lista;
        }
        public bool ExisteAlumnoConDni(int dni)
        {
            return lista.Any(alumno => alumno.Dni == dni);
        }
    }
}
