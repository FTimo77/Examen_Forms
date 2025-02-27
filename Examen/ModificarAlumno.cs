using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class ModificarAlumno : Form
    {
        private int dni;
        public int NuevaNota { get; set; }
        public ModificarAlumno(int dni)
        {
            InitializeComponent();
            this.dni = dni;
            this.Text = "Modificar Nota";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int nuevaNota) && nuevaNota <= 10) // Verificar si la nota es válida
            {
                NuevaNota = nuevaNota; // Asignar la nueva nota
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese una nota válida (0-10).");
            }
        }
    }
}
