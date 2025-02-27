using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Alumno
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Nota { get; set; }
        public string Calificacion { get; set; }

        public Alumno(int Dni, string Nombre, string Apellido, int Nota, string Calificacion)
        {
            this.Dni = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nota = Nota;
            this.Calificacion = Calificacion;
        }

        public string imprimirAlumno()
        {
            return $"DNI: {Dni}, Nombre: {Nombre}, Apellido: {Apellido}, Nota: {Nota}, Calificacion: {Calificacion}";
        }
    }
}
