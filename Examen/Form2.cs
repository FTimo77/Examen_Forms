using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form2 : Form
    {
        private Crud crud;

        // Evento que notifica a Form1 cuando se agrega un alumno
        public event Action AlumnoAgregado;

        public Form2(Crud crud)
        {
            InitializeComponent();
            this.crud = crud;
            this.Text = "Agregar Alumno";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Calificacion = "";
                Calificacion = int.Parse(textBox4.Text) switch
                {
                    < 5 => "SS",
                    >= 5 and < 7 => "AP",
                    >= 7 and < 9 => "NT",
                    >= 9 and <= 10 => "SB",
                    > 10 => throw new ArgumentOutOfRangeException("La nota no puede ser mayor a 10")
                };
                Alumno alumno = new Alumno(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, 
                    int.Parse(textBox4.Text), Calificacion); // Crear un nuevo objeto Alumno

                if (crud.ExisteAlumnoConDni(alumno.Dni))
                {
                    MessageBox.Show("Ya existe un alumno con ese DNI");
                    return;
                }
                else
                {
                    crud.Agregar(alumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el alumno: " + ex.Message);
                return;
            }



            // Dispara el evento para que Form1 actualice el ComboBox
            AlumnoAgregado?.Invoke();

            MessageBox.Show("Alumno agregado correctamente");
            this.Close(); // Cierra la ventana después de agregar
        }
    }

}
