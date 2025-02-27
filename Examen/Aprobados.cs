using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Aprobados : Form
    {
        public Aprobados(List<Alumno> alumnos)
        {
            InitializeComponent();
            CargarAlumnos(alumnos);
        }
        private void CargarAlumnos(List<Alumno> alumnos)
        {
            dataGridView1.DataSource = alumnos;
        }
    }
}
