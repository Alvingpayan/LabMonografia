using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabMonografia
{
    public partial class IngresarMonografia : Form
    {
        public IngresarMonografia()
        {
            InitializeComponent();
        }

        private void IngresarMonografia_Load(object sender, EventArgs e)
        {
            LlenarCombos(); // Llenamos los combos cuando se carga el formulario
        }

        public void LlenarCombos()
        {
            // Cargar los profesores para asignar como tutor
            cbTutor.DataSource = Declaraciones.ListaProfesor.ToList();
            cbTutor.DisplayMember = "Nombres";
            cbTutor.ValueMember = "IdProfesor";

            // Cargar los profesores para asignar como jurados
            clbJurado.DataSource = Declaraciones.ListaProfesor.ToList();
            clbJurado.DisplayMember = "Nombres";
            clbJurado.ValueMember = "IdProfesor";

            // Cargar los estudiantes para asignarlos a la monografía
            clbEstudiante.DataSource = Declaraciones.ListaEstudiante.ToList();
            clbEstudiante.DisplayMember = "Nombres";
            clbEstudiante.ValueMember = "Carnet";
        }

        // Generar un ID para la monografía
        int GenerarIdMonografia()
        {
            return Declaraciones.ListaMonografia.Count == 0 ? 1 : Declaraciones.ListaMonografia.Max(m => m.IdMonografia) + 1;
        }

        // Insertar una nueva monografía
        void InsertarMonografia()
        {
            // Validaciones iniciales
            if (cbTutor.SelectedValue == null || clbJurado.CheckedItems.Count != 2 || clbEstudiante.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un tutor, dos jurados y al menos un estudiante para la monografía.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que no se hayan seleccionado más de tres estudiantes
            if (clbEstudiante.CheckedItems.Count > 3)
            {
                MessageBox.Show("Solo puedes seleccionar hasta tres estudiantes para la monografía.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos seleccionados
            int idTutor = (int)cbTutor.SelectedValue;
            List<int> idsJurado = clbJurado.CheckedItems.Cast<Profesor>().Select(p => p.IdProfesor).ToList();
            List<string> carnetsEstudiantes = clbEstudiante.CheckedItems.Cast<Estudiante>().Select(e => e.Carnet).ToList();

            // Validar que el tutor no esté seleccionado como jurado
            if (idsJurado.Contains(idTutor))
            {
                MessageBox.Show("El tutor no puede ser jurado. Por favor, seleccione otros jurados.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva instancia de Monografía
            var nuevaMonografia = new Monografia
            {
                IdMonografia = GenerarIdMonografia(),
                TituloMonografia = txtTitulo.Text,
                CarnetEstudiantes = carnetsEstudiantes,
                FechaDeDefensa = dtpFechaDefensa.Value,
                NotaDeDefensa = ObtenerValorDouble(txtNotaDef.Text),
                TiempoOtorgado = ObtenerValorDouble(txtTiempoOtorgado.Text),
                TiempoDeDefensa = ObtenerValorDouble(txtTiempoDef.Text),
                TiempoDeQyA = ObtenerValorDouble(txtTiempoQyA.Text),
                FechaCreacion = DateTime.Now
            };

            // Agregar la nueva monografía a la lista
            Declaraciones.ListaMonografia.Add(nuevaMonografia);

            // Asignar roles para el tutor y el jurado
            Declaraciones.Listaroles.Add(new mProfesor(nuevaMonografia.IdMonografia, idTutor, "Tutor"));
            foreach (int idJurado in idsJurado)
            {
                Declaraciones.Listaroles.Add(new mProfesor(nuevaMonografia.IdMonografia, idJurado, "Jurado"));
            }

            // Relacionar cada estudiante con la monografía en la lista MonografiaEstudiante
            foreach (string carnet in carnetsEstudiantes)
            {
                Declaraciones.ListamEstudiante.Add(new mEstudiante(nuevaMonografia.IdMonografia, carnet));
            }

            // Mostrar mensaje de éxito y limpiar los campos
            MessageBox.Show("Monografía agregada con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        // Modificar una monografía existente
        private void ModificarMonografia()
        {
            if (int.TryParse(txtId.Text, out int idMonografia))
            {
                var monografia = Declaraciones.ListaMonografia.FirstOrDefault(m => m.IdMonografia == idMonografia);

                if (monografia != null)
                {
                    monografia.TituloMonografia = txtTitulo.Text;
                    monografia.NotaDeDefensa = ObtenerValorDouble(txtNotaDef.Text, monografia.NotaDeDefensa);
                    monografia.TiempoOtorgado = ObtenerValorDouble(txtTiempoOtorgado.Text, monografia.TiempoOtorgado);
                    monografia.TiempoDeDefensa = ObtenerValorDouble(txtTiempoDef.Text, monografia.TiempoDeDefensa);
                    monografia.TiempoDeQyA = ObtenerValorDouble(txtTiempoQyA.Text, monografia.TiempoDeQyA);
                    monografia.FechaDeDefensa = dtpFechaDefensa.Value;

                    MessageBox.Show("Monografía modificada con éxito !!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Monografía no encontrada..ups", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtener el valor en formato double o un valor por defecto
        private double ObtenerValorDouble(string texto, double valorPorDefecto = 0)
        {
            return double.TryParse(texto, out double resultado) ? resultado : valorPorDefecto;
        }

        // Limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtTitulo.Clear();
            txtNotaDef.Clear();
            txtTiempoOtorgado.Clear();
            txtTiempoDef.Clear();
            txtTiempoQyA.Clear();
            cbTutor.SelectedIndex = -1;
            clbJurado.ClearSelected();
            clbEstudiante.ClearSelected();
            dtpFechaDefensa.Value = DateTime.Now;
        }

        // Botón Insertar Monografía
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarMonografia();
        }

        // Botón Modificar Monografía
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarMonografia();
        }

        // Validar que no se seleccionen más de dos jurados
        private void clbJurado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int seleccionados = clbJurado.CheckedItems.Count;

            if (e.NewValue == CheckState.Checked && seleccionados >= 2)
            {
                MessageBox.Show("Solo puedes seleccionar dos profesores como jurado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = CheckState.Unchecked;
            }
        }

        // Validar que no se seleccionen más de tres estudiantes
        private void clbEstudiante_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbEstudiante.CheckedItems.Count >= 3 && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Solo puedes seleccionar hasta tres estudiantes.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = CheckState.Unchecked;
            }
        }
    }
}
