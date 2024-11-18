namespace LabMonografia
{
    partial class BuscarPorFechas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarTitulos = new System.Windows.Forms.Button();
            this.btnTotalTrabajos = new System.Windows.Forms.Button();
            this.btnTotalTrabajosProfesor = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblTotalT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FechaInicio";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(5, 129);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FechaFin";
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(8, 157);
            this.cbProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(104, 21);
            this.cbProfesor.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpFechaFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpFechaFin.Location = new System.Drawing.Point(8, 251);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(8, 58);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // btnConsultarTitulos
            // 
            this.btnConsultarTitulos.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarTitulos.Location = new System.Drawing.Point(8, 88);
            this.btnConsultarTitulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarTitulos.Name = "btnConsultarTitulos";
            this.btnConsultarTitulos.Size = new System.Drawing.Size(107, 23);
            this.btnConsultarTitulos.TabIndex = 6;
            this.btnConsultarTitulos.Text = "ConsultarTitulos";
            this.btnConsultarTitulos.UseVisualStyleBackColor = true;
            this.btnConsultarTitulos.Click += new System.EventHandler(this.btnConsultarTitulos_Click);
            // 
            // btnTotalTrabajos
            // 
            this.btnTotalTrabajos.ForeColor = System.Drawing.Color.Black;
            this.btnTotalTrabajos.Location = new System.Drawing.Point(8, 182);
            this.btnTotalTrabajos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalTrabajos.Name = "btnTotalTrabajos";
            this.btnTotalTrabajos.Size = new System.Drawing.Size(104, 21);
            this.btnTotalTrabajos.TabIndex = 7;
            this.btnTotalTrabajos.Text = "Total Trabajos";
            this.btnTotalTrabajos.UseVisualStyleBackColor = true;
            this.btnTotalTrabajos.Click += new System.EventHandler(this.btnTotalTrabajos_Click);
            // 
            // btnTotalTrabajosProfesor
            // 
            this.btnTotalTrabajosProfesor.ForeColor = System.Drawing.Color.Black;
            this.btnTotalTrabajosProfesor.Location = new System.Drawing.Point(8, 286);
            this.btnTotalTrabajosProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalTrabajosProfesor.Name = "btnTotalTrabajosProfesor";
            this.btnTotalTrabajosProfesor.Size = new System.Drawing.Size(107, 23);
            this.btnTotalTrabajosProfesor.TabIndex = 8;
            this.btnTotalTrabajosProfesor.Text = "Total Trabajos Profesor";
            this.btnTotalTrabajosProfesor.UseVisualStyleBackColor = true;
            this.btnTotalTrabajosProfesor.Click += new System.EventHandler(this.btnTotalTrabajosProfesor_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(187, 58);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(405, 227);
            this.dgvResultados.TabIndex = 9;
            // 
            // lblTotalT
            // 
            this.lblTotalT.AutoSize = true;
            this.lblTotalT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalT.Location = new System.Drawing.Point(139, 289);
            this.lblTotalT.Name = "lblTotalT";
            this.lblTotalT.Size = new System.Drawing.Size(24, 20);
            this.lblTotalT.TabIndex = 71;
            this.lblTotalT.Text = "  .";
            // 
            // BuscarPorFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(757, 345);
            this.Controls.Add(this.lblTotalT);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnTotalTrabajosProfesor);
            this.Controls.Add(this.btnTotalTrabajos);
            this.Controls.Add(this.btnConsultarTitulos);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscarPorFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPorFechas";
            this.Load += new System.EventHandler(this.BuscarPorFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnConsultarTitulos;
        private System.Windows.Forms.Button btnTotalTrabajos;
        private System.Windows.Forms.Button btnTotalTrabajosProfesor;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblTotalT;
    }
}