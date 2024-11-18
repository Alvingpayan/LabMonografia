using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMonografia
{
    public partial class BuscarPorDatos : Form
    {
        public BuscarPorDatos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnId_Click(object sender, EventArgs e)
        {
            // Obtener el IdMonografia ingresado en el TextBox
            int idMonografia;
            if (!int.TryParse(txtIdMonografia.Text, out idMonografia))
            {
                MessageBox.Show("Por favor, ingrese un ID de monografía válido.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar los carnets de los estudiantes en ListaMonografiaEstudiante
            var estudiantesCarnets = Declaraciones.ListamEstudiante
                .Where(me => me.IdMonografia == idMonografia)
                .Select(me => me.Carnet)
                .ToList();

            // Obtener información completa de los estudiantes a partir de los carnets
            var estudiantes = Declaraciones.ListaEstudiante
                .Where(es => estudiantesCarnets.Contains(es.Carnet))
                .Select(es => new { es.Carnet, es.Nombres, es.Apellidos })
                .ToList();

            // Mostrar los estudiantes en el DataGridView
            dgvMostrarDatos.DataSource = estudiantes;
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            // Obtener el carnet del estudiante seleccionado en el ComboBox
            var carnetEstudiante = ((Estudiante)cbCarnetEstudiante.SelectedItem).Carnet;

            // Buscar la monografía asociada al carnet del estudiante
            var idMonografia = Declaraciones.ListamEstudiante
                .FirstOrDefault(me => me.Carnet == carnetEstudiante)?.IdMonografia;

            if (idMonografia == null)
            {
                MessageBox.Show("No se encontró una monografía asociada a este estudiante.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener los datos de defensa de la monografía
            var datosDefensa = Declaraciones.ListaMonografia
                .Where(m => m.IdMonografia == idMonografia)
                .Select(m => new { m.TituloMonografia, m.FechaDeDefensa, m.NotaDeDefensa })
                .ToList();

            // Mostrar los datos de defensa en el DataGridView
            dgvMostrarDatos.DataSource = datosDefensa;
        }

        private void BuscarPorDatos_Load(object sender, EventArgs e)
        {
            cbTutores.DataSource = Declaraciones.ListaProfesor;
            cbTutores.DisplayMember = "Nombres";
            cbTutores.ValueMember = "IdProfesor";

            cbCarnetEstudiante.DataSource = Declaraciones.ListaEstudiante;
            cbCarnetEstudiante.DisplayMember = "Carnet";
            cbCarnetEstudiante.ValueMember = "Carnet";
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            // Obtener el ID del profesor seleccionado en el ComboBox
            var tutorId = ((Profesor)cbTutores.SelectedItem).IdProfesor;

            // Buscar los IdMonografia donde el profesor es tutor
            var monografiasComoTutor = Declaraciones.Listaroles
                .Where(r => r.IdProfesor == tutorId && r.Roll.Equals("tutor", StringComparison.OrdinalIgnoreCase))
                .Select(r => r.IdMonografia)
                .ToList();

            // Filtrar las monografías con los Id obtenidos en la búsqueda anterior
            var trabajosTutor = Declaraciones.ListaMonografia
                .Where(m => monografiasComoTutor.Contains(m.IdMonografia))
                .Select(m => new { m.IdMonografia, m.TituloMonografia })
                .ToList();

            // Mostrar los resultados en el DataGridView
            dgvMostrarDatos.DataSource = trabajosTutor;
        }
    }
}
