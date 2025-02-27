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
            Form2 form2 = new Form2(crud);

            // Suscribirse al evento de Form2
            form2.AlumnoAgregado += CargarAlumnos;

            form2.ShowDialog(); // Mostrar Form2 como modal
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }

}
