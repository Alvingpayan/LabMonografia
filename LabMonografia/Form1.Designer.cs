namespace LabMonografia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarMonografiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEstudianteToolStripMenuItem,
            this.ingresarProfesorToolStripMenuItem,
            this.ingresarMonografiaToolStripMenuItem,
            this.buscarPorDatosToolStripMenuItem,
            this.buscarPorFechasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(838, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarPorFechasToolStripMenuItem
            // 
            this.buscarPorFechasToolStripMenuItem.Image = global::LabMonografia.Properties.Resources.buscando;
            this.buscarPorFechasToolStripMenuItem.Name = "buscarPorFechasToolStripMenuItem";
            this.buscarPorFechasToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.buscarPorFechasToolStripMenuItem.Text = "Buscar por fechas ";
            this.buscarPorFechasToolStripMenuItem.Click += new System.EventHandler(this.buscarPorFechasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::LabMonografia.Properties.Resources.cerrar_sesion;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ingresarEstudianteToolStripMenuItem
            // 
            this.ingresarEstudianteToolStripMenuItem.Image = global::LabMonografia.Properties.Resources.graduado;
            this.ingresarEstudianteToolStripMenuItem.Name = "ingresarEstudianteToolStripMenuItem";
            this.ingresarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.ingresarEstudianteToolStripMenuItem.Text = "Ingresar Estudiante";
            this.ingresarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.ingresarEstudianteToolStripMenuItem_Click);
            // 
            // ingresarProfesorToolStripMenuItem
            // 
            this.ingresarProfesorToolStripMenuItem.Image = global::LabMonografia.Properties.Resources.profesor;
            this.ingresarProfesorToolStripMenuItem.Name = "ingresarProfesorToolStripMenuItem";
            this.ingresarProfesorToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.ingresarProfesorToolStripMenuItem.Text = "Ingresar Profesor";
            this.ingresarProfesorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProfesorToolStripMenuItem_Click);
            // 
            // ingresarMonografiaToolStripMenuItem
            // 
            this.ingresarMonografiaToolStripMenuItem.Image = global::LabMonografia.Properties.Resources.monografia;
            this.ingresarMonografiaToolStripMenuItem.Name = "ingresarMonografiaToolStripMenuItem";
            this.ingresarMonografiaToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.ingresarMonografiaToolStripMenuItem.Text = "Ingresar Monografia";
            this.ingresarMonografiaToolStripMenuItem.Click += new System.EventHandler(this.ingresarMonografiaToolStripMenuItem_Click);
            // 
            // buscarPorDatosToolStripMenuItem
            // 
            this.buscarPorDatosToolStripMenuItem.Image = global::LabMonografia.Properties.Resources.buscar;
            this.buscarPorDatosToolStripMenuItem.Name = "buscarPorDatosToolStripMenuItem";
            this.buscarPorDatosToolStripMenuItem.Size = new System.Drawing.Size(131, 28);
            this.buscarPorDatosToolStripMenuItem.Text = "Buscar Por datos";
            this.buscarPorDatosToolStripMenuItem.Click += new System.EventHandler(this.buscarPorDatosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 410);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarMonografiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

