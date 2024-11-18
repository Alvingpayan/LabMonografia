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
    public partial class IngresarEstudiante : Form
    {
        public IngresarEstudiante()
        {
            InitializeComponent();
        }

        private void IngresarEstudiante_Load(object sender, EventArgs e)
        {
            dgvEstudiantes.Columns.Add("Carnet", "Carnet");
            dgvEstudiantes.Columns.Add("Nombres", "Nombres");
            dgvEstudiantes.Columns.Add("Apellidos", "Apellidos");
            dgvEstudiantes.Columns.Add("Direccion", "Dirección");
            dgvEstudiantes.Columns.Add("Telefono", "Teléfono");
            dgvEstudiantes.Columns.Add("AñoNacimiento", "Año de Nacimiento");

            // Llama al método para cargar datos iniciales (si es necesario).
            ActualizarDataGridView();
        }
        void Limpiar()
        {
            txtCarnet.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            dtpAñoNacimiento.ResetText();
        }

        void Insertar()
        {
           
                var Carnet = Declaraciones.ListaEstudiante.FirstOrDefault(x => x.Carnet == txtCarnet.Text);
                if (Carnet != null)
                {
                    MessageBox.Show("Este Carnet de Estudiante ya esta Registrado", "ERRROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtCarnet.Text))
                {
                    MessageBox.Show("Por favor, ingrese un Carnet de Estudiante", "ADVERTENCIA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Declaraciones.ListaEstudiante.Add(new Estudiante
                    {
                        Carnet = txtCarnet.Text,
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Año_de_nacimiento = dtpAñoNacimiento.Value.Date
                    });
                    MessageBox.Show("Estudiante agregado con éxito", "INFORMATION",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    ActualizarDataGridView(); // Actualiza el DataGridView
                
            }

        }

        void Buscar()
        {
            var Buscar = Declaraciones.ListaEstudiante.FirstOrDefault(y => y.Carnet == txtCarnet.Text);
            if (Buscar != null)
            {
                txtNombres.Text = Buscar.Nombres;
                txtApellidos.Text = Buscar.Apellidos;
                txtDireccion.Text = Buscar.Direccion;
                txtTelefono.Text = Buscar.Telefono;
                dtpAñoNacimiento.Value = Buscar.Año_de_nacimiento;
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado o Registrado", "INFORMACIÓN",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        void Modificar()
        {
            string Carnet = txtCarnet.Text;
            var Modifica = Declaraciones.ListaEstudiante.FirstOrDefault(f => f.Carnet == Carnet);
            if (Modifica != null)
            {
                Modifica.Nombres = txtNombres.Text;
                Modifica.Apellidos = txtApellidos.Text;
                Modifica.Direccion = txtDireccion.Text;
                Modifica.Telefono = txtTelefono.Text;
                Modifica.Año_de_nacimiento = dtpAñoNacimiento.Value.Date;

                MessageBox.Show("Datos de Estudiante modificados con éxito", "INFORMATION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                ActualizarDataGridView(); // Actualiza el DataGridView
            }
            else
            {
                MessageBox.Show("No se encontró o no existe el Estudiante deseado a modificar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Eliminar()
        {
            // Busca el estudiante por Carnet en la lista
            var estudianteAEliminar = Declaraciones.ListaEstudiante.FirstOrDefault(x => x.Carnet == txtCarnet.Text);

            if (estudianteAEliminar != null)
            {
                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro de eliminar al estudiante con Carnet: {txtCarnet.Text}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Elimina el estudiante de la lista
                    Declaraciones.ListaEstudiante.Remove(estudianteAEliminar);

                    MessageBox.Show("Estudiante eliminado con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpia los campos de texto
                    Limpiar();

                    // Actualiza el DataGridView
                    ActualizarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún estudiante con este Carnet", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
         void ActualizarDataGridView()
            {
                // Limpia los datos existentes en el DataGridView.
                dgvEstudiantes.Rows.Clear();

                // Recorre la lista y agrega los datos al DataGridView.
                foreach (var estudiante in Declaraciones.ListaEstudiante)
                {
                    dgvEstudiantes.Rows.Add(
                        estudiante.Carnet,
                        estudiante.Nombres,
                        estudiante.Apellidos,
                        estudiante.Direccion,
                        estudiante.Telefono,
                        estudiante.Año_de_nacimiento.ToShortDateString()
                    );
                }
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
