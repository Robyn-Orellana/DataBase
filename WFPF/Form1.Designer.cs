namespace WFPF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.btnObtenerDatos = new System.Windows.Forms.Button();
            this.lblcarnet = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lblclase = new System.Windows.Forms.Label();
            this.lblseccion = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxparcial1 = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.textBoxparcial2 = new System.Windows.Forms.TextBox();
            this.textBoxparcial3 = new System.Windows.Forms.TextBox();
            this.lblparcial2 = new System.Windows.Forms.Label();
            this.lblparcial3 = new System.Windows.Forms.Label();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(538, 12);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowTemplate.Height = 25;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(641, 613);
            this.dataGridViewAlumnos.TabIndex = 0;
            // 
            // btnObtenerDatos
            // 
            this.btnObtenerDatos.BackColor = System.Drawing.Color.Thistle;
            this.btnObtenerDatos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnObtenerDatos.Location = new System.Drawing.Point(392, 595);
            this.btnObtenerDatos.Name = "btnObtenerDatos";
            this.btnObtenerDatos.Size = new System.Drawing.Size(140, 30);
            this.btnObtenerDatos.TabIndex = 1;
            this.btnObtenerDatos.Text = "Obtener Datos";
            this.btnObtenerDatos.UseVisualStyleBackColor = false;
            this.btnObtenerDatos.Click += new System.EventHandler(this.btnObtenerDatos_Click);
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcarnet.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblcarnet.Location = new System.Drawing.Point(37, 16);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(56, 20);
            this.lblcarnet.TabIndex = 2;
            this.lblcarnet.Text = "Carnet";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnombre.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbnombre.Location = new System.Drawing.Point(37, 59);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(64, 20);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "Nombre";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcorreo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblcorreo.Location = new System.Drawing.Point(37, 99);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(55, 20);
            this.lblcorreo.TabIndex = 4;
            this.lblcorreo.Text = "Correo";
            // 
            // lblclase
            // 
            this.lblclase.AutoSize = true;
            this.lblclase.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblclase.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblclase.Location = new System.Drawing.Point(37, 139);
            this.lblclase.Name = "lblclase";
            this.lblclase.Size = new System.Drawing.Size(45, 20);
            this.lblclase.TabIndex = 5;
            this.lblclase.Text = "Clase";
            // 
            // lblseccion
            // 
            this.lblseccion.AutoSize = true;
            this.lblseccion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblseccion.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblseccion.Location = new System.Drawing.Point(37, 179);
            this.lblseccion.Name = "lblseccion";
            this.lblseccion.Size = new System.Drawing.Size(63, 20);
            this.lblseccion.TabIndex = 6;
            this.lblseccion.Text = "Seccion";
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblp1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblp1.Location = new System.Drawing.Point(37, 219);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(69, 20);
            this.lblp1.TabIndex = 7;
            this.lblp1.Text = "Parcial 1";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCarnet.Location = new System.Drawing.Point(110, 14);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(218, 25);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(110, 56);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(218, 25);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCorreo.Location = new System.Drawing.Point(110, 96);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(218, 25);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // textBoxparcial1
            // 
            this.textBoxparcial1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxparcial1.Location = new System.Drawing.Point(110, 216);
            this.textBoxparcial1.Name = "textBoxparcial1";
            this.textBoxparcial1.Size = new System.Drawing.Size(100, 25);
            this.textBoxparcial1.TabIndex = 11;
            this.textBoxparcial1.Text = "0";
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "PROGRAMACIÓN I",
            "PROGRAMACIÓN 2",
            "PROGRAMACIÓN 3",
            "MATEMATICA"});
            this.comboBoxClase.Location = new System.Drawing.Point(110, 136);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(218, 28);
            this.comboBoxClase.TabIndex = 12;
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(110, 176);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(100, 28);
            this.comboBoxSeccion.TabIndex = 13;
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCrearAlumno.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCrearAlumno.Location = new System.Drawing.Point(37, 391);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(108, 30);
            this.buttonCrearAlumno.TabIndex = 14;
            this.buttonCrearAlumno.Text = "Crear Alumno";
            this.buttonCrearAlumno.UseVisualStyleBackColor = false;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.Location = new System.Drawing.Point(172, 391);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(101, 30);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.Color.Maroon;
            this.buttonConsulta.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConsulta.Location = new System.Drawing.Point(354, 12);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(135, 29);
            this.buttonConsulta.TabIndex = 16;
            this.buttonConsulta.Text = "Consultar Carnet";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click_1);
            // 
            // textBoxparcial2
            // 
            this.textBoxparcial2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxparcial2.Location = new System.Drawing.Point(110, 256);
            this.textBoxparcial2.Name = "textBoxparcial2";
            this.textBoxparcial2.Size = new System.Drawing.Size(100, 25);
            this.textBoxparcial2.TabIndex = 17;
            this.textBoxparcial2.Text = "0";
            // 
            // textBoxparcial3
            // 
            this.textBoxparcial3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxparcial3.Location = new System.Drawing.Point(110, 296);
            this.textBoxparcial3.Name = "textBoxparcial3";
            this.textBoxparcial3.Size = new System.Drawing.Size(100, 25);
            this.textBoxparcial3.TabIndex = 18;
            this.textBoxparcial3.Text = "0";
            // 
            // lblparcial2
            // 
            this.lblparcial2.AutoSize = true;
            this.lblparcial2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblparcial2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblparcial2.Location = new System.Drawing.Point(37, 259);
            this.lblparcial2.Name = "lblparcial2";
            this.lblparcial2.Size = new System.Drawing.Size(69, 20);
            this.lblparcial2.TabIndex = 19;
            this.lblparcial2.Text = "Parcial 2";
            // 
            // lblparcial3
            // 
            this.lblparcial3.AutoSize = true;
            this.lblparcial3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblparcial3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblparcial3.Location = new System.Drawing.Point(37, 299);
            this.lblparcial3.Name = "lblparcial3";
            this.lblparcial3.Size = new System.Drawing.Size(69, 20);
            this.lblparcial3.TabIndex = 20;
            this.lblparcial3.Text = "Parcial 3";
            // 
            // buttonImportar
            // 
            this.buttonImportar.BackColor = System.Drawing.Color.Salmon;
            this.buttonImportar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImportar.Location = new System.Drawing.Point(37, 595);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(108, 30);
            this.buttonImportar.TabIndex = 21;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = false;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.Tomato;
            this.buttonExportar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExportar.Location = new System.Drawing.Point(172, 595);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(101, 30);
            this.buttonExportar.TabIndex = 22;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Brown;
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.Location = new System.Drawing.Point(300, 391);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 30);
            this.buttonEliminar.TabIndex = 23;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1189, 637);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.lblparcial3);
            this.Controls.Add(this.lblparcial2);
            this.Controls.Add(this.textBoxparcial3);
            this.Controls.Add(this.textBoxparcial2);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrearAlumno);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.textBoxparcial1);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.lblseccion);
            this.Controls.Add(this.lblclase);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lblcarnet);
            this.Controls.Add(this.btnObtenerDatos);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Data Base";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAlumnos;
        private Button btnObtenerDatos;
        private Label lblcarnet;
        private Label lbnombre;
        private Label lblcorreo;
        private Label lblclase;
        private Label lblseccion;
        private Label lblp1;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private TextBox textBoxparcial1;
        private ComboBox comboBoxClase;
        private ComboBox comboBoxSeccion;
        private Button buttonCrearAlumno;
        private Button buttonActualizar;
        private Button buttonConsulta;
        private TextBox textBoxparcial2;
        private TextBox textBoxparcial3;
        private Label lblparcial2;
        private Label lblparcial3;
        private Button buttonImportar;
        private Button buttonExportar;
        private Button buttonEliminar;
    }
}