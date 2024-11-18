using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMonografia
{
    public partial class IngresarProfesor : Form
    {
        public IngresarProfesor()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtApellidos.Clear();
            txtNombres.Clear();
            txtIdProfesor.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dtpAñoNacimiento.ResetText();
            cmbRol.SelectedIndex = -1;  // Limpiar selección del ComboBox de rol
        }

        void Insertar()
        {
            // Validar si el ID ya está registrado
            var Id = Declaraciones.ListaProfesor.FirstOrDefault(x => x.IdProfesor == int.Parse(txtIdProfesor.Text));
            if (Id != null)
            {
                MessageBox.Show("Este Id de profesor ya esta registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtIdProfesor.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID de Profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un rol para el profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Obtener el rol seleccionado desde el ComboBox
                string rolSeleccionado = cmbRol.SelectedItem.ToString();

                Declaraciones.ListaProfesor.Add(new Profesor
                {
                    IdProfesor = int.Parse(txtIdProfesor.Text),
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    AñoDeNacimiento = dtpAñoNacimiento.Value.Date,
                    Rol = rolSeleccionado  // Asignar el rol
                });

                MessageBox.Show("Profesor agregado con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                ActualizarDataGridView();
            }
        }

        void Buscar()
        {
            var Buscar = Declaraciones.ListaProfesor.FirstOrDefault(y => y.IdProfesor == int.Parse(txtIdProfesor.Text));
            if (Buscar != null)
            {
                txtNombres.Text = Buscar.Nombres;
                txtApellidos.Text = Buscar.Apellidos;
                txtDireccion.Text = Buscar.Direccion;
                txtTelefono.Text = Buscar.Telefono;
                dtpAñoNacimiento.Value = Buscar.AñoDeNacimiento;
                cmbRol.SelectedItem = Buscar.Rol;  // Mostrar el rol en el ComboBox
            }
            else
            {
                MessageBox.Show("Profesor no encontrado o registrado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        void Modificar()
        {
            int Id = int.Parse(txtIdProfesor.Text);
            var Modifica = Declaraciones.ListaProfesor.FirstOrDefault(f => f.IdProfesor == Id);
            if (Modifica != null)
            {
                Modifica.Nombres = txtNombres.Text;
                Modifica.Apellidos = txtApellidos.Text;
                Modifica.Direccion = txtDireccion.Text;
                Modifica.Telefono = txtTelefono.Text;
                Modifica.AñoDeNacimiento = dtpAñoNacimiento.Value.Date;
                Modifica.Rol = cmbRol.SelectedItem.ToString();  // Modificar el rol también

                MessageBox.Show("Datos de Profesor modificados con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se encontró o no existe el Profesor a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Eliminar()
        {
            int idBuscado = int.Parse(txtIdProfesor.Text);
            var profesorAEliminar = Declaraciones.ListaProfesor.FirstOrDefault(x => x.IdProfesor == idBuscado);

            if (profesorAEliminar != null)
            {
                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro de eliminar al profesor con ID: {txtIdProfesor.Text}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Declaraciones.ListaProfesor.Remove(profesorAEliminar);

                    MessageBox.Show("Profesor eliminado con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    ActualizarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún profesor con este ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarDataGridView()
        {
            dgvProfesores.Rows.Clear();

            foreach (var profesor in Declaraciones.ListaProfesor)
            {
                dgvProfesores.Rows.Add(
                    profesor.IdProfesor,
                    profesor.Nombres,
                    profesor.Apellidos,
                    profesor.Direccion,
                    profesor.Telefono,
                    profesor.AñoDeNacimiento.ToShortDateString(),
                    profesor.Rol  // Mostrar el rol
                );
            }
        }

        private void IngresarProfesor_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox con los roles posibles
            cmbRol.Items.Add("Profesor");
            cmbRol.Items.Add("Jurado");

            dgvProfesores.Columns.Add("IdProfesor", "ID");
            dgvProfesores.Columns.Add("Nombres", "Nombres");
            dgvProfesores.Columns.Add("Apellidos", "Apellidos");
            dgvProfesores.Columns.Add("Direccion", "Dirección");
            dgvProfesores.Columns.Add("Telefono", "Teléfono");
            dgvProfesores.Columns.Add("AñoDeNacimiento", "Año de Nacimiento");
            dgvProfesores.Columns.Add("Rol", "Rol");

            ActualizarDataGridView();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

     
    }
}
