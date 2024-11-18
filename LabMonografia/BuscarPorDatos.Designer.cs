namespace LabMonografia
{
    partial class BuscarPorDatos
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
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMonografia = new System.Windows.Forms.TextBox();
            this.cbCarnetEstudiante = new System.Windows.Forms.ComboBox();
            this.cbTutores = new System.Windows.Forms.ComboBox();
            this.btnCarnet = new System.Windows.Forms.Button();
            this.btnId = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(165, 42);
            this.dgvMostrarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowHeadersWidth = 62;
            this.dgvMostrarDatos.RowTemplate.Height = 28;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(362, 231);
            this.dgvMostrarDatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet De Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar ID Monografia ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tutor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtIdMonografia
            // 
            this.txtIdMonografia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdMonografia.Location = new System.Drawing.Point(33, 154);
            this.txtIdMonografia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdMonografia.Name = "txtIdMonografia";
            this.txtIdMonografia.Size = new System.Drawing.Size(99, 20);
            this.txtIdMonografia.TabIndex = 4;
            // 
            // cbCarnetEstudiante
            // 
            this.cbCarnetEstudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbCarnetEstudiante.FormattingEnabled = true;
            this.cbCarnetEstudiante.Location = new System.Drawing.Point(31, 67);
            this.cbCarnetEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCarnetEstudiante.Name = "cbCarnetEstudiante";
            this.cbCarnetEstudiante.Size = new System.Drawing.Size(106, 21);
            this.cbCarnetEstudiante.TabIndex = 5;
            // 
            // cbTutores
            // 
            this.cbTutores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbTutores.FormattingEnabled = true;
            this.cbTutores.Location = new System.Drawing.Point(37, 234);
            this.cbTutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTutores.Name = "cbTutores";
            this.cbTutores.Size = new System.Drawing.Size(95, 21);
            this.cbTutores.TabIndex = 6;
            // 
            // btnCarnet
            // 
            this.btnCarnet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarnet.Location = new System.Drawing.Point(33, 89);
            this.btnCarnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCarnet.Name = "btnCarnet";
            this.btnCarnet.Size = new System.Drawing.Size(104, 23);
            this.btnCarnet.TabIndex = 7;
            this.btnCarnet.Text = "Buscar por Carnet";
            this.btnCarnet.UseVisualStyleBackColor = true;
            this.btnCarnet.Click += new System.EventHandler(this.btnCarnet_Click);
            // 
            // btnId
            // 
            this.btnId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnId.Location = new System.Drawing.Point(33, 177);
            this.btnId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(99, 20);
            this.btnId.TabIndex = 8;
            this.btnId.Text = "Buscar por ID";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTutor.Location = new System.Drawing.Point(37, 259);
            this.btnTutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(95, 31);
            this.btnTutor.TabIndex = 9;
            this.btnTutor.Text = "Buscar por tutor";
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // BuscarPorDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(618, 328);
            this.Controls.Add(this.btnTutor);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.btnCarnet);
            this.Controls.Add(this.cbTutores);
            this.Controls.Add(this.cbCarnetEstudiante);
            this.Controls.Add(this.txtIdMonografia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscarPorDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPorDatos";
            this.Load += new System.EventHandler(this.BuscarPorDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMonografia;
        private System.Windows.Forms.ComboBox cbCarnetEstudiante;
        private System.Windows.Forms.ComboBox cbTutores;
        private System.Windows.Forms.Button btnCarnet;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Button btnTutor;
    }
}