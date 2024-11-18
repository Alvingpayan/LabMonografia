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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IngresarEstudiante E = new IngresarEstudiante();
        IngresarProfesor P = new IngresarProfesor();
        IngresarMonografia M = new IngresarMonografia();
        BuscarPorDatos BD = new BuscarPorDatos();
        BuscarPorFechas BF = new BuscarPorFechas();

        private void ingresarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E.MdiParent = this;
            E.Show ();

            P.Hide ();
            M.Hide ();
            BD.Hide ();
            BF.Hide ();
        }

        private void ingresarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.MdiParent = this;
            P.Show ();

            E.Hide();
            M.Hide();
            BD.Hide();
            BF.Hide();

        }

        private void ingresarMonografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M.MdiParent = this;
            M.Show();

            E.Hide();
            P.Hide();
            BD.Hide();
            BF.Hide();
        }

        private void buscarPorDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BD.MdiParent = this;
            BD.Show();

            E.Hide();
            M.Hide();
            P.Hide();
            BF.Hide();
        }

        private void buscarPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BF.MdiParent = this;
            BF.Show();

            E.Hide();
            M.Hide();
            BD.Hide();
            P.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
