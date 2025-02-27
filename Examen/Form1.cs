namespace Examen
{
    public partial class Form1 : Form
    {
        private Crud crud = new Crud();

        public Form1()
        {
            InitializeComponent();
            CargarAlumnos(); // Cargar los alumnos al iniciar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarAlumno();
        }

        private void button2_Click(object sender, EventArgs e) // Método para eliminar un alumno
        {
            EliminarAlumnoSeleccionado();
        }

        private void button3_Click(object sender, EventArgs e) // Método para modificar la nota de un alumno
        {
            ModificarNotaAlumnoSeleccionado();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MostrarListaAlumnosAP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarListaAlumnosRP();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MostrarListaAlumnosMH();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MostrarListaAlumnoXDni();
        }
        private void CargarAlumnos()
        {
            comboBox1.Items.Clear();
            foreach (Alumno alumno in crud.ObtenerAlumnos())
            {
                comboBox1.Items.Add($"DNI: {alumno.Dni} - Nombre: {alumno.Nombre} - Apellidos: {alumno.Apellido} " +
                    $"Nota: {alumno.Nota}, Calificación: {alumno.Calificacion}");
            }
        }

        private void AbrirFormularioAgregarAlumno()
        {
            Form2 form2 = new Form2(crud);

            // Suscribirse al evento de Form2
            form2.AlumnoAgregado += CargarAlumnos;

            form2.ShowDialog(); // Mostrar Form2 como modal
        }

        private void EliminarAlumnoSeleccionado()
        {
            if (comboBox1.SelectedItem != null)
            {
                // Obtener el texto seleccionado del ComboBox
                string selectedText = comboBox1.SelectedItem.ToString();

                // Extraer el DNI del texto seleccionado
                int dni = int.Parse(selectedText.Split('-')[0].Split(':')[1].Trim());

                // Eliminar el alumno de la lista
                crud.EliminarAlumno(dni);

                // Vaciar el ComboBox
                comboBox1.Items.Clear();
                comboBox1.Refresh();
                // Actualizar el ComboBox
                CargarAlumnos();

                MessageBox.Show("Alumno eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para eliminar");
            }
        }

        private void ModificarNotaAlumnoSeleccionado()
        {
            if (comboBox1.SelectedItem != null)
            {
                // Obtener el texto seleccionado del ComboBox
                string selectedText = comboBox1.SelectedItem.ToString();

                // Extraer el DNI del texto seleccionado
                int dni = int.Parse(selectedText.Split('-')[0].Split(':')[1].Trim());

                // Abrir Form3 para modificar la nota
                ModificarAlumno form3 = new ModificarAlumno(dni);
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la nueva nota desde Form3
                    int nuevaNota = form3.NuevaNota;

                    // Modificar la nota del alumno
                    crud.ModificarAlumno(dni, nuevaNota);

                    // Actualizar el ComboBox
                    CargarAlumnos();

                    MessageBox.Show("Nota del alumno modificada correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para modificar");
            }
        }
        private void MostrarListaAlumnosAP()
        {
            Aprobados form4 = new Aprobados(crud.ObtenerAprobados());
            form4.ShowDialog(); // Mostrar Form4 como modal
        }

        private void MostrarListaAlumnosRP()
        {
            Aprobados form5 = new Aprobados(crud.ObtenerReprobados());
            form5.ShowDialog(); // Mostrar Form5 como modal
        }

        private void MostrarListaAlumnosMH()
        {
            Aprobados form6 = new Aprobados(crud.ObtenerMH());
            form6.ShowDialog(); // Mostrar Form6 como modal

        }
        private void MostrarListaAlumnoXDni()
        {
            if (int.TryParse(textBox1.Text, out int dni))
            {
                Alumno alumno = crud.ObtenerAlumnoPorDni(dni);
                if (alumno != null)
                {
                    List<Alumno> listaAlumnos = new List<Alumno> { alumno };
                    Aprobados form7 = new Aprobados(listaAlumnos);
                    form7.ShowDialog(); // Mostrar Form7 como modal
                }
                else
                {
                    MessageBox.Show("No se encontró un alumno con ese DNI.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI válido.");
            }
        }
    }
}

