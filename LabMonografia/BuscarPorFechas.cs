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
    public partial class BuscarPorFechas : Form
    {
        public BuscarPorFechas()
        {
            InitializeComponent();
        }

        private void BuscarPorFechas_Load(object sender, EventArgs e)
        {
            cbProfesor.DataSource = Declaraciones.ListaProfesor;
            cbProfesor.DisplayMember = "Nombre";
            cbProfesor.ValueMember = "IdProfesor";
        }

        private void btnConsultarTitulos_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            // Filtrar las monografías en el rango de fechas y obtener títulos, estudiante y tutor
            var resultados = Declaraciones.ListaMonografia
                .Where(m => m.FechaDeDefensa >= fechaInicio && m.FechaDeDefensa <= fechaFin)
                .Select(m => new
                {
                    Titulo = m.TituloMonografia,
                    Estudiantes = string.Join(", ", m.CarnetEstudiantes),
                    Tutor = Declaraciones.Listaroles
                        .FirstOrDefault(r => r.IdMonografia == m.IdMonografia && r.Roll == "Tutor")?.IdProfesor
                })
                .ToList();

            // Mostrar resultados en DataGridView
            dgvResultados.DataSource = resultados;
        }

        private void btnTotalTrabajos_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            // Contar las monografías en el rango de fechas
            int totalTrabajos = Declaraciones.ListaMonografia
                .Count(m => m.FechaDeDefensa >= fechaInicio && m.FechaDeDefensa <= fechaFin);

            // Mostrar resultado en el label
            lblTotalT.Text = $"Total de trabajos en el rango: {totalTrabajos}";
        }

        private void btnTotalTrabajosProfesor_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            int idProfesor = (int)cbProfesor.SelectedValue;

            // Filtrar monografías donde el profesor es tutor y está en el rango de fechas
            int totalTrabajos = Declaraciones.Listaroles
                .Where(r => r.IdProfesor == idProfesor && r.Roll == "Tutor")
                .Select(r => r.IdMonografia)
                .Distinct()
                .Count(idMonografia => Declaraciones.ListaMonografia
                    .Any(m => m.IdMonografia == idMonografia && m.FechaDeDefensa >= fechaInicio && m.FechaDeDefensa <= fechaFin));

            // Mostrar resultado en el label
            lblTotalT.Text = $"Total de trabajos por profesor en el rango: {totalTrabajos}";
        }

       
    }
}
